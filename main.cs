using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Estruturas de Repetição");
      Console.WriteLine("==========================\r\n Para ...");
      for (int i = 0;i<=10;i++)
            {
              int num= 7*i;
        Console.WriteLine("7 x " + i + " = " +num) ; 
      }
      Console.WriteLine("==========================\r\n Enquanto ...");
      
      int n = 0;
      while ( n <= 10)
      {  //n++;
        int num = 5*n;
      
        Console.WriteLine("5 x " + n + " = " +num);
        n= n+1;
      }
            Console.WriteLine("==========================\r\n Faça ... Enquanto ");
      int f = 0;
          do
          {
            int num = 2*f;
            Console.WriteLine(  "2 x " + f + " = " +num);
            f= f+2;
          }
          while( f<=10);
      

  }
}