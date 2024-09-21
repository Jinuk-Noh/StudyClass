using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Human : IEvolve
    {
        public bool CheckCanEvolve()
        {
            Console.WriteLine("사람은 진화할 수 없어요");
            return false;
        }

        public void MeetEvovleCondition()
        {
            Console.WriteLine("사람은 진화할 수 없어요");
        }

        public void NotifyHowToEvolve()
        {
            Console.WriteLine("사람은 진화할 수 없어요");
        }
    }
}
