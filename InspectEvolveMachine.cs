using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class InspectEvolveMachine
    {
        public void CheckCanEvolve(IEvolve evolve)
        {
            Console.WriteLine($"진화 가능 여부 : {evolve.CheckCanEvolve()}");
        }

        public void NotifyHowToEvolve(IEvolve evolve)
        {
            evolve.NotifyHowToEvolve();
        }

        public void MeetEvovleCondition(IEvolve evolve)
        {
            evolve.MeetEvovleCondition();
        }
    }
}
