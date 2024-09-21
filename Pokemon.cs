using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {
        protected string name;

        protected int myStrong;
        protected int myHealth;
        protected int mySpeed;

        protected int maxStrong = 10;
        protected int minStrong = 1;
        protected int maxHealth = 10;
        protected int minHealth = 1;
        protected int maxSpeed = 10;
        protected int minSpeed = 1;

        protected PokemonType type = 0;
        protected int level;

        public Pokemon()
        {

        }

        public Pokemon(string name)
        {
            this.name = name;
        }

        public void ShowUp()
        {
            Console.WriteLine($"{name} 포켓몬이 나타났다!");
        }

        public virtual void UseSkill()
        {
            Console.WriteLine("포켓몬은 스킬을 사용했다.");
        }

        public void Evolve()
        {
            Console.WriteLine("포켓몬이 진화했습니다.");
        }

        protected void SetMyAbility()
        {
            Random random = new Random();
            myStrong = random.Next(minStrong, maxStrong);
            myHealth = random.Next(minHealth, maxHealth);
            mySpeed = random.Next(minSpeed, maxSpeed);
        }

        public void ShowAbilty()
        {
            Console.WriteLine($"{name}이 가질 수 있는 공격 최대 수치 : {maxStrong}/ 최소 수치{minStrong}/ 해당 객체 수치{myStrong}");
            Console.WriteLine($"{name}이 가질 수 있는 체력 최대 수치 : {maxHealth}/ 최소 수치{minHealth}/ 해당 객체 수치{myHealth}");
            Console.WriteLine($"{name}이 가질 수 있는 스피드 최대 수치 : {maxSpeed}/ 최소 수치{minSpeed}/ 해당 객체 수치{mySpeed}");
        }
    }

    public enum PokemonType
    {
        None = 0,
        Fire = 1,
        Water = 2,
        Grass = 3,
        Electric = 4,
    }
}
