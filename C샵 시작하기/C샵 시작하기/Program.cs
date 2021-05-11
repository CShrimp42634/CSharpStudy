using System;

namespace C샵_시작하기
{
    class Program
    {

        static void Main(string[] args)
        {
            Player player = new Player();
            Food food = new Food("빵", 20);

            player.Eat(food);
        }
    }

    class Food
    {
        public string Name { get; set; }
        public int Recovery { get; set; }

        //클래스 변수
        public Food(string Name, int Recovery)
        {
            this.Name = Name;
            this.Recovery = Recovery;
        }
    }

    // 무기
    class Weapon
    {
        public int Attack { get; set; }
    }

    // Monster


    class Player
    {
        // 멤버필드 or 전역 변수
        public int HP { get; set; }
        public int MaxHP { get; set; }

        public Player()
        {
            this.MaxHP = 200;
            this.HP = 97;
        }

        //매개변수
        public void Eat(Food food)
        {
            //함수 내에 선언된 변수를 지역변수라 한다.
            if (MaxHP == this.HP)
            {
                Console.WriteLine("용사는 이미 체력이 가득이다!");
            }
            else
            {
                int _hp = this.HP;
                this.HP = this.HP + food.Recovery;
                if (this.HP > this.MaxHP)
                {
                    this.HP = this.HP + (this.MaxHP - this.HP);
                }

                Console.WriteLine($"{food.Name}을 먹었다!");
                Console.WriteLine($" HP 회복!  HP: {_hp} -> {this.HP}");
            }
        }
    }
}
