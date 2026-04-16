using System;

namespace prova_pratica_POO
{
    public abstract class Veiculo
    {
        protected string identificacao;
        protected float capacidadeCarga;
        protected string tipoCombustivel;

        public Veiculo(string identificacao, float capacidadeCarga, string tipoCombustivel)
        {
            this.identificacao = identificacao;
            this.capacidadeCarga = capacidadeCarga;
            this.tipoCombustivel = tipoCombustivel;
        }

        public abstract void RegistrarEntrega();

        public override string ToString()
        {
            return identificacao + " - capacidade: " + capacidadeCarga + "t - " + tipoCombustivel;
        }
    }
}