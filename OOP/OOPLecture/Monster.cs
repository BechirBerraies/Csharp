public abstract class Monster
{
    public string Name {get;set;}
    public double Power { get; set; }
    public bool IsImmortal { get; set; }

    public string PowerType{ get; set; }

    public Monster(string name, double power , bool isImmortal, string powerType  )
    {
        //this.Name = name; possible
        Name = name;
        Power = power;
        IsImmortal = isImmortal;
        PowerType = powerType;
    }
    public void Transform()
    {
        Power += Power*2;
        Console.WriteLine($"[TRANSFORM] {Name} has A activated Monster Mode \n Run and dont look behind ");

    }
}