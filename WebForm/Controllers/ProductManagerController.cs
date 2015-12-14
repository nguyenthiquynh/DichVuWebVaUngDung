using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebForm.SanPhamService;
using WebForm.TonKhoService;

namespace WebForm.Controllers
{
    public class ProductManagerController : Controller
    {
        SanPhamService1Client pro = new SanPhamService1Client();
        TonKhoService1Client ton = new TonKhoService1Client();
        //
        // GET: /ProductManager/

        public ActionResult ProductManager()
        {
            return View(pro.listpro());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SanPham sp)
        {
            if(pro.Create(sp))
            {
                ViewBag.Suscess = "Thêm thành công";
                return RedirectToAction("ProductManager");
            }
            return View(sp);
        }

        public ActionResult Edit(int ID)
        {
            return View(pro.Detail(ID));
        }
        [HttpPost]
        public ActionResult Edit(SanPham sp, int ID)
        {
            if(pro.Edit(sp,ID))
            {
                return RedirectToAction("ProductManager");
            }
            return View(sp);
        }

        public ActionResult Delete(int ID)
        {
            pro.Delete(ID);
            return RedirectToAction("ProductManager");
        }
    }
}
