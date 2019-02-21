using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary; Mo's work

namespace PBFrontEnd
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClassLibrary.clsDataConnection myDB = new ClassLibrary.clsDataConnection();
            clsDataConnection MyDB2 = new clsDataConnection();
        }


        protected void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void btnPopulate_Click(object sender, EventArgs e)
        {
            lblError.Text = DisplayUsers() + " found";
        }


        Int32 DisplayUsers()
        { 
                clsUserCollection MyUsers = new clsUserCollection();
        MyUsers.FindAllUsers();
            lstUsers.DataSource = MyUsers.Users;
            lstUsers.DataTextField = "FirstName";
            lstUsers.DataValueField = "UserNo";
            lstUsers.DataBind();

            return MyUsers.Count;


            }











    }
}