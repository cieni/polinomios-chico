using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polinomio
{
    public partial class Principal : Form
    {
        Polinomio polA,polB;
        public Principal()
        {
            InitializeComponent();
            polA = new PolinomioComoListaSimples();
            polB = new PolinomioComoListaSimples();
        }

        private Polinomio lerTermoDeArquivo()
        {
            PolinomioComoListaSimples lido = new PolinomioComoListaSimples();
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                if (ofdAbrir.OpenFile() != null)
                {
                    int indAtu = 0,exp;
                    double coef;
                    String caminho = ofdAbrir.FileName;
                    StreamReader sr = new StreamReader(caminho);
                    string[] linha;
                    linha = sr.ReadToEnd().Split(' ');   //le palavra por palavra separadas por espaço
                    sr.Close();
                    while (linha[indAtu] != null)
                    {
                        coef = Convert.ToInt32(linha[indAtu]);
                        if (linha[indAtu + 1] != null)
                            exp = Convert.ToInt32(linha[indAtu + 1]);
                        else
                            exp = 1;
                        Termo atual = new Termo(coef, exp);
                        lido.Incluir(atual);
                        indAtu += 2;
                    }                   
                }
            }
            return lido;
        }

        private void button11_Click(object sender, EventArgs e) //ler de arquivo
        {
           polA = lerTermoDeArquivo();
           label6.Text = "A: " + polA;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            polB = lerTermoDeArquivo();
            label7.Text = "B: " + polB;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ofdAbrir = new OpenFileDialog();
            ofdAbrir.Filter = "Text files (*.txt)|*.txt";       // só poderá abrir arquivo de extensão txt
            ofdAbrir.RestoreDirectory = true;            //faz com que ele sempre abra onde foi selecionado ante
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int exp;
            double coef;
            coef = Convert.ToInt32(coefA.Text);
            exp = Convert.ToInt32(expA.Text);
            Termo novoTermo;
            novoTermo = new Termo(coef,exp);
            polA.Incluir(novoTermo);
            label6.Text = "A: "+polA.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int exp;
            double coef;
            coef = Convert.ToInt32(coefA.Text);
            exp = Convert.ToInt32(expA.Text);
            Termo novoTermo;
            novoTermo = new Termo(coef, exp);
            polB.Incluir(novoTermo);
            label7.Text = "B: "+polB.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Polinomio polResultado;
            polResultado = polA.SomadoA(polB);
            txtResultado.Text = polResultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Polinomio polResultado;
            polResultado = polB.MultiplicarPorConstante(-1);
            polResultado.SomadoA(polA);            
            txtResultado.Text = polResultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Polinomio polResultado;
            polResultado = polA.MultiplicarPorConstante(-1);
            polResultado.SomadoA(polB);
            txtResultado.Text = polResultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Polinomio polResultado = polA.MultiplicarPorPolinomio(polB);
            txtResultado.Text = polResultado.ToString();
        }

    }
}
