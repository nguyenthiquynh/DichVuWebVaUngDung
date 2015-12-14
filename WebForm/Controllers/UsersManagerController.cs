using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebForm.NguoiDungService;

namespace WebForm.Controllers
{
    public class UsersManagerController : Controller
    {

        NguoiDungService1Client user = new NguoiDungService1Client();
        //
        // GET: /UsersManager/

        public ActionResult UserManager()
        {
            return View(user.listuser());
        }

        public ActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(NguoiDung u)
        {
            if(user.Create(u) == true )
            {
                ViewBag.Suscess = "Thêm thành công";
                return RedirectToAction("UsersManager");
            }
            return View(u);
        }

        public ActionResult Edit(int ID)
        {
            
            return View(user.Searchid(ID));
        }
        [HttpPost]
        public ActionResult Edit(NguoiDung u, int ID)
        {
            if(user.Edit(u,ID) == true)
            {
                return RedirectToAction("UserManager");
            }
            return View(u);
        }

        public ActionResult Delete(int ID)
        {
            user.Delete(ID);
            return RedirectToAction("UserManager");
        }
       

        public ActionResult Lock(int ID)
        {
            user.Lock(ID);
            return RedirectToAction("UserManager");
        }

        public ActionResult Unlock(int ID)
        {
            user.Unlock(ID);
            return RedirectToAction("UserManager");
        }
        
    }
}
