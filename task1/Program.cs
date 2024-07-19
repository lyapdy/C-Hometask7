    
    void Main() 
    { 
        Console.Write("Введите значение M: "); 
        int M = int.Parse(Console.ReadLine()); 
 
        Console.Write("Введите значение N: "); 
        int N = int.Parse(Console.ReadLine()); 
 
        PrintPureNumbers(M, N); 
    } 
 
    static void PrintPureNumbers(int curVar, int N) 
    { 
        if (curVar <= N) 
        { 
            Console.Write(curVar + " "); 
            PrintPureNumbers(curVar + 1, N); 
        } 
    } 

    Main();
