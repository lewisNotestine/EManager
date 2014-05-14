using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManager.Domain 
{
    /// <summary>
    /// Interface type for an infrastructure, to implement more testable code. 
    /// </summary>
    public interface IDepartmentDatasource 
    {
        IQueryable<Employee> Employees { get; }
        IQueryable<Department> Departments { get; }
    }
}
