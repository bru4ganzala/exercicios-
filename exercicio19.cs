using System;
class Programa{

     public static void Main( string[] args){

        double valorImovel;
        double salario;
        int anos;
        int  parcelas;
        double parcleasMensal;

        // leitura dos dados 
        Console.WriteLine("porfavor digite o valor do seu imovel:");
        valorImovel = double.Parse(Console.ReadLine());

        Console.WriteLine("digite o valor de seu salario:");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("coloque a quantidae de parecelas:");
        anos = int.Parse(Console.ReadLine());

        parcelas = anos * 12;
        parcleasMensal = valorImovel / parcelas;

        if(parcleasMensal > (salario * 0.3 )){
            Console.WriteLine("seu emprestimo foi negado!");
            Console.ReadLine();
        }
        else{
              Console.WriteLine("seu emprestimo foi liberado!");
            Console.ReadLine();
        }
     }
}