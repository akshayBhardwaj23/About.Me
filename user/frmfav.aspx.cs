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
        if(Page.IsPostBack ==false )
        {
            nsabt.clsfav obj = new nsabt.clsfav();
            GridView1.DataSource = obj.favprf
                (Convert.ToInt32(Session["cod"]));
            GridView1.DataBind();
        }
    }

}