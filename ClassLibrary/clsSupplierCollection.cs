using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
  public class clsSupplierCollection
    {
        //private data member that stores the count of records found
        private Int32 mRecordCount;
        //create a private list data member to stores the date from the database
        private List<clsSupplier> mSupplierList = new List<clsSupplier>();
        //private data member to connect to the database 
        private clsDataConnection myDB = new clsDataConnection();

        //public property returning the count of records
        public Int32 Count
        {
            get
            {
                return mRecordCount;
            }
        }


        //public list of the suppliers
        public List<clsSupplier> Suppliers
        {
            get
            {
                return mSupplierList;
            }
        }


        public void FindAllSupplier()
        {
            //re-set the connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 index = 0;
            //var to store the iser number of the current record
            Int32 SupplierNo;
            //var to flag tat user was found
            Boolean SupplierFound;
            //execute the stored procedure 
            myDB.Execute("sproc_tblSupplier_SelectAll");
            //get the count of records
            mRecordCount = myDB.Count;
            //whle there are still records to process
            while (index < myDB.Count)
            {
                //create an instance of the user class 
                clsSupplier NewSupplier = new clsSupplier();
                //get the user number from the databse
                SupplierNo = Convert.ToInt32(myDB.DataTable.Rows[index]["SupplierNo"]);
                //find the user by invoking the find method
                SupplierFound = NewSupplier.Find(SupplierNo);
                if (SupplierFound == true)
                {
                    //add the user to the list 
                    mSupplierList.Add(NewSupplier);

                }
                //increment the index
                index++;
            }
        }

    }
}
