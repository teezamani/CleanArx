using CleanArx.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArx.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployeeByIdAsync(Guid id);
        Task<Employee> AddEmployeeAsync(Employee entity);
        Task<Employee> UpdateEmployeeAsync(Guid employeeId, Employee entity);
        Task<bool> DeleteEmployeeAsync(Guid employeeId);
    }
}
