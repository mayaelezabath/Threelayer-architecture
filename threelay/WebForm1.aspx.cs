using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace threelay
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        insertcls objbll = new insertcls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(s));

            int I = objbll.DBInsert(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text, s, TextBox4.Text, TextBox5.Text);
            if(I!=0)
            {
                Label1.Text = "inserted";
            }
        }
    }
}