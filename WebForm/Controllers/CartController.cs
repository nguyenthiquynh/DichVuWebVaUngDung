using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebForm.CartServiceReference;
using WebForm.NguoiDungService;
using WebForm.SanPhamService;

namespace WebForm.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /Cart/
        CartServiceClient cart = new CartServiceReference.CartServiceClient();
        SanPhamService1Client sp = new SanPhamService1Client();
        NguoiDungService1Client user = new NguoiDungService1Client();


        public ActionResult Index()
        {
            List<CartItem> objcart = (List<CartItem>)Session["CartItem"];
            string customerId = (string)Session["LogedUserID"];
            if (customerId != null)
            {
                int id = int.Parse(customerId);
                var customer = user.Searchid(int.Parse(customerId));
                string billing = "";
                billing += "<div class=\"billing-address\">";
                billing += "<h2 class=\"border h1\">Thông tin khách hàng</h2>";
                billing += "<form>";
                billing += "<div class=\"row field-row\">";
                billing += "<div class=\"col-xs-12 col-sm-6\">";
                billing += "<label>Tên:*</label>";
                billing += "<input id=\"ten\" class=\"le-input\" value=\"" + customer.Ten + "\" readonly>";
                billing += "</div>";
                billing += "<div class=\"col-xs-12 col-sm-6\">";
                billing += "<label>Số điện thoại:*</label>";
                billing += "<input id=\"sdt\" class=\"le-input\" value=\"" + customer.SoDienThoai + "\">";
                billing += "</div>";
                billing += "</div><!-- /.field-row -->";
                billing += "<div class=\"row field-row\">";
                billing += "<div class=\"col-xs-12\">";
                billing += "<label>Địa chỉ:*</label>";
                billing += "<input id=\"diachi\" class=\"le-input\" value=\"" + customer.DiaChi + "\">";
                billing += "</div>";
                billing += "</div><!-- /.field-row -->";
                billing += "</div><!-- /.field-row -->";
                billing += "<div class=\"row field-row\">";
                billing += "<div class=\"col-xs-12\">";
                billing += "<label>Email:*</label>";
                billing += "<input id=\"email\" class=\"le-input\" value=\"" + customer.Email + "\">";
                billing += "</div>";
                billing += "</div><!-- /.field-row -->";
                billing += "<div class=\"row field-row\">";
                billing += "<div class=\"col-xs-12 col-sm-4\">";
                billing += "<label>Ngày mua hàng:</label>";
                billing += "<input id=\"ngay\" class=\"le-input\" value=\"" + DateTime.Today.ToString("dd-MM-yyyy") + "\" readonly>";
                billing += "</div>";
                billing += "<div class=\"col-xs-12 col-sm-4\">";
                billing += "<input id=\"Id\" class=\"le-input\" value=\"" + customer.ID + "\" type=\"hidden\" readonly>";
                billing += "</div>";
                billing += "</div><!-- /.field-row -->";
                billing += "<div class=\"row field-row\">";
                billing += "<div id=\"create-account\" class=\"col-xs-12\">";
                billing += "</div>";
                billing += "</div><!-- /.field-row -->";
                billing += "</form>";
                billing += "</div>";
                ViewBag.Billing = billing;
            }
            else
            {
                string billing = "";
                billing += "<div class=\"billing-address\">";
                billing += "<h2 class=\"border h1\">Thông tin hóa đơn</h2>";
                billing += "<form>";
                billing += "<div class=\"row field-row\">";
                billing += "<div class=\"col-xs-12 col-sm-6\">";
                billing += "<label>Tên:*</label>";
                billing += "<input id=\"ten\" class=\"le-input\">";
                billing += "</div>";
                billing += "<div class=\"col-xs-12 col-sm-6\">";
                billing += "<label>Số điện thoại:*</label>";
                billing += "<input id=\"sdt\" class=\"le-input\">";
                billing += "</div>";
                billing += "</div><!-- /.field-row -->";
                billing += "<div class=\"row field-row\">";
                billing += "<div class=\"col-xs-12\">";
                billing += "<label>Địa chỉ:*</label>";
                billing += "<input id=\"diachi\" class=\"le-input\">";
                billing += "</div>";
                billing += "</div><!-- /.field-row -->";
                billing += "<div class=\"row field-row\">";
                billing += "<div class=\"col-xs-12 col-sm-4\">";
                billing += "<label>Ngày mua hàng:</label>";
                billing += "<input id=\"ngay\" class=\"le-input\" value=\"" + DateTime.Today.ToString("dd-MM-yyyy") + "\" readonly>";
                billing += "</div>";
                billing += "<div class=\"col-xs-12 col-sm-4\">";
                billing += "<input id=\"Id\" class=\"le-input\" value=\"0\" type=\"hidden\" readonly>";
                billing += "</div>";
                billing += "</div><!-- /.field-row -->";
                billing += "<div class=\"row field-row\">";
                billing += "<div id=\"create-account\" class=\"col-xs-12\">";
                billing += "<a class=\"simple-link bold\" href=\"#\">Đăng kí tài khoản</a>";
                billing += "</div>";
                billing += "</div><!-- /.field-row -->";
                billing += "</form>";
                billing += "</div>";
                ViewBag.Billing = billing;
            }
            string order = "";
            int proId = 0;
            decimal total = 0;
            if ((objcart != null) && (objcart.Count > 0))
                foreach (CartItem item in objcart)
                {
                    order += "<div class=\"row no-margin order-item\">";
                    order += "<div class=\"col-xs-12 col-sm-1 no-margin\">";
                    order += "<a href=\"#\" class=\"qty\">" + item.Quantity + "x</a>";
                    order += "</div>";
                    order += "<div class=\"col-xs-12 col-sm-9 \">";
                    order += "<div class=\"title\"><a href=\"#\">" + item.Product.SP_ID + "</a></div>";
                    //order += "<div class=\"brand\">" + item.SalesMan + "</div>";
                    order += "</div>";
                    order += "<div class=\"col-xs-12 col-sm-2 no-margin\">";
                    order += "<div class=\"price\">" + item.Product.DonGia*item.Quantity + "</div>";
                    order += "</div>";
                    order += "</div><!-- /.order-item -->";
                    total += (int)item.Product.DonGia * item.Quantity;
                    proId = item.Product.SP_ID;
                }
            ViewBag.Order = order;
            ViewBag.Total = total;
            ViewBag.ProductID = proId;
            Session["OrderTotal"] = total;
            try
            {
                ViewBag.NumberOrder = objcart.Count;
                if (customerId != null)
                {
                    ViewBag.ID = int.Parse(customerId);
                }
                else
                {
                    ViewBag.ID = "";
                }
            }
            catch
            {
                ViewBag.Message = "Giỏ hàng trống!";
            }
            return View();
        }

        public void MakeOrder(string hoten, string diachi, string sdt, string email)
        {
            List<CartItem> cartItem = (List<CartItem>)Session["CartItem"];
            string total =Session["OrderTotal"].ToString();
            string id = null;
            if(Session["LogedUserId"]!=null)
            {
                id = Session["LogedUserId"].ToString();
            }
            bool check = cart.CheckOut(hoten, diachi, sdt, email,  total, id, cartItem);
            if(check)
            {
                Session["CartItem"] = null;
                //return RedirectToAction("Index", "Home");
            }
            //return View();
        }

        public ActionResult AddItem(int spid, int quantity)
        {
            
            var cartItem = Session["CartItem"];
            var sanpham = sp.Searchid(spid);
            
            if(cartItem!=null)
            {
                var list = (List<CartItem>)cartItem;
                if(list.Exists(x=>x.Product.SP_ID==spid))
                {
                    foreach(var item in list)
                    {
                        if(item.Product.SP_ID==spid)
                        {
                            item.Quantity += quantity;
                        }
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.Product = new WebForm.CartServiceReference.SanPham()
                    {
                        SP_ID = sanpham.SP_ID,
                        TenSP = sanpham.TenSP,
                        NhaSX_ID = sanpham.NhaSX_ID,
                        CPU = sanpham.CPU,
                        RAM = sanpham.RAM,
                        HDD = sanpham.HDD,
                        BaoHanh = sanpham.BaoHanh,
                        DonGia = sanpham.DonGia,
                        Hinh = sanpham.Hinh,
                        MoTa = sanpham.MoTa,
                    };
                    item.Quantity = quantity;
                    list.Add(item);
                }
                Session["CartItem"] = list;
            }
            else
            {
                var item = new CartItem();
                item.Product = new WebForm.CartServiceReference.SanPham()
                {
                    SP_ID = sanpham.SP_ID,
                    TenSP = sanpham.TenSP,
                    NhaSX_ID = sanpham.NhaSX_ID,
                    CPU = sanpham.CPU,
                    RAM = sanpham.RAM,
                    HDD = sanpham.HDD,
                    BaoHanh = sanpham.BaoHanh,
                    DonGia = sanpham.DonGia,
                    Hinh = sanpham.Hinh,
                    MoTa = sanpham.MoTa,
                };
                item.Quantity = quantity;
                List<CartItem> list = new List<CartItem>();
                list.Add(item);

                Session["CartItem"] = list;
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
