using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class ValidationProblemDetails : ProblemDetails
    {
        public ValidationProblemDetails(string detail) : base(
            title: "Validation Rule Violation",
            detail: detail,
            type: nameof(ValidationException))
        {
        }
    }
}