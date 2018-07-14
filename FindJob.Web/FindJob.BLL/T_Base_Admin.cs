using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindJob.BLL
{
    public class T_Base_Admin
    {
        public FindJob.DAL.T_Base_Admin dal = new DAL.T_Base_Admin();
        public List<FindJob.Model.T_Base_Enterprise> GetList(int CurrentPage, int PageSize, string EPName)
        {
            return dal.GetList(CurrentPage, PageSize, EPName);
        }
        public int EPCount()
        {
            return dal.EPCount();
        }
        public int EPDelete(string[] ids)
        {
            //防止注入式漏洞
            string idstring = string.Join(", ", ids);
            return dal.EPDelete(idstring);
        }
    }
}
