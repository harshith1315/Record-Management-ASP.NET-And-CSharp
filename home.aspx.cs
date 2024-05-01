using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Button1.Click += new EventHandler(this.Addbutton);
        }
        protected void Test(object sender, EventArgs e)
        {
            //Button c=(Button)sender;
            Response.Redirect($"addrecord.aspx");
        }
        protected void Test1(object sender, EventArgs e)
        {
            //Button c=(Button)sender;
            Response.Redirect($"drecord.aspx");
        }
        protected void Test2(object sender, EventArgs e)
        {
            //Button c=(Button)sender;
            Response.Redirect($"updaterecord.aspx");
        }
        protected void Test3(object sender, EventArgs e)
        {
            //Button c=(Button)sender;
            Response.Redirect($"displayrecord.aspx");
        }
    }
}