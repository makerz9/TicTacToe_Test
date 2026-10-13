using System;

using Shop;

Weapon sword = new Weapon("강철 검", 12000, 25);
Potion potion = new Potion("회복 물약", 500, 40);

sword.PrintLabel();
sword.PrintAttack();

Console.WriteLine();

potion.PrintLabel();
potion.PrintHeal();

Console.WriteLine();

Cart cart = new Cart();
cart.Add(sword.Price);
cart.Add(potion.Price);
cart.Add(potion.Price);
cart.PrintTotal();

namespace Shop
{
    class Product
    {
        protected string name;
        protected int price;

        public int Price
        {
            get { return price; }
        }

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        protected string FormatPrice()
        {
            return $"{price:N0}원";
        }

        public void PrintLabel()
        {
            Console.WriteLine($"품목: {name}");
            Console.WriteLine($"가격: {FormatPrice()}");
            PrintDetail();
        }

        protected void PrintDetail()
        {
            Console.WriteLine("상세 정보 없음");
        }
    }

    sealed class Weapon : Product
    {
        private int damage;

        public Weapon(string name, int price, int damage) : base(name, price)
        {
            this.damage = damage;
        }

        public void PrintAttack()
        {
            Console.WriteLine($"공격력 {damage}");
        }
    }

    sealed class Potion : Product
    {
        private int heal;

        public Potion(string name, int price, int heal) : base(name, price)
        {
            this.heal = heal;
        }

        public void PrintHeal()
        {
            Console.WriteLine($"회복량 {heal}");
        }
    }

    class Register
    {
        private int total;

        public void Add(int amount)
        {
            total += amount;
        }

        public int Total
        {
            get { return total; }
        }
    }

    class Cart
    {
        private Register register = new Register();
        private int count;

        public void Add(int price)
        {
            register.Add(price);
            count++;
        }

        public void PrintTotal()
        {
            Console.WriteLine($"담은 개수: {count}");
            Console.WriteLine($"결제 금액: {register.Total:N0}원");
        }
    }
}