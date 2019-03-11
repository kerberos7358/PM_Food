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
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, 2);
        }
    }
}
