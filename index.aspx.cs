using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        nsabt.clsreg obj = new nsabt.clsreg();
        nsabt.clsregprp objprp = new nsabt.clsregprp();
        objprp.regeml = txteml.Text;
        objprp.regpwd = txtpwd.Text;
        Int32 a = obj.logincheck(objprp);
        if (a == -1)
            Label1.Text = "Email Password Incorrect";
        else
        {
            Session["cod"] = a;
            Response.Redirect("user/frmprf.aspx");
        }
    }
}