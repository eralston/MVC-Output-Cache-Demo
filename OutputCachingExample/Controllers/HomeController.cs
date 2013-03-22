using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutputCachingExample.Controllers
{
    /// <summary>
    /// This single control holds all actions and child actions for the demo, each with only default implementation
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Listing for each demo page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(DateTime.Now);
        }

        #region Basic Actions

        public ViewResult BasicAction()
        {
            return View(DateTime.Now);
        }

        public ViewResult BasicActionWithPartial()
        {
            return View(DateTime.Now);
        }

        public ViewResult BasicActionWithBasicChild()
        {
            return View(DateTime.Now);
        }

        [ChildActionOnly]
        public ViewResult BasicChildAction()
        {
            return View(DateTime.Now);
        }

        #endregion

        #region Cached Actions

        [OutputCache(Duration = 10)]
        public ViewResult CachedAction()
        {
            return View(DateTime.Now);
        }

        [OutputCache(Duration = 10)]
        public ViewResult CachedActionWithCachedChild()
        {
            return View(DateTime.Now);
        }

        [OutputCache(Duration = 10)]
        public ViewResult CachedActionWithPartial()
        {
            return View(DateTime.Now);
        }

        [OutputCache(Duration = 10)]
        [ChildActionOnly]
        public ViewResult CachedChildAction()
        {
            return View(DateTime.Now);
        }

        #endregion

        #region Mixed Actions

        public ViewResult BasicActionWithCachedChild()
        {
            return View(DateTime.Now);
        }

        [OutputCache(Duration=10)]
        public ViewResult CachedActionWithBasicChild()
        {
            return View(DateTime.Now);
        }

        #endregion


    }
}
