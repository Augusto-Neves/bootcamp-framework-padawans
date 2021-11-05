
using System;

namespace Saude
{
    class Profissional
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Senha { get; set; }
        public string Ubs { get; set; }
        public string Funcao { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }

        public Profissional()
        {

        }
        public void imprimir()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Senha: " + Senha);
            Console.WriteLine("Ubs: " + Ubs);
            Console.WriteLine("Funcao: " + Funcao);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Sexo: " + Sexo);
        }
        public void cadastrarProfissional(Profissional profissional)
        {
           System.Console.WriteLine();
           System.Console.WriteLine("Cadastro profissional de saúde !!");
           System.Console.Write("Digite o nome do profissional: ");
           profissional.Nome = Console.ReadLine();
           System.Console.Write("Digite o email do profissional: ");
           profissional.Email = Console.ReadLine();
           System.Console.Write("Digite a senha do profissional: ");
           profissional.Senha = int.Parse(Console.ReadLine());
           System.Console.Write("Digite a ubs do profissional: ");   
           profissional.Ubs = Console.ReadLine();
           System.Console.Write("Digite a funcao do profissional: ");
           profissional.Funcao = Console.ReadLine();
           System.Console.Write("Digite a idade do profissional: ");
           profissional.Idade = int.Parse(Console.ReadLine());
           System.Console.Write("Digite o sexo do profissional: ");
           profissional.Sexo = char.Parse(Console.ReadLine());
        }

        public void loginProfissional(Profissional profissional)
        {
        bool logado = false;
        System.Console.WriteLine("Faça seu login");
        Console.Write("Digite seu email: ");
        string email = Console.ReadLine();
        System.Console.Write("Digite sua senha: ");
        int senha = int.Parse(Console.ReadLine());

        while(logado == false)
        {
            if(email == profissional.Email && senha == profissional.Senha)
            {
                System.Console.WriteLine("Login realizado com sucesso");
                logado = true;
            }
            else
            {
                System.Console.WriteLine("Email ou senha incorretos");
                System.Console.WriteLine("Tente novamente");
                System.Console.Write("Digite seu email: ");
                email = Console.ReadLine();
                System.Console.Write("Digite sua senha: ");
                senha = int.Parse(Console.ReadLine());
            }
           
          } 
           System.Console.WriteLine();
           System.Console.WriteLine("Bem vindo ao Mais Saúde"); 
         }
    }
}
