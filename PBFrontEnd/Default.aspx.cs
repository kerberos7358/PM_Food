using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace PBFrontEnd
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ClassLibrary.clsDataConnection MyDB = new ClassLibrary.clsDataConnection();
            clsDataConnection MyDB2 = new clsDataConnection();
        }

        protected void btnPopulate_Click()
        {
            
        }

        Int32 DisplaySupplier()
        {
            //create and instance of the user collection
            clsSupplierCollection MySupplier = new clsSupplierCollection();
            //find all supplier
            MySupplier.FindAllSupplier();
            //set the data source of the list box
            lstSupplier.DataSource = MySupplier.Suppliers;
            //set the text to be displayed
            lstSupplier.DataTextField = "SupplierName";
            //set the primary key 
            lstSupplier.DataValueField = "SupplierNo";
            //bind the data 
            lstSupplier.DataBind();
            //return the count of record in the list
            return MySupplier.Count;

        }

        protected void lstSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnPopulate_Click1(object sender, EventArgs e)
        {
            lblError.Text = DisplaySupplier() + "found";
        }
    }
}