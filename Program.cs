using System;


namespace ConsoleApps
{
    class Program
    {   
        static void WriteWelcome(){

            string name = "", str = "";

            Console.WriteLine("Escribeme tu nombre: ");

            name = Console.ReadLine();
            str = $"\nBienvenido {name}!!";

            Console.WriteLine(str);
        }

        static void OddEvenNumber(float number){

            string str = "";

            if(number % 2 == 0){
                str = $"El numero {number} es par"; 

            }else{
                str = $"El numero {number} es impar";

            }

            Console.WriteLine(str);
        }


        static void Main(string[] args){
            //WriteWelcome(); //Programa #1
            //OddEvenNumber(number: 12.0f); //Programa #2

        }

        
    }
}
