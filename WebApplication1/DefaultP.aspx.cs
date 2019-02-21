using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DefaultP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClassLibrary.clsDataConnection myDB = new ClassLibrary.clsDataConnection();
            clsDataConnection MyDB2 = new clsDataConnection();
        }
    }
}