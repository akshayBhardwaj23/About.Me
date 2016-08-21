using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["cod"] == null)
            Response.Redirect("../index.aspx");
    }

    protected void lk1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("../index.aspx");
    }

    protected void lk_Click(object sender, EventArgs e)
    {
        Int32 a = 0;
        if (Request.QueryString["pcod"] == null)
        {
            Server.Transfer("frmhome.aspx");
        }
        else
        {
            a = Convert.ToInt32(Request.QueryString["pcod"]);
            Server.Transfer("frmhome.aspx?pcod=" + a);
        }
    }
}
