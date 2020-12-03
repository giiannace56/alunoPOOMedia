using System;
using aulaPOOcelular.classes;

namespace aulaPOOcelular
{
    class Program
    {
        static void Main(string[] args)
        {
           celular celular1 = new celular();
            string escolha;

                do
                {
                    Console.WriteLine("O Celular está ligado?");
                    escolha = Console.ReadLine();

                    Console.WriteLine("Deseja liga-lo?");
                    escolha = Console.ReadLine();

                    if(escolha.ToLower() == "n"){
                        celular1.ligado = false;
                        Console.WriteLine(celular1.ligado);
                        Console.WriteLine("fim programa");

                     }else if(escolha.ToLower() == "s" ){
                    celular1.ligado = true;

                    Console.WriteLine("Digite a cor do celular: ");
                    celular1.cor = Console.ReadLine();

                    Console.WriteLine("Digite o modelo do celular: ");
                    celular1.modelo = Console.ReadLine();

                    Console.WriteLine("Digite o tamanho do celular: ");
                    celular1.tamanho = Console.ReadLine();

                    Console.WriteLine("a cor do celular é :" + celular1.cor);
                    Console.WriteLine("o modelo do celular é:" + celular1.modelo);
                    Console.WriteLine("o tamanho do celular é : " + celular1.tamanho);
                    Console.WriteLine("status do celular é :" + celular1.ligado);
                    break;
                    }
                    
                    }while (escolha.ToUpper() == "s");
        }
    }
}


