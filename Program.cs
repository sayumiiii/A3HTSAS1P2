/*
 * purpose: project 2 part 2
 * 
 * revision history: 
 *      sayumi Amarasinghe = 50%
 *      Hafza Tariq        = 50%
 * 
 * date: 3/2021
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3HTSAS1P2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1,num2,num3
            int n1,n2,n3=0;
            string option = "";
            bool i = true;

            while (i)
            {
                Console.WriteLine("Enter number 1: ");
                num1 = Console.ReadLine();
                Console.WriteLine("Enter number 2: ");
                num2 = Console.ReadLine();
                Console.WriteLine("Enter number 3: ");
                num3 = Console.ReadLine();

                try
                {
                    n1=int.Parse(num1);
                    n2=int.Parse(num2);
                    n3=int.Parse(num3);
                    i=false;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Enter only numerics");                    
                    i = true;
                }

                catch (OverflowException)
                {
                    Console.WriteLine("Enter only one input ");
                    i = true;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cant devide the number entered by zero.. plase enter another number");
                    i = true;
                }
            }

            i=true;
            while(i){
                Console.WriteLine("a. Calculate working percentage ");
                Console.WriteLine("b. multiply");
                Console.WriteLine("c. add ");
                Console.WriteLine("Choose an option: ");
                option=Console.ReadLine();

                if (option == "a"){                           
                    Console.WriteLine("First number/ second number multiplied by 100: " + (num1 / num2) * 100 + "%");                            
                }
                else if (option== "b"){
                    Console.WriteLine("result of multiplying all numbers:" + num1*num2*num3)
                }
                else if (option== "c"){
                    Console.WriteLine("Result of addition os all numbers" + num1+num2+num3);                     
                }
                else{
                    Console.WriteLine("please enter only a, b, or c ");
                }
            }
        }
    }
}
