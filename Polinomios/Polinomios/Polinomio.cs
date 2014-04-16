using System;

namespace Polinomio
{
    abstract class Polinomio
    {
        public abstract void Incluir(Termo termo); // incluirá Termo em ordem na lista
        public abstract void Diferenciar();// percorrerá os termos e os diferenciará
        public abstract Polinomio MultiplicarPorConstante(double constante);// percorrerá os termos e os diferenciará
        public abstract Polinomio SomadoA(Polinomio p); // devolve novo polinômio (this+p)
        public static Polinomio operator +(Polinomio p1, Polinomio p2)
        {
            return p1.SomadoA(p2);
        }
    }

}