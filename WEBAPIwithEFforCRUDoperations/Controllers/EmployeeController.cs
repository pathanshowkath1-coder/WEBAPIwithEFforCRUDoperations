using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPIwithEFforCRUDoperations.Models;
using System.Configuration;

namespace WEBAPIwithEFforCRUDoperations.Controllers
{
    public class EmployeeController : ApiController
    {
        EmpContext db = new EmpContext();

        public List<Emp> Get(string str)
        {
            List<Emp> emps = db.Emps.Where(temp => temp.EmpName.Contains(str)).ToList();
            return emps;
        }


        public string Post(Emp emp)
        {
            db.Emps.Add(emp);
            db.SaveChanges();
            return "Successfully Inserted";
        }


        public string Put(Emp emp)
        {
            Emp e = db.Emps.Where(temp => temp.EmpId == emp.EmpId).FirstOrDefault();
            e.EmpName = emp.EmpName;
            e.Salary = emp.Salary;
            db.SaveChanges();
            return "Successfully Updated";
        }


        public string Delete(int empid)
        {
            Emp e = db.Emps.Where(temp => temp.EmpId == empid).FirstOrDefault();
            db.Emps.Remove(e);
            db.SaveChanges();
            return "Successfully Deleted";
        }
    }


}