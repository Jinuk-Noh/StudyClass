using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        #region 인터페이스
        static void Main(string[] args)
        {
            InspectEvolveMachine machine = new InspectEvolveMachine();

            //IEvolve poketmon = new Pikachu();
            //IEvolve poketmon = new Charmander();
            //machine.NotifyHowToEvolve(poketmon);
            //machine.CheckCanEvolve(poketmon);
            //machine.MeetEvovleCondition(poketmon);
            //machine.CheckCanEvolve(poketmon);

            IEvolve human = new Human();
            machine.NotifyHowToEvolve(human);
            machine.CheckCanEvolve(human);
            machine.MeetEvovleCondition(human);
            machine.CheckCanEvolve(human);

            Thread.Sleep(10 * 1000);

        }
        #endregion

        #region 다향성
        //static void Main(string[] args)
        //{
        //    List<Pokemon> meetPokemonList = new List<Pokemon>();

        //    for(int i = 0; i < 5; i++)
        //    {
        //        meetPokemonList.Add(MeetPokemon());

        //        Thread.Sleep(500);               
        //    }

        //    foreach(var poketmon in meetPokemonList)
        //    {
        //        if (poketmon == null)
        //            Console.WriteLine("포켓몬을 조우하지 못했습니다.");
        //        else
        //        {
        //            poketmon.ShowUp();
        //            poketmon.ShowAbilty();
        //            poketmon.UseSkill();
        //        }

        //        Console.WriteLine("-------------------------------");
        //    }

        //    Thread.Sleep(10 * 1000);
        //}


        private static Pokemon MeetPokemon()
        {
            Random random = new Random();
            Pokemon poketmon;

            switch (random.Next(0, 3))
            {
                case 0:
                    poketmon = new Pikachu();
                    break;
                case 1:
                    poketmon = new Charmander();
                    break;
                default: poketmon = null;
                    break;
            }

            return poketmon;
        }
        #endregion
    }
}
