using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolTracker1.Program;

namespace SchoolTracker2
{
    class Teacher : Member, IPayee
    {
        public string Subject;

        public void Pay()
        {
            Console.WriteLine("paying teacher");
        }
    }
}
