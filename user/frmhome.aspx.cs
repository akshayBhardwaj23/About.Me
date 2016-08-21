using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class user_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Int32 a = 0;
            LinkButton lk = (LinkButton)(Master.FindControl("lk"));
            if (Request.QueryString["pcod"] == null)
            {
                a = Convert.ToInt32(Session["cod"]);
                List_Bind(a);
                lk1.Visible = true;
                lkUpdate.Visible = true;
                lk.Visible = true;
            }
            else
            {
                a = Convert.ToInt32(Request.QueryString["pcod"]);
                List_Bind(a);
                lk1.Visible = false;
                lkUpdate.Visible = false;
                lk.Visible = false;
            }

            nsabt.clsblg obj = new nsabt.clsblg();
            List<nsabt.clsblgprp> k = obj.recblg(a);

            nsabt.clsprf obj1 = new nsabt.clsprf();
            List<nsabt.clsprfprp> k1 = obj1.find_rec(a);

            if (k.Count != 0)
            {
                lbl1.Text = k[0].blghed;
                lbl2.Text = k1[0].prffrstnam + " " + k1[0].prflstnam;
                lbl3.Text = k[0].blgdat.ToShortDateString();
                img1.ImageUrl = "~/PostImg/" + k[0].blgcod + k[0].blgimg;
                lbl4.Text = k[0].blgdsc;
                Session["bcod"] = k[0].blgcod;
            }
            else
            {
                lbl1.Text = "No recent activity by user";
            }
        }
    }

    protected void lk1_Click(object sender, EventArgs e)
    {
        Server.Transfer("homewrite.aspx");
    }

    protected void lkUpdate_Click(object sender, EventArgs e)
    {
        Server.Transfer("homeedit.aspx");
    }
    private void List_Bind(int a)
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from tbblg where blgprfcod = " + a + " order by blgcod DESC", ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Int32 a = 0;
        LinkButton lk = (LinkButton)(Master.FindControl("lk"));
        if (Request.QueryString["pcod"] == null)
        {
            a = Convert.ToInt32(Session["cod"]);
            List_Bind(a);
            lk1.Visible = true;
            lkUpdate.Visible = true;
            lk.Visible = true;
        }
        else
        {
            a = Convert.ToInt32(Request.QueryString["pcod"]);
            List_Bind(a);
            lk1.Visible = false;
            lkUpdate.Visible = false;
            lk.Visible = false;
        }
        int d = Convert.ToInt32(DataList1.DataKeys[DataList1.SelectedIndex]);

        nsabt.clsblg obj = new nsabt.clsblg();
        List<nsabt.clsblgprp> k = obj.find_rec(d);

        nsabt.clsprf obj1 = new nsabt.clsprf();
        List<nsabt.clsprfprp> k1 = obj1.find_rec(a);
        if (k.Count != 0)
        {
            lbl1.Text = k[0].blghed;
            lbl2.Text = k1[0].prffrstnam + " " + k1[0].prflstnam;
            lbl3.Text = k[0].blgdat.ToShortDateString();
            img1.ImageUrl = "~/PostImg/" + k[0].blgcod + k[0].blgimg;
            lbl4.Text = k[0].blgdsc;
            Session["bcod"] = k[0].blgcod;
        }
    }
}