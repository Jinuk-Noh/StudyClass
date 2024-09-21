using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pikachu : Pokemon, IEvolve
    {

        public Pikachu()
        {
            name = "피카츄";
            maxStrong = 5;
            minStrong = 2;
            maxHealth = 3;
            minHealth = 1;
            maxSpeed = 10;
            minSpeed = 7;

            type = PokemonType.Electric;

            SetMyAbility();
        }
    
        public override void UseSkill()
        {
            Console.WriteLine("백만 볼트");
        }

        bool canEvolve = false;
        public bool CheckCanEvolve()
        {
            return canEvolve;
        }

        public void MeetEvovleCondition()
        {
            Random random = new Random();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("진화의 돌을 찾습니다.");

                if(random.Next(0, 10) < 3)
                {
                    Console.WriteLine("진화의 돌을 찾았습니다.");
                    canEvolve = true;
                    break;
                }
                else
                {
                    Console.WriteLine("진화의 돌을 찾지 못했습니다.");
                }          
            }
        }

        public void NotifyHowToEvolve()
        {
            Console.WriteLine($"{name} : 진화의 돌이 필요합니다.");
        }

    }
}
