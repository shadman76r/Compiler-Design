using System;

class Game_Character
{
    // Protected members
    protected double Attackpoint;
    protected double Defensepoint;

    // Constructor to initialize attack and defense points
    public Game_Character(double attack = 0, double defense = 0)
    {
        Attackpoint = attack;
        Defensepoint = defense;
    }

    // Method to calculate the hitpoint (damage)
    public double Hitpoint()
    {
        return (Attackpoint * 2) - (Defensepoint * 0.5);
    }
}

class Ally : Game_Character
{
    // Default constructor
    public Ally() : base()
    {
        Console.WriteLine("I am Ally");
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("Ally Info:");
        Console.WriteLine("Attack Points: "+Attackpoint);
        Console.WriteLine("Defense Points: "+Defensepoint);
        Console.WriteLine("Hitpoint (Damage): "+Hitpoint());
    }
}

class Enemy : Game_Character
{
    // Protected member
    protected string Enemytype;

    // Default constructor
    public Enemy() : base()
    {
        Console.WriteLine("I am Enemy");
        Enemytype = "Generic Enemy";
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("Enemy Info:");
        Console.WriteLine("Enemy Type: "+Enemytype);
        Console.WriteLine("Attack Points: "+Attackpoint);
        Console.WriteLine("Defense Points: "+Defensepoint);
        Console.WriteLine("Hitpoint (Damage): "+Hitpoint());
    }
}

class Boss_Enemy : Enemy
{
    // Default constructor
    public Boss_Enemy()
    {
        Console.WriteLine("I am Boss Enemy");
        Enemytype = "Boss";
    }

    // Parameterized constructor to set values
    public Boss_Enemy(double attack, double defense, string type)
        : base()
    {
        Attackpoint = attack;
        Defensepoint = defense;
        Enemytype = type;
        Console.WriteLine("Boss Enemy Created with Custom Values");
    }

    // Display method
    public new void Display()
    {
        Console.WriteLine("Boss Enemy Info:");
        Console.WriteLine("Enemy Type: "+Enemytype);
        Console.WriteLine("Attack Points: "+Attackpoint);
        Console.WriteLine("Defense Points: "+Defensepoint);
        Console.WriteLine("Hitpoint (Damage): "+Hitpoint());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Ally
        Ally ally = new Ally();
        ally.Display();
        Console.WriteLine();

        // Create an instance of Enemy
        Enemy enemy = new Enemy();
        enemy.Display();
        Console.WriteLine();

        // Create an instance of Boss_Enemy with default values
        Boss_Enemy bossEnemy = new Boss_Enemy();
        bossEnemy.Display();
        Console.WriteLine();

        // Create an instance of Boss_Enemy with custom values
        Boss_Enemy customBoss = new Boss_Enemy(50, 30, "Custom Boss");
        customBoss.Display();
    }
}
