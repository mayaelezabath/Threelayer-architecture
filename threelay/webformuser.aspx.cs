using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace threelay
{
    public partial class webformuser : System.Web.UI.Page
    {
        usercls objbll = new usercls();
        protected void Page_Load(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(Session["uid"]);
            SqlDataReader dr = objbll.fun_GetData(uid);
            while(dr.Read())
            {
                Label1.Text = dr["name"].ToString();
                Label2.Text = dr["age"].ToString();
                Label3.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }

        }
    }
}