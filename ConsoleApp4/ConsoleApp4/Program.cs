using System;
using Reverse;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)

		{
			Employees e = new Employees();
			e.AddEmp();
			Console.ReadLine();
		}
	}
}

	////		int[] a = { 1, 2, 3, 4, 5 };
	////		int[] b = { 1, 5, 10, 2 };

	////		for (int j = 0; j < a.Length; j++)
	////			try
	////			{

	////				Console.WriteLine("Numerator " + a[j]);
	////				Console.WriteLine("Denominator: " + b[j]);
	////				Console.WriteLine("Quotient: " + a[j] / b[j]);
	////			}
	////			catch (DivideByZeroException ex)
	////			{
	////				throw new Exception(ex.Message); 
	////				//Console.WriteLine(ex.Message);
	////			}
	////			catch (IndexOutOfRangeException IO)
	////			{
	////				throw new Exception(IO.Message);
 ////                   //Console.WriteLine(IO.Message);
	////			}
	////		  catch (FormatException fe)
 ////               {
 ////                   Console.WriteLine(fe.Message);
					
 ////               }
	////		Console.ReadKey();

		
	////	}
	////}
	
//}

	////            int i, j;
	////            int[,] arr1 = new int[3, 3];
	////            Console.
//	Program p = new Program();
//           int a=p.Add(1, 2, 3);
//           double b= p.Add(1.1, 2.2, 3.3);
//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.ReadLine();
//        }
//        public int Add(int a, int b, int c)
//        {
//            return a + b + c;
//        }
//        public double Add(double a, double b, double c)
//        {
//            return a + b + c;
//        }
//    }
//}



	// Main Method
	
		// Here, number is greater than divisor
	


////            int i, j;
////            int[,] arr1 = new int[3, 3];
////            Console.Write("Input elements \n");
////            for (i = 0; i < 3; i++)
////            {
////                for (j = 0; j < 3; j++)
////                {
////                    Console.Write("elements are ", i, j);
////                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
////                }
////            }

////            Console.Write("The matrix is");
////            for (i = 0; i < 3; i++)
////            {
////                Console.Write("\n");
////                for (j = 0; j < 3; j++)
////                    Console.Write("{0}\t", arr1[i, j]);
////            }
////            Console.ReadLine();
////        }
////    }
////}
////////        {
////////            int large = 0;
////////            int small = 0;
////            int[] a = new int[100];
////            int i, n,j,temp, sum = 0;
////            n = Convert.ToInt32(Console.ReadLine());
////            Console.WriteLine("Enter no of values {0}", n);
////            for (i = 0; i < n; i++)
////            {
////                Console.WriteLine("value {0}",i);
////                a[i] = Convert.ToInt32(Console.ReadLine());
////            }
////            for (i = 0; i < n; i++)
////            {
////                sum += a[i];
////            }
////            Console.Write("Sum {0}", sum);
////            large = a[0];
////            small = a[0];
////            for (i = 1; i < n; i++)
////            {
////                if (large < a[i])
////                    large = a[i];
////                else if (a[i]<small)
////                    small = a[i];
////            }
////            Console.WriteLine("largest {0}",large);
////            Console.WriteLine("small {0}",small);
////            Array.Sort(a);
////            Array.Reverse(a);
////            Console.WriteLine("second highest {0}",a[1]);
////            for (i = 0; i < n; i++)
////            {
////                for (j = i + 1; j < n; j++)
////                {
////                    if (a[i] > a[j])
////                    {
////                        temp = a[i];
////                        a[i] = a[j];
////                        a[j] = temp;
////                    }
////                }
////            }
////            Console.WriteLine("second smallest {0}",a[1]);
////                Console.ReadLine();
////        }
////    }
////}

//public static void Main()
