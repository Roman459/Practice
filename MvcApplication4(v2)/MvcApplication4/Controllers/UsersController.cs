using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;



namespace MvcApplication4.Controllers
{
    public class UsersController : Controller
    {

        //
        // GET: /Default1/
        private UsersDBDataContext db = new UsersDBDataContext();
        public ActionResult Index()
        { 
            var Users = (from User in db.Users select User).ToList();
            return View(Users);
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id)
        {
          var UsersDetails = (from User in db.Users where User.ID_user == id select User).First();
            return View(UsersDetails);       
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            Users user = new Users();
            return View(user);
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(Users user, HttpPostedFileBase file)
        {  
            try
            {
                if (ModelState.IsValid)
                {  
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Images"), fileName);
                    file.SaveAs(path);
                    user.foto_user = "~/Images/" + file.FileName;
                    db.Users.InsertOnSubmit(user);
                    db.SubmitChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(user);
        }
        
        
       
        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id)
        {
            var UsersEdit = (from User in db.Users where User.ID_user == id select User).First();
            return View(UsersEdit);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, HttpPostedFileBase file, Users user)
        {   
            var UsersEdit = (from User in db.Users where User.ID_user == id select User).First();
            try
            {   
                    if (file != null)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Images"), fileName);
                        file.SaveAs(path);
                        UsersEdit.foto_user = "~/Images/" + file.FileName;
                    }
                    UpdateModel(UsersEdit);
                    db.SubmitChanges();
                    return RedirectToAction("Index");
                }  
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(UsersEdit);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id)
        {
            var UsersDelete = (from User in db.Users where User.ID_user == id select User).First();
            return View(UsersDelete);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var UsersDelete = (from User in db.Users where User.ID_user == id select User).First();
            try
            {
                // TODO: Add delete logic here
                db.Users.DeleteOnSubmit(UsersDelete);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(UsersDelete);
            }
        }
    }
}
