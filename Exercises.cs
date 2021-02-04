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

    public void OddEvenNumber(int number){

        string str = "";

        if(number % 2 == 0){
            str = $"El numero {number} es par"; 

        }
        else{
            str = $"El numero {number} es impar";

        }

        Console.WriteLine(str);
    }

    public void EvaluateNumbers(int n1, int n2){

        string str = "";

        if(n1 > n2){
            str = $"{n1} es mayor que {n2}";

        }
        else{
            str = $"{n1} es menor que {n2}";

        }

        Console.WriteLine(str);
    }

    public void ReturnBooleanExpression(){

        string str = "";

        str =  $"La expresion es: {23 > 18}";

        Console.WriteLine(str);

    }

    public void ExchangeRate(float dolar){

        const float DOP_exchange = 58.40f;
        string str = $"{dolar} dolares es equivalente a {DOP_exchange * dolar} pesos dominicanos";
        
        Console.WriteLine(str);
    }

    public void CelsiusToFahrenheit(float celsius_grade){
        float result = 0.0f;
        string str = "";

        result = (celsius_grade * 9/5) + 32;
        str = $"{celsius_grade}C = {result}F";

        Console.WriteLine(str);
    }

    public void CalificationToLiteral(float[] califications){
        
        float prom = 0.0f;
        string str = "", literal = "";

        foreach(float element in califications){
            prom += element;
        }

        prom /= 4;

        if(prom >= 90){
            literal = "A";

        }else if(prom >= 80){
            literal = "B";

        }else if(prom >= 70){
            literal = "C";

        }else if(prom >= 60){
            literal = "D";

        }else{
            literal = "F";

        }

        str = $"Califiacion Final: {prom} Literal: {literal}";

        Console.WriteLine(str);

    }

    public void Subtraction(){

        string str = "";

        str = $"La resta entre {92345} y {67890} es: {92345 - 67890}";

        Console.WriteLine(str);

    }

    public void RestDivision(){

        string str = "";

        str = $"La modulo entre {301} y {3} es: {301 % 3}";

        Console.WriteLine(str);

    }

    public void ResultOperation(){

        string str = "";

        str = $"El resultado es: {(20 + 5)%6}";

        Console.WriteLine(str);
        
    }

    public void ResultOperation2(){

        string str = "";

        str = $"El resultado es: {20 + 10 / 5 * 2 - 7 % 1}";

        Console.WriteLine(str);
        
    }

    public void ResultOperation3(){

        short division = 0;
        string str = "";

        division = 3784 % 16;
        
        str = $"El resultado es: {division}";

        Console.WriteLine(str);
        
    }

    public void ResultOperation4(){

        int sum = 0;
        string str = "";

        sum = 285 + 1396;
        
        str = $"El resultado es: {sum}";

        Console.WriteLine(str);
        
    }

    public void ResultOperation5(){

        int sum = 0, n1 = 0, n2 = 0;
        string str = "";

        try
        {
            Console.Write("Escribe el primer numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Escribe el primer numero: ");
            n2 = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("No ha escrito valores numericos validos!!");
        }

        sum = n1 + n2;
        
        str = $"El resultado es: {sum}";

        Console.WriteLine(str);
        
    }


}
