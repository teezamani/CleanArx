using CleanArx.Core.Entity;
using CleanArx.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArx.Application.Command.EmployeeCommand
{
    public record AddEmployeeCommand(Employee Employee) : IRequest<Employee>;

    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<AddEmployeeCommand, Employee>
    {
        public async Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.AddEmployeeAsync(request.Employee);
        }
    }
}
