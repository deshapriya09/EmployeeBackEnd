using EmployeeApp.Data;
using EmployeeApp.Models;
using System;

namespace EmployeeApp.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DataContext context) : base(context)
        {
        }

        public DataContext DataContext
        {
            get { return context as DataContext; }
        }
    }
}
