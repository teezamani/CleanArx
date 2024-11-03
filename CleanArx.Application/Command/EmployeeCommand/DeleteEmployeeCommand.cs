﻿using CleanArx.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArx.Application.Command.EmployeeCommand
{
    public record DeleteEmployeeCommand(Guid EmployeeId) : IRequest<bool>;

    public class DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.DeleteEmployeeAsync(request.EmployeeId);
        }
    }
}
