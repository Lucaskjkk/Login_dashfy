using System;
using BackEnd.Models;

namespace BackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Login login = new Login("Teste@teste.com", "Teste1234");

            
            Console.Write("Digite seu email: ");
            string emailInput = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senhaInput = Console.ReadLine();

            
            login.EntradaDaConta(emailInput, senhaInput);
        }
    }
}
