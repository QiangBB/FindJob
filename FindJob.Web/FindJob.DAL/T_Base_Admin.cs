using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace FindJob.DAL
{
    public class T_Base_Admin
    {
        public string constr = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
        public List<FindJob.Model.T_Base_Enterprise> GetList(int CurrentPage, int PageSize, string EPName)
        {
            SqlConnection co = new SqlConnection();
            co.ConnectionString = constr;
            co.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = co;
            //cm.CommandText = "select * from t_base_FindJob";
            EPName = "'%" + EPName + "%'";

            cm.CommandText = "select top " + PageSize + " * from  T_Base_Enterprise where  id not in (select top " + PageSize * (CurrentPage - 1) + " id from T_Base_Enterprise where Name like " + EPName + ")     and  Name like " + EPName;
            //cm.Parameters.AddWithValue("@pageSize", PageSize);
            //cm.Parameters.AddWithValue("@beforeCount", PageSize * (CurrentPage - 1));
            SqlDataReader dr = cm.ExecuteReader();
            List<FindJob.Model.T_Base_Enterprise> lst = new List<Model.T_Base_Enterprise>();
            while (dr.Read())
            {
                FindJob.Model.T_Base_Enterprise EP = new Model.T_Base_Enterprise();
                //FindJob.Model.T_Base_EnterpriseHead head = new Model.T_Base_EnterpriseHead();
                EP.Id = Convert.ToInt32(dr["Id"]);
                
                EP.Name = Convert.ToString(dr["Name"]);
                EP.Tel = Convert.ToString(dr["Tel"]);
                EP.Address = Convert.ToString(dr["Address"]);
                EP.Introduction = Convert.ToString(dr["Introduction"]);
                EP.Qualification = Convert.ToString(dr["Qualification"]);
                EP.IsChecked = Convert.ToBoolean(dr["IsChecked"]);
                EP.UserId = Convert.ToInt32(dr["UserId"]);
               
                lst.Add(EP);
            }
            dr.Close();
            co.Close();
            return lst;
        }
        public int EPCount()
        {
            SqlConnection co = new SqlConnection();
            co.ConnectionString = constr;
            co.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = co;
            cm.CommandText = "select count(*) from T_Base_Enterprise";
            object obj = cm.ExecuteScalar();
            co.Close();
            return (int)obj;
        }
        public int EPDelete(string ids)
        {
            SqlConnection co = new SqlConnection();
            co.ConnectionString = constr;
            co.Open();
            SqlCommand cm = new SqlCommand();
            //cm.CommandText = "delete from t_stock_inItems where headid in (" + ids + ");delete from t_stock_inhead where id in (" + ids + ") ; ";
            cm.CommandText = "delete from T_Base_Enterprise where id in (" + ids + ") ; ";
            cm.Connection = co;
            int result = cm.ExecuteNonQuery();
            co.Close();
            return result;
        }
    }
}
