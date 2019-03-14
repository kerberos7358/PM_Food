using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTest
{
    [TestClass]
    public class tstSupplier
    {
        //good test data 
        //create some test data to pass to the method
        int SupplierNo = 1;
        string SupplierName = "aaa";
        string Address = "aaa";
        string Postcode = "aaa";
        string Phone = "111";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(Supplier);
        }
        [TestMethod]
        public void SupplierNoPropertyOK()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Supplier.SupplierNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.SupplierNo, TestData);
        }
        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "071256789";
            //assign the data to the property
            Supplier.Phone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.Phone, TestData);
        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "135";
            //assign the data to the property
            Supplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.SupplierName, TestData);
        }

        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "135";
            //assign the data to the property
            Supplier.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.Address, TestData);
        }
        [TestMethod]
        public void PostCodeNoPropertyOK()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "13sdf5";
            //assign the data to the property
            Supplier.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Supplier.PostCode, TestData);
        }
        [TestMethod]
        public void FindPropertyOK()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierNo = 1;
            //invoke the method
            Found = Supplier.Find(SupplierNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //boolean varibale to store the result of the validation
            Boolean Found = false;
            //create some test dat ato tuse with the method
            int SupplierNo = 1;
            //invoke the method
            Found = Supplier.Find(SupplierNo);
            //test to see that the result id correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierNoFound()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 1;
            //invoke the method 
            Found = Supplier.Find(SupplierNo);
            //check the supplier no
            if (Supplier.SupplierNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 5;
            //invoke the method 
            Found = Supplier.Find(SupplierNo);
            //check the supplier no
            if (Supplier.Address != "eee")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 5;
            //invoke the method 
            Found = Supplier.Find(SupplierNo);
            //check the supplier no
            if (Supplier.PostCode != "eee")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneFound()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 5;
            //invoke the method 
            Found = Supplier.Find(SupplierNo);
            //check the supplier no
            if (Supplier.Phone != "555")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierNo = 5;
            //invoke the method 
            Found = Supplier.Find(SupplierNo);
            //check the supplier no
            if (Supplier.SupplierName != "eee")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            //invoke the method
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test no see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "012345678901234567890123456789012345678901234567891";//this should be fail
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameNoMin()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "a";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNamePlusMin()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "aa";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "0123456789012345678901234567890123456789012345678";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMax()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "01234567890123456789012345678901234567890123456789";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierMid()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "012345678934567890123456789";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameExtrmeMax()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a');//this should be fail
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            //invoke the method
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test no see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Address = "012345678901234567890123456789012345678901234567891";//this should be fail
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressNoMin()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Address = "a";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressPlusMin()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Address = "aa";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Address = "0123456789012345678901234567890123456789012345678";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Address = "01234567890123456789012345678901234567890123456789";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressrMid()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Address = "012345678934567890123456789";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Postcode = "";
            //invoke the method
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test no see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Postcode = "123456789";//this should be fail
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeNoMin()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Postcode = "a";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostcodePlusMin()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Postcode = "aa";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Address = "1234567";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeMax()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Address = "123456789";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Postcode = "123456";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMinLessOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string varibale to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Phone = "";
            //invoke the method
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test no see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMaxPlusOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Phone = "12345678901";//this should be fail
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMin()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Phone = "a";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhonePlusMin()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Postcode = "aa";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMaxLessOne()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Address = "1234567890";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMax()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Address = "12345678901";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneMid()
        {
            //create an instance of the calss we want to create
            clsSupplier Supplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Postcode = "12345678";//this should be ok
            //invoke the method 
            Error = Supplier.Valid(SupplierNo, SupplierName, Address, Postcode, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
