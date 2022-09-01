using System;
class Programa{

     public static void Main( string[] args){

        double altura ;
        double peso;
        double imc;

        Console.WriteLine("porfavor digite sua altura:");
        altura  = double.Parse(Console.ReadLine());

        Console.WriteLine("porfavor agora digite seu peso em Kg:");
        peso = double.Parse(Console.ReadLine());

        imc = peso  / (altura * altura );

        if(imc >= 18.5){
             Console.WriteLine("abixo do pesso");
             Console.ReadLine();
        }
        if(imc >= 18.6 && imc <= 25){
             Console.WriteLine("pesso ideal");
             Console.ReadLine();
        }
        if(imc >= 26 && imc  <= 30 ){
             Console.WriteLine("sobrepesso!");
             Console.ReadLine();
        }
        if(imc >= 31 && imc <= 40 ){
             Console.WriteLine("obisidae !!");
             Console.ReadLine();
        }
        if(imc >= 41){
             Console.WriteLine("obiside morbide!!!");
             Console.ReadLine();
        }

     }
}