using System ;
namespace aulaPOOcelular.Classes 
{
    public class aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public float mediaFinal;
        public float valorDaMensalidade;

        public void VerMediaFinal(float media){
            Console.WriteLine($"A média do aluno é: {media}");
        }

        public void VerMensalidade(bool tembolsa , float mensalidade ){
            if (tembolsa== true ){
                Console.WriteLine("esse aluno tem bolsa");
                Console.WriteLine($"mensalidade sem desconto : {mensalidade}");

                Console.WriteLine($"mensalidade com desconto : {0.7 * mensalidade }");
            }
            else {
                Console.WriteLine($"esse aluno não é bolsista");
                Console.WriteLine($"mensalidade : {mensalidade}");

            }
        }
        
    }
}