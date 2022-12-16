using System;

namespace project 
    {
        class Program
            {
        

        static void Main()
                    {
                        double a,b ;
                        int number = 0;
                       /* Console.WriteLine("Hello!\n\n"); 
                        Console.Write("Hello1!");
                        Console.Write("Hello2!");*/
                        //Console.Write(a+b);

                        Console.WriteLine("What you want:");
                        Console.WriteLine("1.Addition");
                        Console.WriteLine("2.Subtraction");      
                        Console.WriteLine("3.Multiplication"); 
                        Console.WriteLine("4.Division");
                        number = Convert.ToInt16(Console.ReadLine());

                        Console.Write("First digit:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Second digit:");
                        b = Convert.ToDouble(Console.ReadLine());                       
                        
            //Console.ReadKey();
                            switch (number)
                                {
                                    case  1:
                                    Console.Write("Result:" + (a + b));
                                    break;
                                    case  2:
                                    Console.Write("Result:" + (a - b));
                                    break;
                                    case  3:
                                    Console.Write("Result:" + (a * b));
                                    break;
                                    case  4:
                                    Console.Write("Result:" + (a / b));
                                    break;
                                }
                        Console.ReadKey(); 
                    }
            }
    }
