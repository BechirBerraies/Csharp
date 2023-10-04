// RANDOM ARRAY 


int[] numArray = new int[10];





static void RandomArray(int[] numbers)
{
    
    Random rnd = new Random();
    int[] numArray = new int[10];
    int max = 0 ;
    
    for(int i = 0 ; i<numbers.Length;i++){
        int rand = rnd.Next(5,25);
        numbers[i] = rand ;
        System.Console.WriteLine(rand);
    }
    for (int j=0; j<numbers.Length-1; j++ ){
        if(numbers[j]> max)
        {
            max = numbers[j];
        }
    }
        int min = numbers[0] ;
    for (int h=0; h<numbers.Length-1; h++ ){
        if(numbers[h] < min)
        {
            min = numbers[h];
        }
    }
    System.Console.WriteLine($"Minimum : {min}");
    System.Console.WriteLine($"Maximum : {max}");
    System.Console.WriteLine(numbers);
}

// RandomArray(numArray);



// COIN FLIP 

static void TossCoin() 
{
    System.Console.WriteLine("Tossing a Coin!");
    Random rnd = new Random();
    int rand = rnd.Next(1,3);
    if(rand == 1){
        System.Console.WriteLine("Heads");
    }else
    {
        System.Console.WriteLine("Tails");
    }
    // System.Console.WriteLine(rand);
}

// TossCoin();


//NAMES 

static List<string> Names()
{
    List<string> names = new List<string>();
    names.Add("Bechir");
    names.Add("Aziz");
    names.Add("Amin");
    names.Add("Ali");
    names.Add("Fatma");
    for(int i = 0; i<names.Count ;i++ )
    {
        if(names[i].Length > 5  ){
        System.Console.WriteLine($"This name is longer than 5 : {names[i]}");
        }
    }

    return names;
}

Names();