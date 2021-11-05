using System;

namespace Saude
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente();
            Profissional profissional = new Profissional();
            Menu menu = new Menu();
            SaibaMais saibaMais = new SaibaMais();


            System.Console.WriteLine("Voce é um profissional da saúde? 1-Sim 2-Não");
            int opcao = int.Parse(Console.ReadLine());
            menu.ehProfissional(opcao);


            if (opcao == 1)
            {
                int verifica = 0;
                do
                {
                    profissional.cadastrarProfissional(profissional);
                    System.Console.WriteLine("Seus dados: ");
                    profissional.imprimir();
                    System.Console.WriteLine("Estão corretos 1-sim 2-não");
                    verifica = int.Parse(Console.ReadLine());

                } while (verifica == 2);

            }
            else if (opcao == 2)
            {
                int verifica = 0;
                do
                {
                    paciente.cadastroPaciente(paciente);
                    System.Console.WriteLine("Seus dados: ");
                    paciente.imprimir();
                    System.Console.WriteLine("Estão corretos 1-Sim 2-não");
                    verifica = int.Parse(Console.ReadLine());

                } while (verifica == 2);
            }

            System.Console.WriteLine("Cadastro realizado com sucesso !!");
            Console.Clear();
            
            if(opcao == 1){
                profissional.loginProfissional(profissional);
            }else{
                paciente.loginPaciente(paciente);
            }
            saibaMais.saibaMais();  
        } 
    }
}



