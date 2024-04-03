using Core.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class BusinessProblemDetails : ProblemDetails
    {
        public BusinessProblemDetails(string detail) : base(
            title: "Business Rule Violation",
            detail: detail,
            type: nameof(BusinessException))
        {
        }
    }
}