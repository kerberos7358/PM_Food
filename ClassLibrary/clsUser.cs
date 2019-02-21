using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsUser
    {
        //private data members for the class
        private Int32 _FoodID;
        private string _FoodName;
        private string _FoodDescription;
        private string _FoodRecepy;
        clsDataConnection myDB = new clsDataConnection();


        //public properties
        public Int32 FoodID
        {
            get
            {
                return _FoodID;
            }
            set
            {
                _FoodID = value;
            }
        }

        public string FoodName
        {
            get
            {
                return _FoodName;
            }

            set
            {
                _FoodName = value;
            }
        }

        public string FoodDescription
        {
            get
            {
                return _FoodDescription;
            }
            set
            {
                _FoodDescription = value;
            }
        }

        public string FoodRecepy
        {
            get
            {
                return _FoodRecepy;
            }
            set
            {
                _FoodRecepy = value;
            }
        }

        ///public find method
        public Boolean Find(Int32 UserNo)
        {
            //re set the connection to the database
            myDB = new clsDataConnection();
            //pass the parameter to the stored procedure
            myDB.AddParameter("@UserNo", UserNo);
            //execute the stored procedure
            myDB.Execute("sproc_tblUser_FilterByUserNo");
            //check to see if we found anything
            if (myDB.Count == 1)
            {
                //set the private data members with the data from the database
                //private Int32 userNo;
                _FoodID = Convert.ToInt32(myDB.DataTable.Rows[0]["FoodID"]);
                //private string userName;
                _FoodName = Convert.ToString(myDB.DataTable.Rows[0]["FoodName"]);
                //private string firstName;
                _FoodDescription = Convert.ToString(myDB.DataTable.Rows[0]["FoodDescription"]);
                //private string surname;
                _FoodRecepy = Convert.ToString(myDB.DataTable.Rows[0]["FoodRecepy"]);


                //return success
                return true;
            }
            else //user no was invalid
            {
                //return that there was a problem
                return false;
            }
        }


    }
}
