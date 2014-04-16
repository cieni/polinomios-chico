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
        private Polinomio polA, polB;

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
                    int indAtu = 0, exp;
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

        private void Principal_Load(object sender, EventArgs e)
        {
            ofdAbrir = new OpenFileDialog();
            ofdAbrir.Filter = "Arquivos de texto (*.txt)|*.txt";       // só poderá abrir arquivo de extensão txt
            ofdAbrir.RestoreDirectory = true;     
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

        private void verificaNumero(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8) && (e.KeyChar != (char)45))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Inclui novo termo no polinômio A
            Termo termo = new Termo(Convert.ToDouble(coefA.Text), Convert.ToInt32(expA.Text));
            polA.Incluir(termo);
            //Atualiza visualmente (tela) o polinômio
            label6.Text = "A: " + polA;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Inclui novo termo no polinômio B
            Termo termo = new Termo(Convert.ToDouble(coefB.Text), Convert.ToInt32(expB.Text));
            polB.Incluir(termo);
            //Atualiza visualmente (tela) o polinômio
            label7.Text = "B: " + polB;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl is TextBox)
                    ctrl.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = polA.SomadoA(polB) + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = polA.SomadoA(polB.MultiplicarPorConstante(-1)) + "";
        }

    }
}
