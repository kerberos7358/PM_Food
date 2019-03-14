using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RestaurantTesting
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass to the method
        string FirstName = "Test FirstName";
        string Surname = "Test FirstName";
        string Sex = "Test FirstName";
        string DOB = DateTime.Now.Date.ToString();
        string Address1 = "Test Address1";
        string Address2 = "Test Address2";
        string Address3 = "Test Address3";
        string PostCode = "Test PostCode";
        string Email = "Test Emial";
        string Phone = "Test Phone";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffNo, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some FirstName";
            //assign the data to the property
            AStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FirstName, TestData);
        }

        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Surname";
            //assign the data to the property
            AStaff.Surname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Surname, TestData);
        }

        [TestMethod]
        public void SexPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Sex";
            //assign the data to the property
            AStaff.Sex = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Sex, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DOB, TestData);
        }

        [TestMethod]
        public void Address1PropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Address1";
            //assign the data to the property
            AStaff.Address1 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Address1, TestData);
        }

        [TestMethod]
        public void Address2PropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Address2";
            //assign the data to the property
            AStaff.Address2 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Address2, TestData);
        }

        [TestMethod]
        public void Address3PropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Address3";
            //assign the data to the property
            AStaff.Address3 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Address3, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some PostCode";
            //assign the data to the property
            AStaff.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.PostCode, TestData);
        }

        [TestMethod]
        public void EmialPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Email";
            //assign the data to the property
            AStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void PhonePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Phone";
            //assign the data to the property
            AStaff.Phone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Phone, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //creat some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the staff no
            if (AStaff.StaffNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.FirstName != "Test FirstName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.Surname != "Test Surname")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSexFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.Sex != "Test Sex")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.DOB !=Convert.ToDateTime("16/9/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddress1Found()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.Address1 != "Test Address1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddress2Found()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.Address2 != "Test Address2")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddress3Found()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.Address3 != "Test Address3")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.PostCode != "Test PostCode")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.Email != "Test Email")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //creat some test data to use with the method
            Int32 StaffNo = 21;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.Phone != "Test Phone")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(FirstName,Surname,Sex,DOB,Address1,Address2,Address3,PostCode,Email,Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "aaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "";
            Surname = Surname.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Surname = "aaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SexMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Sex = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SexMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Sex = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SexMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Sex = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SexMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Sex = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SexMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Sex = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SexMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Sex = "aaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SexExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Sex = "";
            Sex = Sex.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SexMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Sex = "aaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable  to store the test date data
            DateTime TestDate;
            //set the data totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable  to store the test date data
            DateTime TestDate;
            //set the data totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable  to store the test date data
            DateTime TestDate;
            //set the data totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable  to store the test date data
            DateTime TestDate;
            //set the data totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable  to store the test date data
            DateTime TestDate;
            //set the data totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the DOB to a non date value
            string DOB = "this is not a date!";
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address1MinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address1 = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address1Min()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address1 = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address1MinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address1 = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address1MaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address1 = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address1Max()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address1 = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address1MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address1 = "aaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address1ExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Sex = "";
            Address1 = Address1.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address1Mid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address1 = "aaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address2MinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address2 = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address2Min()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address2 = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address2MinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address2 = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address2MaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address2 = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address2Max()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address2 = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address2MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address2 = "aaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address2ExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address2 = "";
            Address2 = Address2.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address2Mid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address2 = "aaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address3MinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address3 = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address3Min()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address3 = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address3MinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address3 = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address3MaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address3 = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address3Max()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address3 = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address3MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address3 = "aaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address3ExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address3 = "";
            Address3 = Address3.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address3Mid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address3 = "aaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = "a"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = "aa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = "aaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = "aaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = "aaaaaaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = "";
            Phone = Phone.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = "aaa"; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, Surname, Sex, DOB, Address1, Address2, Address3, PostCode, Email, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
