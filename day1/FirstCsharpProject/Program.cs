


// Data Types in C# 
// Primitives

/*




*/



//type name value 
//! Numbers 
int age = 35;
float rate = 1.32f;
double grade = 3.25;
Console.WriteLine(age);
Console.WriteLine(rate);
Console.WriteLine(grade);
//! Char vs String
// Char is primitive type (1 character only single quote'')
// String is complex type, array of chars and double quotes ""
char tag = 'C'; 
Console.WriteLine($"My Programme Langugae is {tag}");

//Boolean 
bool isValid = true ;
bool hasCovid = false;
// ! Bytes 
byte cOne = 0;
byte cTwo =255;


// Complex Types 

//! String 

string FirstName = "jhon";
Console.WriteLine($"My first Name is {FirstName} I am {age} years old .");


//! Arrays 

/*


*/
int[] numbers = new int[5] {1,2,3,4,5};
// numbers = {1,2,3,4,5};
// numbers[0]= 1;
// numbers[1]= 2;
// numbers[2]= 3;
// numbers[3]= 4;
// numbers[4]= 5;
Console.WriteLine(numbers);
Console.WriteLine(numbers.Length);

//! Lists 

// List<int> gradeList = new List<int>();
// gradeList.Add(22);
// gradeList.add(2);


List<string> NameList = new List<string>() {"james","Alice", "Jhon","Sarah"};
Console.WriteLine(NameList.Count());
NameList.Add("Max");
Console.WriteLine(NameList.Count());
NameList.Remove("John");
Console.WriteLine(NameList.Contains("Jhon"));
NameList.IndexOf("Alice");
NameList.Contains("John");
NameList.Count();


// Dictionnary


Dictionary<int,string> MyDict = new Dictionary<int, string>() {
    {1,"Jhon"},{2,"James"}
};

//! Enums 
// System.Console.WriteLine(OrderStatus.Canceled);
// var MyOrder = OrderStatus.Pending;
// System.Console.WriteLine($"My order statuts is {MyOrder}");
// public enum OrderStatus{
//     Pending = 1,
//     Canceled = 0 ,
//     Delivered = 2
// }


// if (age > 18)
// {
//     System.Console.WriteLine("Welcome");

// }
// else if (age == 35)
// {
//     System.Console.WriteLine("Please Go home");
// }
// else
// {
// System.Console.WriteLine("Go Home !!!!");
// }


 //! loops 
// for (int i =0 ; i< numbers.Length; i++)
// {
// System.Console.WriteLine(numbers[i]);
// }

//! Casting 
//Implicit Casting 
int IntValue = 3;
double DoubleValue = IntValue;
byte ByteValue = 255;
int ByteToInt = ByteValue

//explicit casting 
int intValue = 3;
double doubleFromInt = (int)intValue;


// if(intValue>255)
// {
//     byte byteFromInt =255; 
// }
// else
// {
//     byte byteFromInt = (byte)intValue
// }


// System.Console.WriteLine($"The Integer Value is {IntValue}\n The Double Value is {DoubleValue}");



//! Functions 

// static void SayHi()
// {
//     System.Console.WriteLine("Hi From Function !!");
// }
// SayHi();


static int Add(int a, int b)
{
    return a+b;
}
System.Console.WriteLine(Add(5,8));


static string SayHello(string name)
{
    return $"Hey {name} !";

}
System.Console.WriteLine(SayHello("Sale7"));