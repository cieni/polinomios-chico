using System;

namespace Polinomio
{
    class PolinomioComoListaSimples : Polinomio
    {
        ListaSimples<Termo> lista;

        public PolinomioComoListaSimples()
        {
            lista = new ListaSimples<Termo>();
        }

        public override void Incluir(Termo termo) // incluirá Termo na lista, em ordem decrescente de expoente
        {
            ListaSimples<Termo>.NoLista noAtu = lista.Primeiro;
            int acabou = 0; // acabou ficará 1 quando já tiver incluído o novo termo da lista
            while (noAtu != null && acabou < 1)
            {
                if (termo.CompareTo(noAtu) > 0) // termo.expoente > noAtu.expoente
                {
                    noAtu.InsereAntes(termo); // como é em ordem decrescente, deverá ser incluído antes do 1º termo menor que ele
                    acabou = 1;
                }
                noAtu = noAtu.prox;
            }
        }

        public override void Diferenciar() // percorrerá os termos e os diferenciará
        {
            ListaSimples<Termo>.NoLista noAtu = lista.Primeiro;
            while (noAtu != null)
            {                               //diferencia os termos de cada nó da ListaSimples
                noAtu.dados.Diferenciar();
                noAtu = noAtu.prox;
            }
        }

        public override Polinomio SomadoA(Polinomio p) // devolve novo polinômio (this + p)
        {
            return null;
        }

        public override Polinomio MultiplicarPorPolinomio(PolinomioComoListaSimples p)
        {
            PolinomioComoListaSimples resultado = new PolinomioComoListaSimples();
            ListaSimples<Termo>.NoLista noAtu = resultado.lista.Primeiro;
            ListaSimples<Termo>.NoLista noDele = p.lista.Primeiro;

            while (noAtu != null)
            {
                while (noDele != null)
                {
                    int exp;
                    double coef;
                    coef = noAtu.dados.Coeficiente * noDele.dados.Coeficiente;
                    exp  = noAtu.dados.Expoente + noDele.dados.Expoente;
                    resultado.Incluir(new Termo(coef,exp));
                    noDele = noDele.prox;
                }
                noAtu = noAtu.prox;
		noDele = p.lista.Primeiro;
            }
            return resultado;
        }


    }

}

