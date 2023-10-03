/*
class ? blueprint or template to create objects 
class : 
        Attribites/fields : What the class can have 
        Methods : What the class can do or behave 

Object : Instance of the class.
In python :
    class Soldier :
        def __init__(self,name):
            self.name = name

In JavaScript : 
    class Soldier {
        constructor(){
            this.name = name 
        }
    }
*/

public class Soldier 
{
    //Attributes 
    //! Attribute name + get se --> Property
    public string Name {get;set;}
    public int Age {get;set;}
    public double Power{get;set;}
    public double Health{get;set;}

    //Constructor 
    public Soldier(string name, int age)
    {
        Name = name;
        Age = age;
        Power= 1;
        Health = 1;


    }
    public Soldier(string name, int age , double power , double health)
    {
        Name = name;
        Age = age;
        Power= power;
        Health = health;
    }

    //Methods 
 // virtual : can be changed by child classes 
    public virtual void ShowInfo()
    {
        System.Console.WriteLine($"Name : {Name}\n Age : {Age}\n Power: {Power}\n Health:{Health} ");
    }
    public int IncreaseAge()
    {
        Age+=1;
        return Age;
    }
    public double Train(double amount)
    {
        Power += amount;
        return Power;
    }
    public void Attack(Soldier target, double damageRate)
    {
        target.Health -= Power*damageRate;
        System.Console.WriteLine($"[ATTACK] Soldier {Name} atacked Soldier {target.Name} by Damage Rate equals to {damageRate} ");
    }
}