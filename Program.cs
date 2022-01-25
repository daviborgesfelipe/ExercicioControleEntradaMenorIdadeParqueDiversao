/*Desenvolva um programa que faca o controle de entrada dos clientes em um parque de diversao. O sistema deve solicitar o nome e idade do cliente. Caso o cliente seja menor de 18 anos deve solicitar o nome e idade do responsavel. O responsavel deve ter idade superior ou igual a 18 anos.*/
using System;

namespace ExercicioControleEntradaMenorIdadeParqueDiversao
{
    class Program
    {
        static void Main(string[] args)
        {   
            const int IDADE_MINIMA = 18;
            string nome;
            string nomeResponsavel;
            int idade;
            int idadeResponsavel;
         

            Console.Write("\nDigite a nome do cliente: ");
            nome = Console.ReadLine();

            Console.Write("Digite a idade do cliente: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < IDADE_MINIMA)
            {   
                Console.Write($"\nIdade de {nome} é de {idade} anos, é inferior a idade minima de 18 anos, por favor digite o nome e idade de um responsavel com idade superior ou igual a 18 anos.\n");

                Console.Write("\nDigite o nome do responsavel: ");
                nomeResponsavel = Console.ReadLine();

                Console.Write("Digite a idade do responsavel: ");
                idadeResponsavel = Convert.ToInt32(Console.ReadLine());

                    
                    if(idadeResponsavel < IDADE_MINIMA)
                    {
                        Console.WriteLine($"\nIdade de {nomeResponsavel} é de {idadeResponsavel} anos, é inferior a idade minima de 18 anos, por favor digite o nome e idade de um responsavel com idade superior ou igual a 18 anos. Essa sera sua ultima tentativa\n");

                        Console.Write("Digite o nome do responsavel: ");
                        nomeResponsavel = Convert.ToString(Console.ReadLine());
                        
                        Console.Write("Digite a idade do responsavel: ");
                        idadeResponsavel = Convert.ToInt32(Console.Read());
                    }
                    else if (idadeResponsavel < IDADE_MINIMA)
                    {
                        Console.WriteLine("\n Essa foi sua ultima tentativa, o responsavel precisa ter a idade superior a 18 anos de idade.\n");

                        Console.WriteLine("\nAcesso Negado.\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nÓtimo, o cadastro de {nome} foi concluido com sucesso, tambem informo que é de sua responsabilidade, Sr(a) {nomeResponsavel}, os atos de {nome} durante a estadia no Parque de Diversao, aproveitem aqui no parque a diversao é garantida.\n");
                    }
            }
            else
            {
                Console.WriteLine($"\nCadastro concluido com sucesso Sr(a) {nome}, aproveitem aqui no parque a diversao é garantida\n");
            }
        }
    }
}
