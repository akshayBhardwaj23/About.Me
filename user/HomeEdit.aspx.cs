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
            nsabt.clsblg obj = new nsabt.clsblg();
            List<nsabt.clsblgprp> k = obj.find_rec(Convert.ToInt32(Session["bcod"]));

            if (k.Count > 0)
            {
                txthead.Text = k[0].blghed;
                txtdsc.Text = k[0].blgdsc;
                ViewState["pic"] = k[0].blgimg;
                ViewState["cod"] = k[0].blgcod;
                ViewState["pcod"] = k[0].blgprfcod;
                ViewState["dat"] = k[0].blgdat;
            }
        }

    }

    protected void btn1_Click1(object sender, EventArgs e)
    {
        nsabt.clsblg obj = new nsabt.clsblg();
        nsabt.clsblgprp objprp = new nsabt.clsblgprp();

        objprp.blghed = txthead.Text;
        objprp.blgdsc = txtdsc.Text;
        objprp.blgcod = Convert.ToInt32(ViewState["cod"]);
        objprp.blgprfcod = Convert.ToInt32(ViewState["pcod"]);
        objprp.blgdat = Convert.ToDateTime(ViewState["dat"]);

        String pic = FileUpload1.PostedFile.FileName;
        if (pic != "")
            pic = pic.Substring(pic.LastIndexOf('.'));
        objprp.blgimg = pic;
        Int32 a = Convert.ToInt32(ViewState["cod"]);
        if (pic == "")
            objprp.blgimg = ViewState["pic"].ToString();

        obj.update_rec(objprp);
        if (pic != "")
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../PostImg")
                + "//" + a.ToString() + pic);
        Response.Redirect("frmhome.aspx");
    }

    protected void btn2_Click1(object sender, EventArgs e)
    {
        Server.Transfer("frmhome.aspx");
    }
}

