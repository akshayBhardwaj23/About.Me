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

    protected void b1_Click(object sender, ImageClickEventArgs e)
    {
        nsabt.clsreg obj = new nsabt.clsreg();
        nsabt.clsregprp objprp = new nsabt.clsregprp();
        objprp.regeml = txteml.Text;
        objprp.regpwd = txtpwd.Text;
        objprp.regdat = DateTime.Now;
        try
        {
            obj.save_rec(objprp);
            txteml.Text = String.Empty;
            Label1.Text = "Registration Successful.";
        }
        catch(Exception)
        {
            Label1.Text = "Email ID already registered.";
        }
    }
}