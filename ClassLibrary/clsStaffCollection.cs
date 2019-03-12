using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();

        //constructor for the class
        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;           
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                AStaff.Sex = Convert.ToString(DB.DataTable.Rows[Index]["Sex"]);
                AStaff.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AStaff.Address1 = Convert.ToString(DB.DataTable.Rows[Index]["Address1"]);
                AStaff.Address2 = Convert.ToString(DB.DataTable.Rows[Index]["Address2"]);
                AStaff.Address3 = Convert.ToString(DB.DataTable.Rows[Index]["Address3"]);
                AStaff.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the nect record
                Index++;
            }
        }
               
        //public property for the address list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                
            }
        }

        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("FirstName", mThisStaff.FirstName);
            DB.AddParameter("Surname", mThisStaff.Surname);
            DB.AddParameter("Sex", mThisStaff.Sex);
            DB.AddParameter("DOB", mThisStaff.DOB);
            DB.AddParameter("Address1", mThisStaff.Address1);
            DB.AddParameter("Address2", mThisStaff.Address2);
            DB.AddParameter("Address3", mThisStaff.Address3);
            DB.AddParameter("PostCode", mThisStaff.PostCode);
            DB.AddParameter("Email", mThisStaff.Email);
            DB.AddParameter("Phone", mThisStaff.Phone);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //coonect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");

        }

        public void ReportByPostCode(string PostCode)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@PostCode", PostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByPostCode");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void Update()
        {
            //update an existing record based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("FirstName", mThisStaff.FirstName);
            DB.AddParameter("Surname", mThisStaff.Surname);
            DB.AddParameter("Sex", mThisStaff.Sex);
            DB.AddParameter("DOB", mThisStaff.DOB);
            DB.AddParameter("Address1", mThisStaff.Address1);
            DB.AddParameter("Address2", mThisStaff.Address2);
            DB.AddParameter("Address3", mThisStaff.Address3);
            DB.AddParameter("PostCode", mThisStaff.PostCode);
            DB.AddParameter("Email", mThisStaff.Email);
            DB.AddParameter("Phone", mThisStaff.Phone);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}