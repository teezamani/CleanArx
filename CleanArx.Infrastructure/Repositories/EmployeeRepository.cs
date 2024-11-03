﻿using CleanArx.Core.Entity;
using CleanArx.Core.Interfaces;
using CleanArx.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArx.Infrastructure.Repositories
{
    public class EmployeeRepository(AppDbContext dbContext) : IEmployeeRepository
    {
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(Guid id)
        {
            return await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Employee> AddEmployeeAsync(Employee entity)
        {
            entity.Id = Guid.NewGuid();
            dbContext.Employees.Add(entity);

            await dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Employee> UpdateEmployeeAsync(Guid employeeId, Employee entity)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);

            if (employee is not null)
            {
                employee.Name = entity.Name;
                employee.Email = entity.Email;
                employee.Phone = entity.Phone;

                await dbContext.SaveChangesAsync();

                return employee;
            }

            return entity;
        }

        public async Task<bool> DeleteEmployeeAsync(Guid employeeId)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);

            if (employee is not null)
            {
                dbContext.Employees.Remove(employee);

                return await dbContext.SaveChangesAsync() > 0;
            }

            return false;
        }
    }
}
