using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.classes
{

    //High Cohesion
    public class calculate
    {
        private string cgpa;
        private string salary;
        public string compute(string identity)
        {
            if (identity == "student")
            {
                cgpa = "3.8";
                return cgpa;
            }
            else
                return salary = "70000";
        }
    }
}
