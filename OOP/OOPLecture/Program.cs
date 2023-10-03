// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


var jhon = new Soldier("Jhon" ,23, 1.0,0.5);
// System.Console.WriteLine(jhon.Name);
// jhon.Age =99;
// System.Console.WriteLine(jhon.Name);
Sniper sam = new Sniper("Sam",41,200);


Soldier james = new Soldier("james",25);
// System.Console.WriteLine(james.Age);
// jhon.ShowInfo();
// james.ShowInfo();

// james.Attack(jhon,0.2);
// jhon.ShowInfo();

// sam.ShowInfo();

List<Soldier> Army = new List<Soldier>(){
    jhon, james,sam
};
foreach(Soldier soldier in Army )
{
    soldier.ShowInfo();
}
