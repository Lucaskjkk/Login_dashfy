using System;

namespace BackEnd.Models
{
    public class Login
    {
        private string email;
        private string senha;

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O email não pode ser nulo ou vazio.");
                }
                email = value;
            }
        }

        public string Senha
        {
            get { return senha; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A senha não pode ser nula ou vazia.");
                }
                senha = value;
            }
        }

        public Login() { }

        public Login(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public void EntradaDaConta(string email, string senha)
        {
            if (Email == email && Senha == senha)
            {
                Console.WriteLine("Parabéns, você entrou no sistema.");
            }
            else
            {
                Console.WriteLine("Login ou senha incorretos.");
            }
        }
    }
}
