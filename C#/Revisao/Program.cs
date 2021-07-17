using System;
using System.Globalization;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string userOption = "";

            int numeroDeAlunos = 0;

            while (userOption.ToUpper() != "X")
            {
                menuInicial();

                userOption = Console.ReadLine();

                if (userOption == "1")
                {
                    string nome, nota;

                    Console.WriteLine("Informe o nome do aluno:");
                    nome = Console.ReadLine();
                    Console.WriteLine("Informe a nota do aluno:");
                    nota = Console.ReadLine();

                    alunos[numeroDeAlunos++] = new Aluno(nome, Convert.ToDecimal(nota, new CultureInfo("pt-BR")));
                }
                else if (userOption == "2")
                {
                    Console.WriteLine("Lista de alunos:");

                    foreach (var a in alunos)
                    {
                        if (a != null)
                        {
                            a.printAluno();
                        }
                        else
                        {
                            break;
                        }
                    }

                }
                else if (userOption == "3")
                {
                    decimal totalNotas = 0;
                    
                    foreach (var a in alunos)
                    {
                        if (a != null)
                        {
                            totalNotas += a.Nota;
                        }
                        else
                        {
                            break;
                        }
                    }

                    var mediaGeral = totalNotas / alunos.Length;
                    Conceito conceitoGeral;

                    if(mediaGeral < 2)
                    {
                        conceitoGeral = Conceito.E;
                    }
                    else if(mediaGeral < 4)
                    {
                        conceitoGeral = Conceito.D;
                    }
                    else if(mediaGeral < 6)
                    {
                        conceitoGeral = Conceito.C;
                    }
                    else if(mediaGeral < 8)
                    {
                        conceitoGeral = Conceito.B;
                    }
                    else 
                    {
                        conceitoGeral = Conceito.A;
                    }


                    Console.WriteLine($"A média geral é: {mediaGeral}. Conceito: {conceitoGeral}");


                }
                else if (userOption.ToUpper() != "X")
                {
                    Console.WriteLine("Digite um valor válido!");
                    //throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("\n" + userOption + "\n");
            }



        }

        static void menuInicial()
        {
            Console.WriteLine("\nInformar a opção desejada:");
            Console.WriteLine("1 - Adicionar novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral\n");
            Console.WriteLine("X - Sair");
        }
    }
}
