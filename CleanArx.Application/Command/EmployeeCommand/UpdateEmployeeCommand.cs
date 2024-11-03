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
    public record UpdateEmployeeCommand(Guid EmployeeId, Employee Employee)
         : IRequest<Employee>;
    public class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<UpdateEmployeeCommand, Employee>
    {
        public async Task<Employee> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.UpdateEmployeeAsync(request.EmployeeId, request.Employee);
        }
    }
}
