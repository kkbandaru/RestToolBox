using RestToolBox.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestToolBox.Controllers
{
    public class JsonViewerController : Controller
    {
        // GET: JsonViewer
        [Route("JsonViewer", Name=JsonViewerControllerRoute.GetIndex)]
        public ActionResult Index()
        {
            return this.View(JsonViewerControllerAction.Index);
        }
    }
}