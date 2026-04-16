using System;

namespace prova_pratica_POO
{
    public class Caminhao : Veiculo, IManutencao
    {
        public Caminhao(string ident, float cap, string comb) : base(ident, cap, comb) { }

        public override void RegistrarEntrega()
        {
            Console.WriteLine("Entrega registrada no caminhão");
        }

        public string RealizarManutencao()
        {
            return "Manutenção realizada no caminhão";
        }
    }
}