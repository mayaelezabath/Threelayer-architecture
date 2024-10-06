using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace threelay
{
    public partial class WebFormlog : System.Web.UI.Page
    {
        logincls objbll = new logincls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cid = objbll.GetCountId(TextBox1.Text, TextBox2.Text);
            if (cid == "1")
            {
                string id = objbll.GetId(TextBox1.Text, TextBox2.Text);
                Session["uid"] = id;
                Response.Redirect("webformuser.aspx");
            }
            else
            {
                Label1.Text = "invalid";            }

        }
    }
}