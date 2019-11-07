using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolTracker1.Program;

namespace SchoolTracker2
{
    class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("paying principal");
        }
    }
}
