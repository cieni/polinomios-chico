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
            if (lista.EstaVazia)
            {
                lista.IncluirAntesDoPrimeiro(termo);
                return;
            }

            ListaSimples<Termo>.NoLista noAtu = lista.Primeiro;

            bool acabou = false; // acabou ficará 1 quando já tiver incluído o novo termo da lista
            while (noAtu != null && !acabou)
            {
                if (termo.CompareTo(noAtu.dados) > 0) // termo.expoente > noAtu.expoente
                {
                    noAtu.InsereAntes(termo); // como é em ordem decrescente, deverá ser incluído antes do 1º termo menor que ele
                    acabou = true;
                } 
                noAtu = noAtu.prox;
            }
            if (!acabou)
            {
                lista.Ultimo.InsereDepois(termo);
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
            PolinomioComoListaSimples x = p as PolinomioComoListaSimples,
                ret = new PolinomioComoListaSimples();
            if (x == null)
                return null;

            ListaSimples<Termo>.NoLista noX = x.lista.Primeiro,
                noThis = this.lista.Primeiro;
            ListaSimples<Termo> nLista = ret.lista;

            while (noX != null || noThis != null)
            {
                Termo t = new Termo(0, 0);

                if (noX == null || noThis.dados.Expoente > noX.dados.Expoente)
                {
                    t.Coeficiente = noThis.dados.Coeficiente;
                    t.Expoente = noThis.dados.Expoente;
                    
                    nLista.IncluirAposUltimo(t);
                    noThis = noThis.prox;
                }
                else if (noThis == null || noX.dados.Expoente > noThis.dados.Expoente) 
                {
                    t.Coeficiente = noX.dados.Coeficiente;
                    t.Expoente = noX.dados.Expoente;
                    
                    nLista.IncluirAposUltimo(t);
                    noX = noX.prox;
                }
                // expoentes iguais => soma os coeficientes
                else if (noX.dados.Expoente == noThis.dados.Expoente)
                {
                    t.Coeficiente = noX.Dados.Coeficiente + noThis.Dados.Coeficiente;
                    t.Expoente = noX.Dados.Expoente;

                    nLista.IncluirAposUltimo(t);
                    noX = noX.prox; noThis = noThis.prox;
                }
            }

            return ret;
        }

        public override Polinomio MultiplicarPorConstante(double constante)
        {
            PolinomioComoListaSimples ret = new PolinomioComoListaSimples();
            ret.lista.Copiar(lista, false);

            for (ListaSimples<Termo>.NoLista ptr = ret.lista.Primeiro; ptr != null; ptr = ptr.Prox)
                ptr.dados.Coeficiente *= constante;

            return ret;
        }

        public override Polinomio MultiplicarPorPolinomio(Polinomio p)
        {
            PolinomioComoListaSimples resultado = new PolinomioComoListaSimples();
            ListaSimples<Termo>.NoLista noAtu = resultado.lista.Primeiro;
            ListaSimples<Termo>.NoLista noDele = ((PolinomioComoListaSimples)p).lista.Primeiro;

            while (noAtu != null)
            {
                while (noDele != null)
                {
                    int exp;
                    double coef;
                    coef = noAtu.dados.Coeficiente * noDele.dados.Coeficiente;
                    exp = noAtu.dados.Expoente + noDele.dados.Expoente;
                    resultado.Incluir(new Termo(coef, exp));
                    noDele = noDele.prox;
                }
                noAtu = noAtu.prox;
            }

            return resultado;
        }

        public override string ToString()
        {
            String result = String.Empty;
            ListaSimples<Termo>.NoLista noAtu = lista.Primeiro;
            while (noAtu != null)
            {
                if (noAtu.dados.Coeficiente != 0)
                    result = result + noAtu.dados.ToString();
                    noAtu = noAtu.prox;
                
            }

            return result;
        }
    }

}

