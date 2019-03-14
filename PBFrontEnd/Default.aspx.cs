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
    }
}