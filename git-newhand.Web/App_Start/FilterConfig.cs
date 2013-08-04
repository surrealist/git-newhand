using System.Web;
using System.Web.Mvc;

namespace git_newhand.Web {
  public class FilterConfig {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
      filters.Add(new HandleErrorAttribute());
    }
  }
}