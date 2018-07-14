using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindJob.Web.Controllers.Admin
{
    public class AdminController : Controller
    {
        FindJob.BLL.T_Base_Admin bll = new BLL.T_Base_Admin();
        //
        // GET: /admin/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EPIndex()
        {
            return View();
        }
        public JsonResult EPGetList(int pageSize, int pageIndex, string EPName)
        {

            List<FindJob.Model.T_Base_Enterprise> lst = new List<FindJob.Model.T_Base_Enterprise>();
            lst = bll.GetList(pageIndex, pageSize, EPName);
            int count = bll.EPCount();
            return Json(new { total = count, rows = lst });
            //return Json(lst);
        }
        public JsonResult EPDelete(string []Ids)
        {
            FindJob.BLL.T_Base_Admin bll = new BLL.T_Base_Admin();
            bll.EPDelete(Ids);
            return Json(new FindJob.Model.Message() { Code = 1, Content = "删除成功" });
        }
  
	}
}