using BeatMyGrades.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BeatMyGrades.Controllers
{
    public class GroupsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [AuthorizeAttribute(Roles = "Admin, CanEditGroup, CanEditUser")]
        public ActionResult Index()
        {
            return View(db.Groups.ToList());
        }


        [AuthorizeAttribute(Roles = "Admin, CanEditGroup, CanEditUser")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = db.Groups.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }


        [AuthorizeAttribute(Roles = "Admin, CanEditGroup")]
        public ActionResult Create()
        {
            return View();
        }


        [AuthorizeAttribute(Roles = "Admin, CanEditGroup")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name")] Group group)
        {
            if (ModelState.IsValid)
            {
                db.Groups.Add(group);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(group);
        }


        [AuthorizeAttribute(Roles = "Admin, CanEditGroup")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = db.Groups.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }


        [AuthorizeAttribute(Roles = "Admin, CanEditGroup")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Group group)
        {
            if (ModelState.IsValid)
            {
                db.Entry(group).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(group);
        }


        [AuthorizeAttribute(Roles = "Admin, CanEditGroup")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = db.Groups.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }
            return View(group);
        }


        [AuthorizeAttribute(Roles = "Admin, CanEditGroup")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Group group = db.Groups.Find(id);
            var idManager = new IdentityManager();
            idManager.DeleteGroup(id);
            return RedirectToAction("Index");
        }


        [AuthorizeAttribute(Roles = "Admin, CanEditGroup")]
        public ActionResult GroupRoles(int id)
        {
            var group = db.Groups.Find(id);
            var model = new SelectGroupRolesViewModel(group);
            return View(model);
        }


        [HttpPost]
        [AuthorizeAttribute(Roles = "Admin, CanEditGroup")]
        [ValidateAntiForgeryToken]
        public ActionResult GroupRoles(SelectGroupRolesViewModel model)
        {
            if (ModelState.IsValid)
            {
                var idManager = new IdentityManager();
                var Db = new ApplicationDbContext();
                var group = Db.Groups.Find(model.GroupId);
                idManager.ClearGroupRoles(model.GroupId);

                // Add each selected role to this group:
                foreach (var role in model.Roles)
                {
                    if (role.Selected)
                    {
                        idManager.AddRoleToGroup(group.Id, role.RoleName);
                    }
                }
                return RedirectToAction("index");
            }
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}