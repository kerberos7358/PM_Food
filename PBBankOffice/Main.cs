using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBBankOffice
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void listFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DisplayFoodList() + " found";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Int32 DisplayFoodList()
        {
            clsUserCollection MyFood = new clsUserCollection();
            MyUsers.FindAllUsers();
            listFood.DataSource = MyUsers.Users;
            listFood.DataTextField = "FirstName";
            listFood.DataValueField = "UserNo";
            listFood.DataBind();

            return MyFood.Count;


        }
    }
}
