using System;

namespace prova_pratica_POO
{
    public class Van : Veiculo, IManutencao
    {
        public Van(string ident, float cap, string comb) : base(ident, cap, comb) { }

        public override void RegistrarEntrega()
        {
            Console.WriteLine("Entrega registrada na van");
        }

        public string RealizarManutencao()
        {
            return "Manutenção realizada na van";
        }
    }
}