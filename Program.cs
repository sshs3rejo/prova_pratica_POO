using System;
using System.Collections.Generic;
using prova_pratica_POO;

namespace prova_pratica_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> lista = new List<Veiculo>();
            int cont = 0;

            Caminhao c1 = new Caminhao("ABC-1234", 10, "Diesel");
            Van v1 = new Van("XYZ-5678", 2, "Gasolina");

            lista.Add(c1);
            lista.Add(v1);

            foreach (Veiculo v in lista)
            {
                Console.WriteLine("Dados: " + v.ToString());
                
                v.RegistrarEntrega();

                if (v is IManutencao)
                {
                    IManutencao m = (IManutencao)v;
                    Console.WriteLine(m.RealizarManutencao());
                }

                Console.WriteLine("-------------------------");
            }
        }
    }
}
