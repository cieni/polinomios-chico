using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio
{
    public class ListaSimples<Tipo> where Tipo : ICloneable
    {
        protected NoLista primeiro;
        protected NoLista ultimo;
        protected int quantosNos;

        public NoLista Primeiro
        {
            get { return primeiro; }

        }
        public bool EstaVazia
        {
            get { return primeiro == null; }
        }

        public Tipo PrimeiroValor // acessa o valor armazenado no 1o nó da lista
        {
            get
            {
                if (EstaVazia) // lista vazia
                    throw new ListaVaziaException();
                return primeiro.dados;
            }
        }

        public NoLista Ultimo // acessa o valor armazenado no 1o nó da lista
        {
            get
            {
                if (ultimo == null) // lista vazia ou não tem apontador para o último nó
                    throw new ListaVaziaException();
                return ultimo;
            }
        }

        public Tipo UltimoValor // acessa o valor armazenado no 1o nó da lista
        {
            get
            {
                if (ultimo == null) // lista vazia ou não tem apontador para o último nó
                    throw new ListaVaziaException();
                return ultimo.dados;
            }
        }

        public void IncluirAntesDoPrimeiro(Tipo item) // passa o dado como parâmetro
        {
            // cria um novo nó para armazenar o dado (item) e o faz apontar o
            // 1o nó
            NoLista tmp = new NoLista(this, item, primeiro);
            if (EstaVazia)
                ultimo = tmp;
            primeiro = tmp;
            quantosNos++;
        }

        public void IncluirAposUltimo(Tipo item)
        {
            // cria um novo nó para armazenar o dado (item) e esse nó não
            // aponta para nenhum nó seguinte (pois será o último da lista)
            NoLista tmp = new NoLista(this, item, null);
            if (EstaVazia) // se a lista está vazia, o primeiro nó apontará o nó criad
                primeiro = tmp;
            else // se a lista não está vazia, o atual último nó se liga ao novo
                ultimo.prox = tmp;
            ultimo = tmp; // o novo nó passa a ser o último da lista
            quantosNos++;
        }

        public void Copiar(ListaSimples<Tipo> origem, bool manterDestino)
        {
            if (origem != this)
            {
                if (!manterDestino) // se manterAtual = false, apaga a lista de destino
                    Limpar(); // limpa a lista de destino (this) para receber os nós da origem
                for (NoLista ptr = origem.primeiro; ptr != null; ptr = ptr.prox)
                    IncluirAposUltimo((Tipo)(ptr.dados.Clone()));
            }
        }

        public void Extrair(Tipo item)
        {
            NoLista atual = primeiro;
            NoLista anterior = null;
            while (atual != null && !atual.dados.Equals(item))
            {
                anterior = atual;
                atual = atual.prox;
            }
            if (atual == null)
                throw new ArgumentException("Item não encontrado para extração");
            if (atual == primeiro)
                primeiro = primeiro.prox;
            else
                anterior.prox = atual.prox; // se atual for o último nó, o prox do anterior
            // será null
            if (atual == ultimo)
                ultimo = anterior;
            quantosNos--;
        }

        public ListaSimples()
        {
        }

        public void Limpar()
        {
            primeiro = null;
            ultimo = null;
            quantosNos = 0;
        }

        public sealed class NoLista
        {
            internal ListaSimples<Tipo> lista;
            internal Tipo dados;
            internal NoLista prox;
            public void InsereDepois(Tipo item) // inseré novo nó após o nó que invoca
            //este método
            {
                prox = new NoLista(lista, item, prox);
                lista.quantosNos++;
                if (lista.ultimo== this)
                    lista.ultimo = prox;
            }
            public void InsereAntes(Tipo item) // insere novo nó antes do nó que invoca
            // este método
            {
                NoLista tmp = new NoLista(lista, item, this); // novo nó é criado e aponta
                // o nó atual
                lista.quantosNos++;
                // se o nó que invocou este método (atual) é o primeiro da lsita,
                // o novo nó passará a ser o primeiro
                if (this == lista.primeiro)
                    lista.primeiro = tmp;
                else // se o nó atual não é o primeiro, procura-se o nó anterior ao atual
                { // para ligá-lo ao novo nó, que já está ligado ao atual
                    NoLista percorre = lista.primeiro;
                    while (percorre != null && percorre.prox != this)
                        percorre = percorre.prox;
                    percorre.prox = tmp;
                }
            }

            internal NoLista(ListaSimples<Tipo> lista, Tipo dados, NoLista prox)
            {
                this.lista = lista;
                this.dados = dados;
                this.prox = prox;

            }

            public Tipo Dados
            {
                get { return dados; }
                set { dados = value; }
            }
            public NoLista Prox
            {
                get { return prox; }
                set { prox = value; }
            }
        }
    }
}

