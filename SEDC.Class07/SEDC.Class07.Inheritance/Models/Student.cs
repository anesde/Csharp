using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class07.Inheritance
{
    public class Student : Person
    {
        public string Academy { get; set; }

        public string CurrentSubject { get; set; }

        public string[] FinishedSubject { get; set; }
    }
}
