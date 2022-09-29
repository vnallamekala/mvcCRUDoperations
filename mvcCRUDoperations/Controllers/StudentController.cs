using mvcCRUDoperations.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcCRUDoperations.Context.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        MvcCrudEntities dbObj = new MvcCrudEntities();
        public ActionResult Student(tblUserInfo Obj)
        { 
            return View(Obj);  
        }
        [HttpPost]
        public ActionResult AddStudent(tblUserInfo model)
        {
            tblUserInfo Obj = new tblUserInfo();
            if (ModelState.IsValid)
            {
                Obj.empId = model.empId;
                Obj.empName = model.empName;
                Obj.empMobile = model.empMobile;
                Obj.empAddress = model.empAddress;
                Obj.empDept = model.empDept;

                if (model.empId == 0)
                {
                    dbObj.tblUserInfos.Add(Obj);
                    dbObj.SaveChanges();
                }
                else
                {
                    dbObj.Entry(Obj).State = EntityState.Modified;
                    dbObj.SaveChanges();
                }

                

            }
            ModelState.Clear();
            

            return View("Student");
        }
        
        public ActionResult StudentList()
        {
            var res = dbObj.tblUserInfos.ToList();
            return View(res);

        }
        public ActionResult Delete(int empId)
        {
            var res = dbObj.tblUserInfos.Where(x => x.empId == empId).First();
            dbObj.tblUserInfos.Remove(res);
            dbObj.SaveChanges();

            var list = dbObj.tblUserInfos.ToList();

            return View("StudentList",list);


        }


    }
}