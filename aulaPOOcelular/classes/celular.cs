using System;
namespace aulaPOOcelular.classes
{
    public class celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

       
        public void Ligar(bool ligado){
            if(ligado == true){
                Console.WriteLine("O celular está ligado");
            }else{
                Console.WriteLine("O celular está desligado!");
            }
        }
         public void Mensagem(){
            Console.Write("Deseja enviar alguma mensagem?");
            string mensagem = Console.ReadLine();

            if(mensagem.ToUpper() == "s"){
                    Console.Write("Escreva a mensagem");
                    mensagem = Console.ReadLine();

                    Console.WriteLine($"Sua mensagem {mensagem} foi enviada!");
            }
        }
    }
}