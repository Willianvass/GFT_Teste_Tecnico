using System;

namespace EX01___Valor_Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorCarro, parcelas, valorParcelas, precoFinal;

            System.Console.WriteLine("Valor do carro R$ ");
            valorCarro = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Parcelas: ");
            parcelas = double.Parse(Console.ReadLine());

            if (parcelas == 6)
            {
                precoFinal = valorCarro + (valorCarro * 0.03);
                valorParcelas = precoFinal / parcelas;
                System.Console.WriteLine("Preço final R$ " + precoFinal.ToString("0.00"));
                System.Console.WriteLine("Parcelas: " + parcelas);
                System.Console.WriteLine("Valor parcela R$ " + valorParcelas.ToString("0.00"));
            }
            if (parcelas == 12)
            {
                precoFinal = valorCarro + (valorCarro * 0.06);
                valorParcelas = precoFinal / parcelas;
                System.Console.WriteLine("Preço final R$ " + precoFinal.ToString("0.00"));
                System.Console.WriteLine("Parcelas: " + parcelas);
                System.Console.WriteLine("Valor parcela R$ " + valorParcelas.ToString("0.00"));
            }
            if (parcelas == 18)
            {
                precoFinal = valorCarro + (valorCarro * 0.09);
                valorParcelas = precoFinal / parcelas;
                System.Console.WriteLine("Preço final R$ " + precoFinal.ToString("0.00"));
                System.Console.WriteLine("Parcelas: " + parcelas);
                System.Console.WriteLine("Valor parcela R$ " + valorParcelas.ToString("0.00"));
            }
            if (parcelas == 24)
            {
                precoFinal = valorCarro + (valorCarro * 0.12);
                valorParcelas = precoFinal / parcelas;
                System.Console.WriteLine("Preço final R$ " + precoFinal.ToString("0.00"));
                System.Console.WriteLine("Parcelas: " + parcelas);
                System.Console.WriteLine("Valor parcela R$ " + valorParcelas.ToString("0.00"));
            }
            if (parcelas == 48)
            {
                precoFinal = valorCarro + (valorCarro * 0.15);
                valorParcelas = precoFinal / parcelas;
                System.Console.WriteLine("Preço final R$ " + precoFinal.ToString("0.00"));
                System.Console.WriteLine("Parcelas: " + parcelas);
                System.Console.WriteLine("Valor parcela R$ " + valorParcelas.ToString("0.00"));
            }
            else
            {
                precoFinal = valorCarro - (valorCarro * 0.20);
                System.Console.WriteLine("Carro a vista R$ " + precoFinal.ToString("0.00"));
            }
        }
    }
}
