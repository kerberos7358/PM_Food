using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsFoodCollection
    {

        //private data member that stores the count of records found
        private Int32 mRecordCount;
        //create a private list data member to store the data from the database
        private List<clsUser> mUserList = new List<clsUser>();

        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();



        //public property returning the count of records
        public Int32 Count
        {
            get
            {
                //return record count;
                return mRecordCount;
            }
        }

        //public list of users
        public List<clsUser> Users
        {
            //getter for the property
            get
            {
                //return the list of users
                return mUserList;
            }
        }

        public void FindAllUsers()
        {
            //re-set the connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the user number of the current record

            Int32 FoodID;
            //var to flag that user was found
            Boolean Price;
            //execute the stored procedure
            myDB.Execute("sproc_tblUser_SelectAll");
            //get the count of records
            mRecordCount = myDB.Count;
            //while there are still records to process
            while (Index < myDB.Count)
            {
                //create an instance of the user class
                clsUser NewUser = new clsUser();
                //get the user number from the database
                FoodID = Convert.ToInt32(myDB.DataTable.Rows[Index]["UserNo"]);
                //find the user by invoking the find method
                Price = NewUser.Find(FoodID);
                if (Price == true)
                {
                    //add the user to the list
                    mUserList.Add(NewUser);
                }
                //increment the index
                Index++;
            }
        }





    }
}