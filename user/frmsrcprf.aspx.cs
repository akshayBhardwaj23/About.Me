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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsabt.clsprf obj = new nsabt.clsprf();
        GridView1.DataSource = obj.srcprf(TextBox1.Text + "%",
                        Convert.ToInt32(Session["cod"]));
        GridView1.DataBind();
    }
}