using System;


namespace ConsoleApps
{
    class Program
    {   
        static dynamic objExercise = new Exercises();

        static void Main(string[] args){
                
            objExercise.WriteWelcome(); //Programa #1
            objExercise.OddEvenNumber(number: 12); //Programa #2
            objExercise.EvaluateNumbers(n2: 65, n1: 45); //Programa #3
            objExercise.ReturnBooleanExpression(); //Programa #4
        }

        
    }
}
