using System;
using System.Collections.Generic;
using System.Data.Entity;
using EManager.Domain;
using System.Linq;
using System.Web;

namespace EManager.web.Infrastructure {

    /// <summary>
    /// Supports Entity framework SQL Server Schemata.
    /// </summary>
    public class DepartmentDb : DbContext, IDepartmentDatasource {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DepartmentDb() : base("DefaultConnection") { 
        
        }

        IQueryable<Employee> IDepartmentDatasource.Employees {
            get { return Employees; }
        }

        IQueryable<Department> IDepartmentDatasource.Departments {
            get { return Departments; }
        }

    }
}