using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace git_newhand.Web.Controllers {
  public class TodoController : Controller {
    //
    // GET: /Todo/

    public ActionResult Index() {
      return View();
    }

  }
}
