public class Sniper : Soldier
{
    // Properties 
    public double Precision { get; set; }
    public double EagleEye { get; set; }
    public int  MaxRange { get; set; }

    // Constructors 
    public Sniper(string name , int age, int maxRange ):base(name,age)
    {
        Precision = 0.8;
        EagleEye = 0.75;
        MaxRange = maxRange;
    }
    // Methods 
    // override : this method belong to my paret class (base) class => Polymorphism 
    public override void ShowInfo()
    {
        base.ShowInfo();
        System.Console.WriteLine($" Precision{Precision}\n EagleEye : {EagleEye}\n MaxRange : {MaxRange} ");
    }


}