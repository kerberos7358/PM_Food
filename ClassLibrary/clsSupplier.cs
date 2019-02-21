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
        private int mPhone;
        private int mPostCode;
        private string mSupplierName;
        private int mSupplierNo;
        clsDataConnection myDB = new clsDataConnection();

        //public properties
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
        public int Phone
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
        public int PostCode
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
            {
                return mSupplierNo;    
            }
            set
            {
                mSupplierNo = value;
            }
        }

        //public find method
        public Boolean Find (int SupplierNo)
        {
            //re set the connection to the database 
            myDB = new clsDataConnection();
            //pass the parameter to the stored procedure
            myDB.AddParameter("@SupplierNo", SupplierNo);
            //execute the stored procedure
            myDB.Execute("sproc tblSupplier FilterBySupplierNo");
            //check to see if we found anything
            if (myDB.Count == 1)
            {
                mSupplierNo = Convert.ToInt32(myDB.DataTable.Rows[0]["SupplierNo"]);
                mSupplierName = Convert.ToString(myDB.DataTable.Rows[0]["SupplierName"]);
                mAddress = Convert.ToString(myDB.DataTable.Rows[0]["Address"]);
                mPhone = Convert.ToInt32(myDB.DataTable.Rows[0]["Phone"]);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
