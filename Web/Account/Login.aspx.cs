

using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using Web;
using editar;

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
        //if (IsValid)
        //{
        //    // Validate the user password
        //    var manager = new UserManager();
        //    ApplicationUser user = manager.Find(UserName.Text, Password.Text);


        //    if (user != null)
        //    {
        //        IdentityHelper.SignIn(manager, user, RememberMe.Checked);
        //        IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
        //    }
        //    else
        //    {
        //        FailureText.Text = "Invalid username or password.";
        //        ErrorMessage.Visible = true;
        //    }
        //}
            #region login

            try {
                string usuario = UserName.Text;
                string contraseña = Password.Text;
                login.IloginClient login = new login.IloginClient();
                var resp=login.validateLogin(usuario,contraseña);
                if (resp) {
                string sMsg = "Exito";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + sMsg + "')", true);
                }
             }
            catch(Exception) { 
        
            }   
          
            #endregion



        }
}