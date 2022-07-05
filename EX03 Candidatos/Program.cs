using System;

namespace EX03_Candidatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0, votosBranco = 0, votosNulos = 0, eleitores = 0;
            double percentagemNulos, percentagemBranco;
            string resposta = "sim";
            System.Console.Write("Escolha um dos candidatos: 1 - 2 - 3 - 4 - 5 (Nulo) - 6 (Branco)");
            System.Console.Write("Informe seu voto: ");
            opcao = Int32.Parse(Console.ReadLine());
    
            do
            {
                switch (opcao)
                {
                case 1:
                    candidato1++;
                    break;
                case 2:
                    candidato2++;
                    break;
                case 3:
                    candidato3++;
                    break;

                case 5:
                    votosNulos++;
                    break;
                case 6:
                    votosBranco++;
                    break;
                }
            System.Console.Write("Deseja continuar a votar: ");
            resposta = Console.ReadLine();
            }while(resposta == "SIM" || resposta == "Sim" || resposta == "sim" || resposta == "Sim" || resposta == "s");  

            eleitores = candidato1 + candidato2 + candidato3 + candidato4 + votosBranco + votosNulos;
            System.Console.Write("\nVotos cadidato 1: " + candidato1);
            System.Console.Write("\nVotos cadidato 2: " + candidato2);
            System.Console.Write("\nVotos cadidato 3: " + candidato3);
            System.Console.Write("\nVotos cadidato 4: " + candidato4);
            System.Console.Write("\nTotal eleitores: " + eleitores);
            System.Console.Write("\nVotos Nulos: " + votosNulos);
            percentagemNulos = votosNulos / eleitores;
            System.Console.Write("\nPorcentagem de Votos Nulos: " + percentagemNulos + "%");
            System.Console.Write("\nVotos Branco: " + votosBranco);
            percentagemBranco = votosNulos / eleitores;
            System.Console.Write("\nPorcentagem de Votos Branco: " + percentagemBranco + "%");   
        }   
    }
}
