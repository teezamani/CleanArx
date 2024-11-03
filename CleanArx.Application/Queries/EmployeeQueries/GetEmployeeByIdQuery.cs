using CleanArx.Core.Entity;
using CleanArx.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArx.Application.Queries.EmployeeQueries
{
    public record GetEmployeeByIdQuery(Guid EmployeeId) : IRequest<Employee>;

    public class GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeeByIdAsync(request.EmployeeId);
        }
    }
}
