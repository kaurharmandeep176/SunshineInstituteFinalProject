﻿using SunshineInstitute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SunshineInstitute.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff

        DBInstituteEntities db = new DBInstituteEntities();

        public ActionResult AllDetail()
        {
            return View(db.Staffs.ToList());
        }




        // GET: Suggestion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Suggestion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Suggestion/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "id")] Staff tech)
        {

            if (!ModelState.IsValid)
                return View();
            db.Staffs.Add(tech);
            db.SaveChanges();
            //Response.Redirect("StudentAdmission",true);
            return RedirectToAction("AllDetail");
        }

        // GET: Suggestion/Edit/5
        public ActionResult Edit(int id)
        {
            var IdEdit = (from m in db.Staffs where m.id == id select m).First();
            return View(IdEdit);
        }

        // POST: Suggestion/Edit/5
        [HttpPost]
        public ActionResult Edit(Staff IdEdit)
        {
            var orignalRecord = (from m in db.Staffs where m.id == IdEdit.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            db.Entry(orignalRecord).CurrentValues.SetValues(IdEdit);

            db.SaveChanges();
            return RedirectToAction("AllDetail");

        }

        // GET: Suggestion/Delete/5
        public ActionResult Delete(Staff IdDel)
        {
            var d = db.Staffs.Where(x => x.id == IdDel.id).FirstOrDefault();
            db.Staffs.Remove(d);
            db.SaveChanges();
            return RedirectToAction("AllDetail");

        }

        // POST: Suggestion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



    }
}
