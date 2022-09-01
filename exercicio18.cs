using System;
class Programa{

     public static void Main( string[] args){

        double seguemento1;
        double seguemento2;
        double seguemento3;

        Console.WriteLine("porfavor digite o seu primeiro seguemnto:");
        seguemento1 = double.Parse(Console.ReadLine());

        Console.WriteLine("porfavor digite o seu segundo seguemnto:");
        seguemento2 = double.Parse(Console.ReadLine());

        Console.WriteLine("porfavor digite o seu terceiro seguemnto:");
        seguemento3 = double.Parse(Console.ReadLine());

        //caso seja um triangulo 
        if(seguemento1 + seguemento2 > seguemento3 && seguemento2 + seguemento1 > seguemento3  ){
            Console.WriteLine("voce podera ter um triangulo");
             Console.ReadLine();

             // segunda parte 
             if(seguemento1==seguemento2 && seguemento2==seguemento3){
                Console.WriteLine("ele é EQUILÁTERO");
         }if(seguemento1==seguemento2 && seguemento2!=seguemento3||(seguemento2==seguemento3 && seguemento3!=seguemento1)||(seguemento3==seguemento1&seguemento1!=seguemento2)){
                Console.WriteLine("ele é ISÓSCELES");
         } if(seguemento1!=seguemento2 && seguemento2!=seguemento3 && seguemento3!=seguemento1){
             Console.WriteLine("ele é ESCALENO");
        }

        //se nao for um triangulo 
        else{
             Console.WriteLine("nao e posivel formar um triangulo!");
             Console.ReadLine();
        }
     }
     }
}