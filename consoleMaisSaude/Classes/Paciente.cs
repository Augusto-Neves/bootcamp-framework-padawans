using System;

public class Paciente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Senha { get; set; }
    public int Idade { get; set; }
    public string Sexo { get; set; }
    public Paciente()
    {

    }
    public void imprimir()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Senha: " + Senha);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Sexo: " + Sexo);
    }

    public void cadastroPaciente(Paciente paciente)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Cadastro do paciente");
        Console.Write("Digite seu nome: ");
        paciente.Nome = Console.ReadLine();
        Console.Write("Digite seu email: ");
        paciente.Email = Console.ReadLine();
        Console.Write("Digite sua senha: ");
        paciente.Senha = int.Parse(Console.ReadLine());
        Console.Write("Digite sua idade: ");
        paciente.Idade = int.Parse(Console.ReadLine());
        Console.Write("Digite seu sexo: ");
        paciente.Sexo = Console.ReadLine();
    }

    public void loginPaciente(Paciente paciente)
    {
        bool logado = false;
        System.Console.WriteLine("Faça seu login");
        Console.Write("Digite seu email: ");
        string email = Console.ReadLine();
        System.Console.Write("Digite sua senha: ");
        int senha = int.Parse(Console.ReadLine());

        while (logado == false)
        {
            if (email == paciente.Email && senha == paciente.Senha)
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