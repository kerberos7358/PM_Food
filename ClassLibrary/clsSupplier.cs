using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsSupplier
    {



        //Private data members foe the class
        private string mAddress;
        private string mPhone;
        private string mPostCode;
        private string mSupplierName;
        private int mSupplierNo;
        private Boolean mActive;
        clsDataConnection myDB = new clsDataConnection();

        //public properties
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public string Phone
        {
            get
            {
                return mPhone;
            }
            set
            {
                mPhone = value;
            }
        }
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        public string SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }
        public int SupplierNo
        {
            get
            {   //return the private data
                return mSupplierNo;
            }
            set
            {
                //set the value of the private data member
                mSupplierNo = value;
            }
        }


        public string Valid(int supplierNo, string supplierName, string address, string postcode, string phone)
        {//create a string variable to store the error
            String Error = "";
            //if the SupplierName is blank
            if (supplierName.Length == 0)
            {//record the error
                Error = Error + "The supplier name no may not be black : ";
            }
            //if the SupplierName is greater than 50 characters
            if (supplierName.Length > 50)
            {
                //record the error
                Error = Error + "The supplier name no must be less than 6 characters : ";
            }
            if (address.Length == 0)
            {//record the error
                Error = Error + "The address no may not be black : ";
            }
            //if the SupplierName is greater than 50 characters
            if (address.Length > 50)
            {
                //record the error
                Error = Error + "The address no must be less than 6 characters : ";
            }
            if (postcode.Length == 0)
            {//record the error
                Error = Error + "The postcode no may not be black : ";
            }
            //if the SupplierName is greater than 50 characters
            if (postcode.Length > 8)
            {
                //record the error
                Error = Error + "The postcode no must be less than 6 characters : ";
            }
            if (phone.Length == 0)
            {//record the error
                Error = Error + "The phone no may not be black : ";
            }
            //if the SupplierName is greater than 50 characters
            if (phone.Length > 8)
            {
                //record the error
                Error = Error + "The phone no must be less than 6 characters : ";
            }
            //return any error messages
            return Error;


        }



        //public bool Find(int SupplierNo)
        //{
        //    mSupplierNo = 5;
        //    mSupplierName = "eee";
        //    mAddress = "eee";
        //    mPostCode = "eee";
        //    mPhone = "555";
        //    return true;
        //}

        public bool Find(int supplierNo)
        {
            //create an instance of the data connection
            /*clsDataConnection */
            myDB = new clsDataConnection();
            //add the paramether for the address no to search for
            myDB.AddParameter("@SupplierNo", supplierNo);
            //execute the stored procedure
            myDB.Execute("sproc_tblSupplier_FilerBySupplierNo");
            //if one record id found (there should be either one or zero)
            if (myDB.Count == 1)
            {
                //copy the data from the databawse to the private data members
                mSupplierNo = Convert.ToInt32(myDB.DataTable.Rows[0][SupplierNo]);
                mSupplierName = Convert.ToString(myDB.DataTable.Rows[0][SupplierName]);
                mAddress = Convert.ToString(myDB.DataTable.Rows[0][Address]);
                mPostCode = Convert.ToString(myDB.DataTable.Rows[0][PostCode]);
                mPhone = Convert.ToString(myDB.DataTable.Rows[0][Phone]);
                //return that evething worked OK
                return true;
            }
            //if no record was found 
            else
            {
                //return flase indicating a problem
                return false;
            }

        }



    }
}
