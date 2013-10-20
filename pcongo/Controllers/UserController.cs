using pcongo.Models;
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
            DesktopViewModel DesktopView = new DesktopViewModel();
            DesktopView.userbackgroundimage = db.UserBackgroundImages.SingleOrDefault(x => x.UserId == id);
            DesktopView.userfolder = db.UserFolders.OrderByDescending(x => x.Username == id).ToList();
            DesktopView.user = db.users.SingleOrDefault(x => x.Username == id);

            if( DesktopView.user.Username=="sumit91")
            {
                RedirectToView = "Windows";
            }

            return View(RedirectToView, DesktopView);
        }

        public virtual ActionResult Linux(String id)
        {

            var db = new pcongoEntities();
            //var userDetails = db.users.SingleOrDefault(x => x.Username == id);
            DesktopViewModel DesktopView = new DesktopViewModel();
            DesktopView.userbackgroundimage = db.UserBackgroundImages.SingleOrDefault(x => x.UserId == id);
            DesktopView.userfolder = db.UserFolders.OrderByDescending(x => x.Username == id).ToList();
            

            DesktopView.user = db.users.SingleOrDefault(x => x.Username == id);
            return View("Details", DesktopView);
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
