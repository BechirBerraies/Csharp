
//! Array

// int[] numbers = new int[9];



string[] names = new string[4] {"Sarah","Aziz","Amin","Jalel"};

// bool[] isTrue = new bool[10]{true,false,true,false,true,false,true,false,true,false};


// System.Console.WriteLine(isTrue);


//! List 


List<string> FlavorList = new List<string>() {"Hot","Cold", "Vanilla","Choclate","Hehe"};


// System.Console.WriteLine(FlavorList);
// System.Console.WriteLine(FlavorList.Count());
// // System.Console.WriteLine(FlavorList.indexOf("Vanilla"));
// FlavorList.Remove("Vanilla");
// System.Console.WriteLine(FlavorList.Count());


//! Dictionnary


// int index = rand.Next(names.Length);
// int index2 = rand.Next(FlavorList.length);

Dictionary<string,string> MyDict = new Dictionary<string, string>() {
    {names[0],FlavorList[0]}
};

for (int i =0 ; i< names.Length; i++)
{
System.Console.WriteLine(MyDict);
}



