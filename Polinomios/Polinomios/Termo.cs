using System;

namespace Polinomio
{

    public class Termo : ComparableObject, ICloneable
    {
        protected double coeficiente;
        protected int expoente;

        public double Coeficiente
        {
            get
            {
                return coeficiente;
            }
            set
            {
                coeficiente = value;
            }
        }

        public int Expoente
        {
            get
            {
                return expoente;
            }
            set
            {
                expoente = value;
            }
        }

        public Termo(double coef, int expo)
        {
            this.coeficiente = coef;
            this.expoente = expo;
        }

        public override int CompareTo(object obj)
        {
            Termo termo = (Termo)obj;
            if (expoente == termo.expoente)
            {
                if (coeficiente < termo.coeficiente)
                    return -1;
                else
                    if (coeficiente > termo.coeficiente)
                        return +1;
                    else
                        return 0;
            }
            else
                return expoente - termo.expoente;
        }

        public void Diferenciar() // calcula derivada do termo
        {
            if (expoente > 0)
            {
                coeficiente *= expoente;
                expoente -= 1;
            }
            else
                coeficiente = 0;
        }

        public override string ToString()
        {
            if (coeficiente == 0)
                return "0";

            if (expoente == 0)
            {
                if (coeficiente > 0)
                    return "+" + coeficiente;

                return coeficiente + "";
            }
            else if (expoente == 1)
            {
                if (Math.Abs(coeficiente) == 1)
                    if (coeficiente > 0)
                    {
                        return "+x";
                    }
                    else
                    {
                        return "-x";
                    }
                if (coeficiente > 0)
                    return "+" + coeficiente + "x";

                return coeficiente + "x";
            }

            if (Math.Abs(coeficiente) == 1)
                if (coeficiente > 0)
                {
                    return "+x^" + expoente;
                }
                else
                {
                    return "-x^" + expoente;
                }

            if (coeficiente > 0)
                return "+" + coeficiente + "x^" + expoente;
            
            return coeficiente + "x^" + expoente;
        }

        public object Clone()
        {
            Termo t = new Termo(coeficiente, expoente);
            return t;
        }

    }

}