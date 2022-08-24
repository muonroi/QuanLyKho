using Microsoft.AspNetCore.Mvc;
using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;

namespace QuanLyKhoAdminManage.Controllers
{
    public class BulkDataController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // This is only for show by default one row for insert data to the database
            List<ContactInfo> ci = new List<ContactInfo> { new ContactInfo { ID = 0, ContactName = "", ContactNo = "" } };
            return View(ci);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BulkData(List<ContactInfo> ci)
        {
            
            if (ModelState.IsValid)
            {
                //using (MyDatabaseEntities dc = new MyDatabaseEntities())
                //{
                //    foreach (var i in ci)
                //    {
                //        dc.ContactInfoes.Add(i);
                //    }
                //    dc.SaveChanges();
                //    ViewBag.Message = "Data successfully saved!";
                //    ModelState.Clear();
                //    ci = new List<ContactInfo> { new ContactInfo { ID = 0, ContactName = "", ContactNo = "" } };
                //}
            }
            return View(ci);
        }
    }
}
