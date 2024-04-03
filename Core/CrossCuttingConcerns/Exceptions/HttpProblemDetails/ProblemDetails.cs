using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class ProblemDetails
    {
        //public ProblemDetails()
        //{

        //}
        public ProblemDetails(string title, string detail, string type)
        {
            Title = title;
            Detail = detail;
            Type = type;
        }

        public string Title { get; set; }
        public string Detail { get; set; }
        public string Type { get; set; }
    }
}