using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the StaffNo property
        private Int32 mStaffNo;
        //private data member for the FirstName
        private string mFirstName;
        //private data member for the Surname
        private string mSurname;
        //private data member for the Sex
        private string mSex;
        //private data member for the DOB
        private DateTime mDOB;
        //private data member for the Address1
        private string mAddress1;
        //private data member for the Address2
        private string mAddress2;
        //private data member for the Address3
        private string mAddress3;
        //private data member for the PostCode
        private string mPostCode;
        //private data member for the Email
        private string mEmail;
        //private data member for the Phone
        private string mPhone;

        //public property for the staff number
        public int StaffNo
        {
            get
            {
                //return the private data
                return mStaffNo;
            }
            set
            {
                //set the value of the private data member
                mStaffNo = value;
            }
        }

        //public data member for FirstName
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the private data 
                mFirstName = value;
            }
        }

        //public data member for Surname
        public string Surname
        {
            get
            {
                //return the private data
                return mSurname;
            }
            set
            {
                //set the private data 
                mSurname = value;
            }
        }

        //public data member for Sex
        public string Sex
        {
            get
            {
                //return the private data
                return mSex;
            }
            set
            {
                //set the private data 
                mSex = value;
            }
        }

        //public property for DOB
        public DateTime DOB
        {
            get
            {
                //return the private data
                return mDOB;
            }
            set
            {
                //set the private data 
                mDOB = value;
            }
        }

        //public data member for Address1
        public string Address1
        {
            get
            {
                //return the private data
                return mAddress1;
            }
            set
            {
                //set the private data 
                mAddress1 = value;
            }
        }

        //public data member for Address2
        public string Address2
        {
            get
            {
                //return the private data
                return mAddress2;
            }
            set
            {
                //set the private data 
                mAddress2 = value;
            }
        }

        //public data member for Address3
        public string Address3
        {
            get
            {
                //return the private data
                return mAddress3;
            }
            set
            {
                //set the private data 
                mAddress3 = value;
            }
        }

        //public property for PostCode
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the private data 
                mPostCode = value;
            }
        }

        //public data member for Email
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the private data 
                mEmail = value;
            }
        }

        //public data member for Phone
        public string Phone
        {
            get
            {
                //return the private data
                return mPhone;
            }
            set
            {
                //set the private data 
                mPhone = value;
            }
        }

        public bool Find(int StaffNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff no to search for
            DB.AddParameter("@StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mSex = Convert.ToString(DB.DataTable.Rows[0]["Sex"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mAddress1 = Convert.ToString(DB.DataTable.Rows[0]["Address1"]);
                mAddress2 = Convert.ToString(DB.DataTable.Rows[0]["Address2"]);
                mAddress3 = Convert.ToString(DB.DataTable.Rows[0]["Address3"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                //return that everthing worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string firstname, string surname, string sex, string dob, string address1, string address2, string address3, string postcode, string email, string phone)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the FirstName is blank
            if (firstname.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank : ";
            }
            //if the first name is greater than 30 characters
            if (firstname.Length > 30)
            {
                //record the error
                Error = Error + "The first name no must be less than 30 characters : ";
            }


            try
            {
                //copy the dob value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dob);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be on the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the surname blank
            if (surname.Length == 0)
            {
                //record the error
                Error = Error + "The surname my not be blank : ";
            }
            //if the surname is too long
            if (surname.Length > 30)
            {
                //record the error
                Error = Error + "The surname must be less than 30 characters : ";
            }
            //is the sex blank
            if (sex.Length == 0)
            {
                //record the error
                Error = Error + "The sex my not be blank : ";
            }
            //if the sex is too long
            if (sex.Length > 6)
            {
                //record the error
                Error = Error + "The sex must be less than 6 characters : ";
            }
            //is the address1 blank
            if (address1.Length == 0)
            {
                //record the error
                Error = Error + "The address1 my not be blank : ";
            }
            //if the address1 is too long
            if (address1.Length > 30)
            {
                //record the error
                Error = Error + "The address1 must be less than 30 characters : ";
            }
            //is the address2 blank
            if (address2.Length == 0)
            {
                //record the error
                Error = Error + "The address2 my not be blank : ";
            }
            //if the address2 is too long
            if (address2.Length > 30)
            {
                //record the error
                Error = Error + "The address2 must be less than 30 characters : ";
            }
            //is the address3 blank
            if (address3.Length == 0)
            {
                //record the error
                Error = Error + "The address3 my not be blank : ";
            }
            //if the address3 is too long
            if (address3.Length > 30)
            {
                //record the error
                Error = Error + "The address3 must be less than 30 characters : ";
            }
            //is the postcode blank
            if (postcode.Length == 0)
            {
                //record the error
                Error = Error + "The postcode my not be blank : ";
            }
            //if the postcode is too long
            if (postcode.Length > 9)
            {
                //record the error
                Error = Error + "The postcode must be less than 9 characters : ";
            }
            //is the email blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email my not be blank : ";
            }
            //if the email is too long
            if (email.Length > 30)
            {
                //record the error
                Error = Error + "The email must be less than 30 characters : ";
            }
            //is the phone blank
            if (phone.Length == 0)
            {
                //record the error
                Error = Error + "The phone my not be blank : ";
            }
            //if the phone is too long
            if (phone.Length > 11)
            {
                //record the error
                Error = Error + "The phone must be less than 11 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}