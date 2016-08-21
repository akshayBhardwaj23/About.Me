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
            nsabt.clsprf obj = new nsabt.clsprf();
            List<nsabt.clsprfprp> k = obj.find_rec
                            (Convert.ToInt32(Session["cod"]));
            if (k.Count > 0)
            {
                txtfstnam.Text = k[0].prffrstnam;
                txtlstnam.Text = k[0].prflstnam;
                Editor1.Content = k[0].prfbio;
                if (k[0].prfprvsts == 'P')
                    RadioButtonList1.SelectedIndex = 1;
                else
                    RadioButtonList1.SelectedIndex = 0;
                ViewState["pic"] = k[0].prfpic;
                ViewState["bckpic"] = k[0].prfbckpic;
                ViewState["cod"] = k[0].prfcod;
                nsabt.clsprflnk obj1 = new nsabt.clsprflnk();
                List<nsabt.clsprflnkprp> k1 = obj1.disp_rec(k[0].prfcod);
                txtfac.Text = k1[0].prflnkurl;
                txttwt.Text = k1[1].prflnkurl;
                txtlin.Text = k1[2].prflnkurl;
                Button1.Text = "Update";
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsabt.clsprf obj = new nsabt.clsprf();
        nsabt.clsprfprp objprp = new nsabt.clsprfprp();
        objprp.prffrstnam = txtfstnam.Text;
        objprp.prflstnam = txtlstnam.Text;
        objprp.prfbio = Editor1.Content;
        objprp.prfregcod = Convert.ToInt32(Session["cod"]);
        objprp.prfprvsts = Convert.ToChar(RadioButtonList1.SelectedValue);
        String pic = FileUpload1.PostedFile.FileName;
        if (pic != "")
            pic = pic.Substring(pic.LastIndexOf('.'));
        objprp.prfpic = pic;
        String bckpic = FileUpload2.PostedFile.FileName;
        if (bckpic != "")
            bckpic = "B" + bckpic.Substring(bckpic.LastIndexOf('.'));
        objprp.prfbckpic = bckpic;
        int a = 0;
        if (Button1.Text == "Submit")
        {
            a = obj.save_rec(objprp);
        }
        else
        {
            a = Convert.ToInt32(ViewState["cod"]);
            objprp.prfcod = a;
            if (pic == "")
                objprp.prfpic = ViewState["pic"].ToString();
            if (bckpic == "")
                objprp.prfbckpic = ViewState["bckpic"].ToString();
            obj.update_rec(objprp);
            nsabt.clsprflnk obj2 = new nsabt.clsprflnk();
            nsabt.clsprflnkprp objprp2 = new nsabt.clsprflnkprp();
            objprp2.prflnkcod = a;
            obj2.delete_rec(objprp2);
        }
        nsabt.clsprflnk obj1 = new nsabt.clsprflnk();
        nsabt.clsprflnkprp objprp1 = new nsabt.clsprflnkprp();
        objprp1.prflnkprfcod = a;
        objprp1.prflnksit = "Facebook";
        objprp1.prflnkurl = txtfac.Text;
        obj1.save_rec(objprp1);
        objprp1.prflnkprfcod = a;
        objprp1.prflnksit = "Twitter";
        objprp1.prflnkurl = txttwt.Text;
        obj1.save_rec(objprp1);
        objprp1.prflnkprfcod = a;
        objprp1.prflnksit = "LinkedIN";
        objprp1.prflnkurl = txtlin.Text;
        obj1.save_rec(objprp1);

        if (pic != "")
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../prfpics")
                + "//" + a.ToString() + pic);
        if (bckpic != "")
            FileUpload2.PostedFile.SaveAs(Server.MapPath("../prfpics")
                + "//" + a.ToString() + bckpic);
        Response.Redirect("frmprf.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        txtfac.Text = string.Empty;
        txtfstnam.Text = string.Empty;
        txtlin.Text = string.Empty;
        txtlstnam.Text = string.Empty;
        txttwt.Text = string.Empty;

        txtfstnam.Focus();

    }
}