
// First Function

static void PrintNumbers()
{
    for(int i= 0 ; i< 256 ; i++ ){
        System.Console.WriteLine(i);
    }
}

// PrintNumbers();


// Second Function


static void PrintOdds()
{
    for(int i =0  ; i<256 ; i++ ){
        if (i % 2 != 0 ){

        System.Console.WriteLine(i);
        }
    }
}

// PrintOdds();

// Third Function

static void PrintSum()
{
    int sum = 0;
    for(int i= 0 ; i< 256 ; i++ ){
        System.Console.WriteLine($"this is i : {i}");
        sum += i;
        System.Console.WriteLine($"this is the sum : {sum}");
    }
}
// PrintSum();





// fourth function




static void LoopArray(int[] numbers)
{

int[] StrArray = new int[5];

for (int i= 0 ; i < numbers.Length ; i++ ){
    System.Console.WriteLine("Array length",numbers.Length);
    Console.WriteLine(numbers[i]);
}

}
int[] StrArray2 = {1,2,3,4,6};

// LoopArray(StrArray2);


// Find Max 


static void FindMax(int[] numbers)
{
    int Max = 0;
    for(int i = 0 ; i<numbers.Length; i++ ){
    if(numbers[i] > Max ){
        Max = numbers[i];
    }

    }
System.Console.WriteLine(Max);


}


// FindMax(StrArray2);



// Get Average 

static void GetAverage(int[] numbers)
{
    int Sum = 0;


    for (int i = 0; i< numbers.Length ; i++ ){
        Sum = Sum + numbers[i] ;
    }
    System.Console.WriteLine($"Sum is : {Sum}");
    int Avg = Sum/numbers.Length;
    System.Console.WriteLine($"Average : {Avg}");

}

// GetAverage(StrArray2);

static void OddList()
{
    List<int> numbers = new List<int>();
    for (int i = 0 ; i <255; i++ ){

    numbers.Add(i);

    }
    Console.WriteLine(numbers);
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
}


// OddList();

static void GreaterThanY(List<int> numbers, int y)
{
    for (int i=0; i< numbers.Count; i++){
        // System.Console.WriteLine($"This is count : {numbers.Count}");
        // System.Console.WriteLine($"This number[i]{numbers[i]}");
        // System.Console.WriteLine(y);
        if(numbers[i]> y){

            System.Console.WriteLine(numbers[i]);
        }
    }
    // Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
}
List<int> NameList = new List<int>() {1,5,-9,4};

// GreaterThanY(NameList,3);


static void SquareArrayValues(List<int> numbers)
{
for ( int i = 0 ;i<numbers.Count ; i++){
    int multiplied = numbers[i]*numbers[i];
    System.Console.WriteLine($"The Magic is here : {multiplied}");
}
}

// SquareArrayValues(NameList);



static void EliminateNegatives(List<int> numbers)
{
for(int i = 0 ; i<numbers.Count; i++){
    if(numbers[i]< 0){
        numbers[i] = 0 ;
            System.Console.WriteLine($"this is my numbers {numbers[i]}");
    }else
    {
        System.Console.WriteLine($"Stays The same {numbers[i]}");
    }

    }
}
EliminateNegatives(NameList);



