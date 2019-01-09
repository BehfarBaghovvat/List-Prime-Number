

namespace List_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number, Index, Result;

            System.Console.WriteLine
                ("          ======================LIST PRIME NUMBERS======================");

            System.Console.WriteLine();

            System.Console.Write("Please Enter Number: ");

            Number=System.Convert.ToInt32
                ( System.Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            Index = 0;            

            for (int i = 2; i <= Number; i++)
            {
                Index = 0;

                for (int y = 1; y <= i; y++)
                {
                    
                    Result = i % y;

                    if (Result==0)
                    {
                        
                        Index ++;                        

                    }
        
                }

                if (Index <= 2)
                {

                    System.Console.WriteLine("The number {0} is PRIME NUMBER:  ", i);

                }
                
            }


            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.Write("Press [ENTER] To Exit...");

            System.Console.ReadLine();



        }
    }
}
