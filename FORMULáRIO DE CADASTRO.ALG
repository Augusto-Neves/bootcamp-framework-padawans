Algoritmo "Formulário de Cadastro"
// Disciplina   : Algoritmo e Estrutura de Dados
// Professor   : Chiga
// Descrição   : Formulario de cadastro para funcionarios da UBS
// Autor(a)    : Adriano, Amanda, Augusto, Cauê, Taynara e Vinícius
// Data atual  : 26/10/2021


tipo
ficha=registro
nome, cargo, matricula, ubs: caracter
idade: inteiro
fimregistro



   funcao EhProfissional(tipoUsuario : inteiro ): caracter
   Var
   // Seção de Declarações das variáveis
   valor : caracter
   inicio
      se(tipoUsuario = 1) entao
         retorne("Você é profissional da Sáude!")
      senao
         retorne("Você é paciente!")
      fimse
   fimfuncao


   procedimento executa()
   Var
   // Seção de Declarações das variáveis
   user: inteiro
   valor : caracter
   inicio
      escreval ("Você é um profissional da área de saúde? 1-sim / 2-nao")
      leia(user)
      valor <- EhProfissional(user)
      escreval(valor)
   fimprocedimento


procedimento CriandoLogin

   inicio
      escreval("Olá, seja bem-vindo(a), por favor, digite seu login:")
      leia (login)
      escreval("Digite sua senha utilizando apenas numeros: ")
      leia (senha)
      limpatela
      executa()


fimprocedimento




procedimento lerCadastro

Var
   funcionario: ficha
   verifica: inteiro

   inicio
         verifica<-2
         limpatela
         enquanto verifica =2 faca
         escreval("Formulário de Cadastro Funcionários da UBS")
         escreva("Informe seu nome: ")
         leia(funcionario.nome)
         //escreva("Informe sua idade: ")
         //leia(funcionario.idade)
         escreva("Informe sua matricula: ")
         leia(funcionario.matricula)
         escreva("Informe seu cargo: ")
         leia(funcionario.cargo)
         escreva("Informe sua unidade de ubs: ")
         leia(funcionario.ubs)
         
         limpatela

         escreval("Dados do usuário cadastrado")

            escreval("Nome: " +funcionario.nome)
            //escreva("Idade: " +funcionario.idade)
            escreval("Matricula: " +funcionario.matricula)
            escreval("Cargo: " +funcionario.cargo)
            escreval("ID UBS: " +funcionario.ubs)

            escreval("Os Dados estão corretos? (1|2)")
            escreval("1 - Sim")
            escreval("2 - Não")
            leia(verifica)
            limpatela
         fimenquanto

         escreval("Cadastro realizado com sucesso!!")
         
fimprocedimento


procedimento saibamais
Var
opcao: caracter

Inicio
   limpatela
   repita
   escreval ("Escolha uma opção: ")
   escreval("                 ") //utilizado para quebrar linha
   escreval("1 - Métodos Contraceptivos Oferecidos Pelo SUS")
   escreval("2 - Planejamento Familiar")
   escreval("3 - Práticas Educativas Em Saúde Sexual E Saúde Reprodutiva")
   escreval("4 - Voltar")

   leia (opcao)
   ate opcao =4
   limpatela
   escolha opcao

     caso "1"
     escreval ("Levando em conta a realidade econômica e social brasileira, considera-se que os métodos mais utilizados são aqueles disponibilizados pelo SUS. São eles: preservativo masculino e feminino, pílula combinada, anticoncepcional injetável mensal e trimestral, dispositivo intrauterino de cobre, diafragma, anticoncepção de emergência e minipílula")
     caso "2"
     escreval ("Planejamento Familiar é um conjunto de ações que auxiliam homens e mulheres a planejar a chegada dos filhos, e também a prevenir gravidez não planejada. Todas as pessoas possuem o direito de decidir se terão ou não filhos, e o Estado tem o dever de oferecer acesso a recursos informativos, educacionais, técnicos e científicos que assegurem a prática do planejamento familiar")
     caso "3"
     escreval("Para se obter bom resultado, no que se refere à saúde sexual e à saúde reprodutiva, é importante considerar o conhecimento e experiência dos participantes, permitindo a troca de ideias sobre sexualidade, reprodução, relacionamento humano e sobre os fatores socioeconômicos e culturais que influenciam nessas questões. Essa metodologia estimula a pessoa a construir um processo decisório autônomo e centrado em seus interesses")
     caso "4"
     outrocaso
     escreval("Opção inválida")
     fimescolha


fimprocedimento

Var
sair, login, usuario: caracter
opcao: inteiro
senha: real

Inicio
          CriandoLogin
          sair <- "falso"

          repita
          escreval("1| Cadastrar ")
          escreval("2| Saiba Mais")
          escreval("0| Sair")
          leia(opcao)
          escolha(opcao)
          caso=1
          lerCadastro
          caso=2
          saibamais
          caso=0
          sair<-"verdadeiro"
          outrocaso
          escreval("Opção inválida")
         
         fimescolha
         ate(sair = "verdadeiro")







Fimalgoritmo