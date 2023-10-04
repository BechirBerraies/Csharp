public class Mermaid : Monster
{
    public double Swim {get;set;}
    public  Mermaid(string name, double power, bool isImmortal, string powerType):base(name,power,isImmortal,powerType)
    {
        Swim = 1.0;
        
    }
}