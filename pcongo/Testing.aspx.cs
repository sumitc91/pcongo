using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pcongo
{
    public partial class Testing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Membership.CreateUser(TextBox1.Text, TextBox2.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String username = TextBox3.Text;
            String password = TextBox4.Text;
            if (Membership.ValidateUser(username, password))
            {
                // User has supplied valid credentials

                // In the following method call, the second Boolean parameter 
                // determines whether a persistent authentication cookie
                // is created.
                Session["username"] = username;
                FormsAuthentication.RedirectFromLoginPage(username, true);

            }
            else
            {
                Label1.Text = "invalid username password";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
        }
    }
}