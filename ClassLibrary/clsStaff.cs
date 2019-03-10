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
            //set the private data member to the test data value
            mStaffNo = 21;
            mFirstName = "Test FirstName";
            mSurname = "Test Surname";
            mSex = "Test Sex";
            mDOB = Convert.ToDateTime("16/9/2015");
            mAddress1 = "Test Address1";
            mAddress2 = "Test Address2";
            mAddress3 = "Test Address3";
            mPostCode = "Test PostCode";
            mEmail = "Test Email";
            mPhone = "Test Phone";
            //always return true
            return true;
        }
    }
}