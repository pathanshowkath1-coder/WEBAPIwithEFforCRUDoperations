using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WEBAPIwithEFforCRUDoperations.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext() : base("getconn")
        {
        }

        public DbSet<Emp> Emps { get; set; }
    }
}