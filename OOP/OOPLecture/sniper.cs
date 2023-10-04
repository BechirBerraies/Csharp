

// inheritance
public class Sniper : Soldier, IHaveWeapon
{
    // Properties 
    public double Precision { get; set; }
    public double EagleEye { get; set; }
    public int  MaxRange { get; set; }
    public string Weapon {get;set;}
    public bool IsFire {get;set;}
    public int NumberOfBullets {get;set;}

    // Constructors 
    public Sniper(string name , int age, int maxRange ):base(name,age)
    {
        Precision = 0.8;
        EagleEye = 0.75;
        MaxRange = maxRange;
        Weapon = "Sniper";
        IsFire = true;
        NumberOfBullets= 30;

    }
    // Methods 
    // override : this method belong to my paret class (base) class => Polymorphism 
    public override void ShowInfo()
    {
        base.ShowInfo();
        System.Console.WriteLine($" Precision{Precision}\n EagleEye : {EagleEye}\n MaxRange : {MaxRange} ");
    }
    public void UseWeapon()
    {
        System.Console.WriteLine($"[SHOOT] {Name} used his {Weapon}");
        NumberOfBullets -= 1 ;
        // target.Health= 0;
    }


}