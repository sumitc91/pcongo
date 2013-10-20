using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pcongo.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }


        public virtual ActionResult Details(String id)
        {

            var db = new pcongoEntities();
            String RedirectToView = "Linux";
            var userDetails = db.users.SingleOrDefault(x => x.Username == id);
            user user = userDetails;

            if(user.Username=="sumit91")
            {
                RedirectToView = "Windows";
            }

            return View(RedirectToView, user);
        }

        public virtual ActionResult Linux(String id)
        {

            var db = new pcongoEntities();
            var userDetails = db.users.SingleOrDefault(x => x.Username == id);
            user user = userDetails;



            return View("Details", user);
        }

        public virtual ActionResult Windows(String id)
        {

            var db = new pcongoEntities();
            var userDetails = db.users.SingleOrDefault(x => x.Username == id);
            user user = userDetails;



            return View("Details", user);
        }

    }
}
