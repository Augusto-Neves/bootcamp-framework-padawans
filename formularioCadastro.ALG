Algoritmo "Formul�rio de Cadastro"
// Disciplina   : Algoritmo e Estrutura de Dados
// Professor   : Chiga
// Descri��o   : Formulario de cadastro para funcionarios da UBS
// Autor(a)    : Adriano, Amanda, Augusto, Cau�, Taynara e Vin�cius
// Data atual  : 26/10/2021


tipo
ficha=registro
nome, cargo, matricula, ubs: caracter
idade: inteiro
fimregistro



   funcao EhProfissional(tipoUsuario : inteiro ): caracter
   Var
   // Se��o de Declara��es das vari�veis
   valor : caracter
   inicio
      se(tipoUsuario = 1) entao
         retorne("Voc� � profissional da S�ude!")
      senao
         retorne("Voc� � paciente!")
      fimse
   fimfuncao


   procedimento executa()
   Var
   // Se��o de Declara��es das vari�veis
   user: inteiro
   valor : caracter
   inicio
      escreval ("Voc� � um profissional da �rea de sa�de? 1-sim / 2-nao")
      leia(user)
      valor <- EhProfissional(user)
      escreval(valor)
   fimprocedimento


procedimento CriandoLogin

   inicio
      escreval("Ol�, seja bem-vindo(a), por favor, digite seu login:")
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
         escreval("Formul�rio de Cadastro Funcion�rios da UBS")
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

         escreval("Dados do usu�rio cadastrado")

            escreval("Nome: " +funcionario.nome)
            //escreva("Idade: " +funcionario.idade)
            escreval("Matricula: " +funcionario.matricula)
            escreval("Cargo: " +funcionario.cargo)
            escreval("ID UBS: " +funcionario.ubs)

            escreval("Os Dados est�o corretos? (1|2)")
            escreval("1 - Sim")
            escreval("2 - N�o")
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
   escreval ("Escolha uma op��o: ")
   escreval("                 ") //utilizado para quebrar linha
   escreval("1 - M�todos Contraceptivos Oferecidos Pelo SUS")
   escreval("2 - Planejamento Familiar")
   escreval("3 - Pr�ticas Educativas Em Sa�de Sexual E Sa�de Reprodutiva")
   escreval("4 - Voltar")

   leia (opcao)
   ate opcao =4
   limpatela
   escolha opcao

     caso "1"
     escreval ("Levando em conta a realidade econ�mica e social brasileira, considera-se que os m�todos mais utilizados s�o aqueles disponibilizados pelo SUS. S�o eles: preservativo masculino e feminino, p�lula combinada, anticoncepcional injet�vel mensal e trimestral, dispositivo intrauterino de cobre, diafragma, anticoncep��o de emerg�ncia e minip�lula")
     caso "2"
     escreval ("Planejamento Familiar � um conjunto de a��es que auxiliam homens e mulheres a planejar a chegada dos filhos, e tamb�m a prevenir gravidez n�o planejada. Todas as pessoas possuem o direito de decidir se ter�o ou n�o filhos, e o Estado tem o dever de oferecer acesso a recursos informativos, educacionais, t�cnicos e cient�ficos que assegurem a pr�tica do planejamento familiar")
     caso "3"
     escreval("Para se obter bom resultado, no que se refere � sa�de sexual e � sa�de reprodutiva, � importante considerar o conhecimento e experi�ncia dos participantes, permitindo a troca de ideias sobre sexualidade, reprodu��o, relacionamento humano e sobre os fatores socioecon�micos e culturais que influenciam nessas quest�es. Essa metodologia estimula a pessoa a construir um processo decis�rio aut�nomo e centrado em seus interesses")
     caso "4"
     outrocaso
     escreval("Op��o inv�lida")
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
          escreval("Op��o inv�lida")
         
         fimescolha
         ate(sair = "verdadeiro")







Fimalgoritmo