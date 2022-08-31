using System;
class Programa{

     public static void Main( string[] args){

        char nome;
        double salario;
        int tempodeTrabalho;
        double novoSalario;

        Console.WriteLine("porfavor digite seu nome :");
        nome = char.Parse(Console.ReadLine());

        Console.WriteLine("porfavor digite seu salario  :");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("porfavor digite seu tempo de trabalho :");
         tempodeTrabalho = int.Parse(Console.ReadLine());


        // primeiro decobrir o tempo de trabalho 
        // se for menor ou = 3 
        if(tempodeTrabalho == 3 ){
            novoSalario = salario * 0.03 + salario;
            Console.WriteLine("seu novo salario sera : ");
        }

         // se for menor ou >=4 ou <=10
        if(tempodeTrabalho >= 4  || tempodeTrabalho <=10){
        novoSalario = salario * 0.125 + salario;
        Console.WriteLine("seu novo salario sera : ");
        }

        // se for menor ou >=11
        if(tempodeTrabalho >= 11){
        novoSalario = salario * 0.2 + salario;
        Console.WriteLine("seu novo salario sera : ");
        }



    }
}