using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCentre.Service.Exceptions
{
    public class LearningCentreException : Exception
    {
        public int Code { get; set; }
        public LearningCentreException(int code = 500,string massage = "Something went wrong") : base (massage)
        {
            this.Code = code;
        }
    }
}
