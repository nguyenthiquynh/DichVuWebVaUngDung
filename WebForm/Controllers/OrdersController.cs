using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebForm.CTDHService;
using WebForm.DonHangService;
using WebForm.TonKhoService;

namespace WebForm.Controllers
{
    public class OrdersController : Controller
    {
        DonDHService1Client ord = new DonDHService1Client();
        CtDonDHServiceClient ctdh = new CtDonDHServiceClient();
        //
        // GET: /Orders/

        public ActionResult OrdersManager()
        {
            return View(ord.HienThiDonDH());
        }

        public ActionResult Detail(int id)
        {
            return View(ctdh.Searid(id));
        }

    }
}
