using System;

class Exercises
{
    
public void WriteWelcome(){

    string name = "", str = "";

    Console.WriteLine("Escribeme tu nombre: ");

    name = Console.ReadLine();
    str = $"\nBienvenido {name}!!";

    Console.WriteLine(str);
}

public static void OddEvenNumber(int number){

    string str = "";

    if(number % 2 == 0){
        str = $"El numero {number} es par"; 

    }
    else{
        str = $"El numero {number} es impar";

    }

    Console.WriteLine(str);
}

public static void EvaluateNumbers(int n1, int n2){

    string str = "";

    if(n1 > n2){
        str = $"{n1} es mayor que {n2}";

    }
    else{
        str = $"{n1} es menor que {n2}";

    }

    Console.WriteLine(str);
}

public static void ReturnBooleanExpression(){

    string str = "";

    str =  $"La expresion es: {23 > 18}";
    Console.WriteLine(str);

}
    
}
