// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// var jhon = new Soldier("Jhon" ,23, 1.0,0.5);
// System.Console.WriteLine(jhon.Name);
// jhon.Age =99;
// System.Console.WriteLine(jhon.Name);
Sniper sam = new Sniper("Sam",41,200);


// Soldier james = new Soldier("james",25);
// System.Console.WriteLine(james.Age);
// jhon.ShowInfo();
// james.ShowInfo();

// james.Attack(jhon,0.2);
// jhon.ShowInfo();

// sam.ShowInfo();
Mermaid alice = new Mermaid("Alice",0.65,true,"Magic Voice");

List<Soldier> Army = new List<Soldier>(){
    sam
};

Centaur jack = new Centaur("Jack",0.9,true,"Fight");

System.Console.WriteLine(sam.NumberOfBullets);
sam.UseWeapon();
System.Console.WriteLine(sam.NumberOfBullets);
// foreach(Soldier soldier in Army )
// {
//     soldier.ShowInfo();
// }

//! NON PLAYABLE CHARACTERS 
// var test = new Monster("Test",100,true,"Test");

// Console.WriteLine($"alice before{alice.Power}");
// alice.Transform();
// Console.WriteLine($"alice after{alice.Power}");
