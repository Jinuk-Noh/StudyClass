using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Charmander : Pokemon, IEvolve
    {
        public Charmander()
        {
            name = "파이리";
            maxStrong = 10;
            minStrong = 6;
            maxHealth = 8;
            minHealth = 1;
            maxSpeed = 6;
            minSpeed = 3;

            type = PokemonType.Fire;

            SetMyAbility();
        }
       
        public override void UseSkill()
        {
            Console.WriteLine("화염방사");
        }

        public bool CheckCanEvolve()
        {
            return level >= 16;
        }

        public void MeetEvovleCondition()
        {
            while(level < 16)
            {
                Console.WriteLine("아무 키 입력 Enter 입력 시 중단");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                if (keyInfo.Key == ConsoleKey.Enter)
                    break;
                else
                    level++;

                Console.WriteLine($"현재 레벨 : {level}");
            }

            Console.WriteLine("중단");
        }

        public void NotifyHowToEvolve()
        {
            Console.WriteLine($"{name} : 레벨 16을 달성해야 진화 할 수 있습니다.");
        }
    }
}
