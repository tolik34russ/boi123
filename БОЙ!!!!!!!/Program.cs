internal class Program
{
    static void Main(string[] args)
    {
        Figthers[] figthers =
        {
            new Figthers("ЛОХ", 100, 20, 5),
            new Figthers("ПОЗОР", 120, 10, 5),
            new Figthers("ХАХАХА", 70, 30, 5),
        }; 
        
        for (int i = 0; i < figthers.Length; i++) 
        {
            Console.Write(i + 1 + " ");
            figthers[i].ShowInfo(); 
        }
        Console.ReadKey(true);

        Console.WriteLine("-------------------------------------------------------");

        Console.WriteLine("Кто будет драться первым?");
        int FirstNum = Convert.ToInt32(Console.ReadLine()) - 1;
        Figthers FirstFigther = figthers[FirstNum];

        Console.WriteLine("Кто будет драться вторым?");
        int SecondNum = Convert.ToInt32(Console.ReadLine()) - 1;
        Figthers SecondFigther = figthers[SecondNum];

        Console.WriteLine("-------------------------------------------------------");
        while (FirstFigther.Health > 0 && SecondFigther.Health > 0)
        {
            FirstFigther.TakenDamage(SecondFigther.Damage);
            SecondFigther.TakenDamage(FirstFigther.Damage);
            FirstFigther.CurrentHealth();
            SecondFigther.CurrentHealth();

        }

    }

    class Figthers 
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;

        public Figthers(string name, int health, int damage, int armor) 
        { 
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public int Health 
        { 
            get { return _health; }   
        }

        public int Damage
        {
            get { return _damage; }
        }

        public void ShowInfo() 
        {
            Console.WriteLine("Имя бойца: " + _name + ", здоровье: " + _health + ", урон: " + _damage + ", броня: " + _armor); 
        }
        public void CurrentHealth()
        {
            Console.WriteLine($"{_name} здоровье: {_health}");
        }

        public void TakenDamage(int damage) 
        {
            _health -= damage - _armor;
        }
    }   
}