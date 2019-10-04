using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace slnMVCImageUpload.Controllers
{
    using slnMVCImageUpload.Models;

    public class UploadFormController : Controller
    {
     
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult UploadForm(FormModel model)
        {
          
            return Json(Convert.ToString("formuploaded"), JsonRequestBehavior.AllowGet);
        }
    }
}
