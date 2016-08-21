using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            Int32 a = 0;
            LinkButton lk = (LinkButton)(Master.FindControl("lk"));
            if (Request.QueryString["pcod"] == null)
            {
                a = Convert.ToInt32(Session["cod"]);
                LinkButton1.Visible = false;
                lk.Visible = true;
                LinkButton5.Visible = false;
            }
            else
            {
                a = Convert.ToInt32(Request.QueryString["pcod"]);
                LinkButton1.Visible = true;
                lk.Visible = false;
                LinkButton5.Visible = true;
            }
            nsabt.clsprf obj = new nsabt.clsprf();
            List<nsabt.clsprfprp> k = obj.find_rec(a);
            if (k.Count != 0)
            {
                lbl1.Text = k[0].prffrstnam + " " + k[0].prflstnam;
                lt1.Text = k[0].prfbio;
                img1.ImageUrl = "~/prfpics/" + k[0].prfcod + k[0].prfbckpic;
                img2.ImageUrl = "~/prfpics/" + k[0].prfcod + k[0].prfpic;
                if (k[0].prfprvsts == 'P')
                {
                    nsabt.clsreg obj1 = new nsabt.clsreg();
                    List<nsabt.clsregprp> k1 = obj1.find_rec(a);
                    lbl2.Text = k1[0].regeml;
                }
                nsabt.clsprflnk obj2 = new nsabt.clsprflnk();
                GridView1.DataSource = obj2.disp_rec(k[0].prfcod);
                GridView1.DataBind();
            }
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        nsabt.clsfav obj = new nsabt.clsfav();
        nsabt.clsfavprp objprp = new nsabt.clsfavprp();
        objprp.favprfcod = Convert.ToInt32(Session["cod"]);
        objprp.favfavprfcod = Convert.ToInt32(Request.QueryString["pcod"]);
        obj.save_rec(objprp);
        Response.Redirect("frmfav.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
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