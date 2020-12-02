using System;
using aulaPOOcelular.Classes;

namespace aulaPOOcelular
{
    class Program
    {
        static void Main(string[] args)
        {
            aluno aluno1 = new aluno();
            Console.WriteLine("digite o nome do aluno : ");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("digite o nome do curso : ");
            aluno1.curso = Console.ReadLine();

            Console.WriteLine("qual a idade do aluno : ");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("insisra o rg do aluno : ");
            aluno1.rg = Console.ReadLine();

            Console.WriteLine("o aluno é bolsista ? (S/N)");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "s"){
                aluno1.bolsista = true;
            } else if (resposta.ToLower() == "n"){
                aluno1.bolsista = false;
            }

            Console.WriteLine("insira a media do aluno: ");
            aluno1.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("insira o valor da mensalidade : ");
            aluno1.valorDaMensalidade = float.Parse(Console.ReadLine());

            // Console.WriteLine(aluno1);

            Console.WriteLine("nome do aluno :" , aluno1.nome);
            Console.WriteLine("idade do aluno :" , aluno1.idade);
            Console.WriteLine("rg do aluno :" , aluno1.rg);
            Console.WriteLine("curso : " , aluno1.curso);
            Console.WriteLine("o aluno é bolsista ?" ,aluno1.bolsista);
            Console.WriteLine("media final do aluno é :" , aluno1.mediaFinal);
            Console.WriteLine("o valor da mensalidade é :" ,aluno1.valorDaMensalidade);
        }
    }
}
