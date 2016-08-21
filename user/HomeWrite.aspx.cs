using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Default : System.Web.UI.Page
{
    protected void btn1_Click1(object sender, EventArgs e)
    {
        nsabt.clsblg obj = new nsabt.clsblg();
        nsabt.clsblgprp objprp = new nsabt.clsblgprp();

        Int32 a;
        objprp.blgprfcod = Convert.ToInt32(Session["cod"]);
        objprp.blghed = txthead.Text;
        objprp.blgdsc = txtdsc.Text;
        objprp.blgdat = DateTime.Now;
        String pic = FileUpload1.PostedFile.FileName;
        if (pic != "")
            pic = pic.Substring(pic.LastIndexOf('.'));
        objprp.blgimg = pic;
        a = obj.save_rec(objprp);
        
        if (pic != "")
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../PostImg")
                + "//" + a.ToString() + pic);

        Response.Redirect("frmhome.aspx");
    }

    protected void btn2_Click1(object sender, EventArgs e)
    {
        txthead.Text = String.Empty;
        txtdsc.Text = String.Empty;

        txthead.Focus();
    }
}
