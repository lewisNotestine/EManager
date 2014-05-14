using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public interface IDepartmentDatasource {
        public virtual IQueryable<Employee> Employees { get; }
        public virtual string Name { get; }

    }
}
