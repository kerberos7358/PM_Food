using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RestaurantTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaffs);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create an item to the list
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Some FirstName";
            TestItem.Surname = "Some Surname";
            TestItem.Sex = "Some Sex";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Address1 = "Some Address1";
            TestItem.Address2 = "Some Address2";
            TestItem.Address3 = "Some Address3";
            TestItem.PostCode = "Some PostCode";
            TestItem.Email = "Some Email";
            TestItem.Phone = "Some Phone";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create sone test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllStaffs.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffNo = 1;
            TestStaff.FirstName = "Some FirstName";
            TestStaff.Surname = "Some Surname";
            TestStaff.Sex = "Some Sex";
            TestStaff.DOB = DateTime.Now.Date;
            TestStaff.Address1 = "Some Address1";
            TestStaff.Address2 = "Some Address2";
            TestStaff.Address3 = "Some Address3";
            TestStaff.PostCode = "Some PostCode";
            TestStaff.Email = "Some Email";
            TestStaff.Phone = "Some Phone";
            //assign the data to the property
            AllStaffs.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create an item to the list
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Some FirstName";
            TestItem.Surname = "Some Surname";
            TestItem.Sex = "Some Sex";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Address1 = "Some Address1";
            TestItem.Address2 = "Some Address2";
            TestItem.Address3 = "Some Address3";
            TestItem.PostCode = "Some PostCode";
            TestItem.Email = "Some Email";
            TestItem.Phone = "Some Phone";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Some FirstName";
            TestItem.Surname = "Some Surname";
            TestItem.Sex = "Some Sex";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Address1 = "Some Address1";
            TestItem.Address2 = "Some Address2";
            TestItem.Address3 = "Some Address3";
            TestItem.PostCode = "Some PostCode";
            TestItem.Email = "Some Email";
            TestItem.Phone = "Some Phone";
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Some FirstName";
            TestItem.Surname = "Some Surname";
            TestItem.Sex = "Some Sex";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Address1 = "Some Address1";
            TestItem.Address2 = "Some Address2";
            TestItem.Address3 = "Some Address3";
            TestItem.PostCode = "Some PostCode";
            TestItem.Email = "Some Email";
            TestItem.Phone = "Some Phone";
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaffs.Delete();
            //now find the record
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Some FirstName";
            TestItem.Surname = "Some Surname";
            TestItem.Sex = "Some Sex";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Address1 = "Some Address1";
            TestItem.Address2 = "Some Address2";
            TestItem.Address3 = "Some Address3";
            TestItem.PostCode = "Some PostCode";
            TestItem.Email = "Some Email";
            TestItem.Phone = "Some Phone";
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //modify the test data
            TestItem.FirstName = "Some FirstName 1";
            TestItem.Surname = "Some Surname 1";
            TestItem.Sex = "Some Sex 1";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Address1 = "Some Address4";
            TestItem.Address2 = "Some Address5";
            TestItem.Address3 = "Some Address6";
            TestItem.PostCode = "Some PostCode 1";
            TestItem.Email = "Some Email 1";
            TestItem.Phone = "Some Phone 1";
            //set the record based on the new test data
            AllStaffs.ThisStaff = TestItem;
            //update the record
            AllStaffs.Update();
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a blank string (should return all records);
            FilteredStaffs.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a post code that doesn't exist
            FilteredStaffs.ReportByPostCode("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredStaffs.ReportByPostCode("yyy yyy");
            //check that the correct number of records are found
            if (FilteredStaffs.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredStaffs.StaffList[0].StaffNo != 36)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredStaffs.StaffList[1].StaffNo != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
