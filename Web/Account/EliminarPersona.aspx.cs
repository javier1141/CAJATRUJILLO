using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_EliminarPersona : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void EliminarUser_Click(object sender, EventArgs e)
    {
        //var manager = new UserManager();
        //var user = new ApplicationUser() { UserName = UserName.Text };
        //IdentityResult result = manager.Create(user, Password.Text);
        //if (result.Succeeded)
        //{
        //    IdentityHelper.SignIn(manager, user, isPersistent: false);
        //    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
        //}
        //else
        //{
        //    ErrorMessage.Text = result.Errors.FirstOrDefault();
        //}

        var usuario = UserName.Text;
        eliminarPersona.IeliminarPersonaClient eliminarInstancia = new eliminarPersona.IeliminarPersonaClient();
        var exito = eliminarInstancia.f_eliminarPersona(usuario);
        if (exito)
        {
            string sMsg = "Exito";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + sMsg + "')", true);
        }
        else
        {

        }

    }
}