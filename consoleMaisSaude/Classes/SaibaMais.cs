using System;

public class SaibaMais
{
    public void saibaMais()
    {
       
        int escolha = 0;

        do{

            System.Console.WriteLine("Escolha uma opção: ");
            System.Console.WriteLine("1 - Métodos contraceptivos oferecidos pelo sus");
            System.Console.WriteLine("2 - Planejamento familiar");
            System.Console.WriteLine("3 - Práticas educativas em saúde sexual e saúde reprodutiva");
            System.Console.WriteLine("4 - voltar");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    System.Console.WriteLine("Levando em conta a realidade econômica e social brasileira, considera-se que os métodos mais utilizados são aqueles disponibilizados pelo SUS. São eles: preservativo masculino e feminino, pílula combinada, anticoncepcional injetável mensal e trimestral, dispositivo intrauterino de cobre, diafragma, anticoncepção de emergência e minipílula");
                    break;
                case 2:
                    System.Console.WriteLine("Planejamento Familiar é um conjunto de ações que auxiliam homens e mulheres a planejar a chegada dos filhos, e também a prevenir gravidez não planejada. Todas as pessoas possuem o direito de decidir se terão ou não filhos, e o Estado tem o dever de oferecer acesso a recursos informativos, educacionais, técnicos e científicos que assegurem a prática do planejamento familiar");
                    break;
                case 3:
                    System.Console.WriteLine("Para se obter bom resultado, no que se refere à saúde sexual e à saúde reprodutiva, é importante considerar o conhecimento e experiência dos participantes, permitindo a troca de ideias sobre sexualidade, reprodução, relacionamento humano e sobre os fatores socioeconômicos e culturais que influenciam nessas questões. Essa metodologia estimula a pessoa a construir um processo decisório autônomo e centrado em seus interesses");
                    break;
                case 4:
                    System.Console.WriteLine("Voltando ao menu");
                    break;
            }
        }while (escolha == 4);

    }
}




