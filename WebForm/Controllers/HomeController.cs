using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebForm.NguoiDungService;
using WebForm.SanPhamService;
using WebForm.TonKhoService;

namespace WebForm.Controllers
{
    public class HomeController : Controller
    {

        SanPhamService1Client sp = new SanPhamService1Client();
        NguoiDungService1Client user = new NguoiDungService1Client();
        TonKhoService1Client ton = new TonKhoService1Client();
        //
        // GET: /Home/
        
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Category(int ID)
        {
           
            return View(ID);
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(NguoiDung u)
        {
            if(true)
            {
                Session["Success"] = "Đăng ký thành công";
                return RedirectToAction("Authentication");
            }
            else
            {
               Session["Success"] = "Vui lòng nhập thông tin đầy đủ và chính xác";
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Authentication()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authentication(string Username,string Password)
        {
            string i = Username;
            string p = Password;
            var temp = user.Authentication(Username,Password);
            if(temp!=null)
            {
                Session["LogedUserRule"] = temp.Quyen.ToString();
                Session["LogedUserID"] = temp.ID.ToString();
                Session["LogedUserFullname"] = temp.Ten.ToString();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Tên đăng nhập hoặc mật khẩu không đúng, vui lòng nhập lại!";
                return RedirectToAction("Authentical","Index");
            }
        }

        public ActionResult Detail (int ID)
        {
            var tk = ton.SoLuongTonKho_SPID(ID);
            var products = sp.Detail(ID);
            ViewBag.ID = products.SP_ID;
            ViewBag.Name = products.TenSP;
            ViewBag.Detail = products.MoTa;
            ViewBag.Price = products.DonGia;
            ViewBag.Image = products.Hinh;
            ViewBag.Quantity = tk.ToString();
            int Group_Id = products.NhaSX_ID;
            ViewBag.UName = "";
            return View();
        }


    }
}
