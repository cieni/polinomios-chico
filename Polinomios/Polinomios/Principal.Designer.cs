namespace Polinomio
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coefA = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrairAB = new System.Windows.Forms.Button();
            this.btnSubtrairBA = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIncluirA = new System.Windows.Forms.Button();
            this.btnDiferenciarA = new System.Windows.Forms.Button();
            this.btnDiferenciarB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.button11 = new System.Windows.Forms.Button();
            this.expA = new System.Windows.Forms.TextBox();
            this.coefB = new System.Windows.Forms.TextBox();
            this.expB = new System.Windows.Forms.TextBox();
            this.btnIncluirB = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.wbA = new System.Windows.Forms.WebBrowser();
            this.wbB = new System.Windows.Forms.WebBrowser();
            this.wbResultado = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnLimpar.Location = new System.Drawing.Point(526, 199);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Polinômio A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Polinômio B:";
            // 
            // coefA
            // 
            this.coefA.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coefA.Location = new System.Drawing.Point(153, 34);
            this.coefA.Name = "coefA";
            this.coefA.Size = new System.Drawing.Size(105, 36);
            this.coefA.TabIndex = 0;
            this.coefA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verificaNumero);
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnSomar.Location = new System.Drawing.Point(364, 199);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 11;
            this.btnSomar.Text = "A + B";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSubtrairAB
            // 
            this.btnSubtrairAB.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnSubtrairAB.Location = new System.Drawing.Point(121, 199);
            this.btnSubtrairAB.Name = "btnSubtrairAB";
            this.btnSubtrairAB.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrairAB.TabIndex = 8;
            this.btnSubtrairAB.Text = "A - B";
            this.btnSubtrairAB.UseVisualStyleBackColor = true;
            this.btnSubtrairAB.Click += new System.EventHandler(this.btnSubtrairAB_Click);
            // 
            // btnSubtrairBA
            // 
            this.btnSubtrairBA.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnSubtrairBA.Location = new System.Drawing.Point(283, 199);
            this.btnSubtrairBA.Name = "btnSubtrairBA";
            this.btnSubtrairBA.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrairBA.TabIndex = 10;
            this.btnSubtrairBA.Text = "B - A";
            this.btnSubtrairBA.UseVisualStyleBackColor = true;
            this.btnSubtrairBA.Click += new System.EventHandler(this.btnSubtrairBA_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnMultiplicar.Location = new System.Drawing.Point(202, 199);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicar.TabIndex = 9;
            this.btnMultiplicar.Text = "A * B";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Coeficiente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Expoente";
            // 
            // btnIncluirA
            // 
            this.btnIncluirA.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnIncluirA.Location = new System.Drawing.Point(384, 34);
            this.btnIncluirA.Name = "btnIncluirA";
            this.btnIncluirA.Size = new System.Drawing.Size(109, 32);
            this.btnIncluirA.TabIndex = 2;
            this.btnIncluirA.Text = "Incluir";
            this.btnIncluirA.UseVisualStyleBackColor = true;
            this.btnIncluirA.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDiferenciarA
            // 
            this.btnDiferenciarA.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnDiferenciarA.Location = new System.Drawing.Point(445, 199);
            this.btnDiferenciarA.Name = "btnDiferenciarA";
            this.btnDiferenciarA.Size = new System.Drawing.Size(38, 23);
            this.btnDiferenciarA.TabIndex = 12;
            this.btnDiferenciarA.Text = "A\'";
            this.btnDiferenciarA.UseVisualStyleBackColor = true;
            this.btnDiferenciarA.Click += new System.EventHandler(this.btnDiferenciarA_Click);
            // 
            // btnDiferenciarB
            // 
            this.btnDiferenciarB.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnDiferenciarB.Location = new System.Drawing.Point(482, 199);
            this.btnDiferenciarB.Name = "btnDiferenciarB";
            this.btnDiferenciarB.Size = new System.Drawing.Size(38, 23);
            this.btnDiferenciarB.TabIndex = 13;
            this.btnDiferenciarB.Text = "B\'";
            this.btnDiferenciarB.UseVisualStyleBackColor = true;
            this.btnDiferenciarB.Click += new System.EventHandler(this.btnDiferenciarB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(18, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(18, 294);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(583, 22);
            this.txtResultado.TabIndex = 15;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "A:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "B:";
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.button11.Location = new System.Drawing.Point(499, 34);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(37, 32);
            this.button11.TabIndex = 3;
            this.button11.Text = "...";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // expA
            // 
            this.expA.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expA.Location = new System.Drawing.Point(273, 34);
            this.expA.Name = "expA";
            this.expA.Size = new System.Drawing.Size(105, 36);
            this.expA.TabIndex = 1;
            this.expA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verificaNumero);
            // 
            // coefB
            // 
            this.coefB.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coefB.Location = new System.Drawing.Point(153, 81);
            this.coefB.Name = "coefB";
            this.coefB.Size = new System.Drawing.Size(105, 36);
            this.coefB.TabIndex = 4;
            this.coefB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verificaNumero);
            // 
            // expB
            // 
            this.expB.Font = new System.Drawing.Font("Segoe UI Light", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expB.Location = new System.Drawing.Point(273, 81);
            this.expB.Name = "expB";
            this.expB.Size = new System.Drawing.Size(105, 36);
            this.expB.TabIndex = 5;
            this.expB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verificaNumero);
            // 
            // btnIncluirB
            // 
            this.btnIncluirB.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnIncluirB.Location = new System.Drawing.Point(384, 81);
            this.btnIncluirB.Name = "btnIncluirB";
            this.btnIncluirB.Size = new System.Drawing.Size(109, 32);
            this.btnIncluirB.TabIndex = 6;
            this.btnIncluirB.Text = "Incluir";
            this.btnIncluirB.UseVisualStyleBackColor = true;
            this.btnIncluirB.Click += new System.EventHandler(this.btnIncluirB_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.button12.Location = new System.Drawing.Point(499, 81);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(37, 32);
            this.button12.TabIndex = 7;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // wbA
            // 
            this.wbA.AllowWebBrowserDrop = false;
            this.wbA.IsWebBrowserContextMenuEnabled = false;
            this.wbA.Location = new System.Drawing.Point(41, 120);
            this.wbA.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbA.Name = "wbA";
            this.wbA.ScrollBarsEnabled = false;
            this.wbA.Size = new System.Drawing.Size(557, 37);
            this.wbA.TabIndex = 23;
            this.wbA.WebBrowserShortcutsEnabled = false;
            // 
            // wbB
            // 
            this.wbB.AllowWebBrowserDrop = false;
            this.wbB.IsWebBrowserContextMenuEnabled = false;
            this.wbB.Location = new System.Drawing.Point(41, 153);
            this.wbB.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbB.Name = "wbB";
            this.wbB.ScrollBarsEnabled = false;
            this.wbB.Size = new System.Drawing.Size(557, 37);
            this.wbB.TabIndex = 24;
            this.wbB.WebBrowserShortcutsEnabled = false;
            // 
            // wbResultado
            // 
            this.wbResultado.AllowWebBrowserDrop = false;
            this.wbResultado.IsWebBrowserContextMenuEnabled = false;
            this.wbResultado.Location = new System.Drawing.Point(17, 230);
            this.wbResultado.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbResultado.Name = "wbResultado";
            this.wbResultado.ScrollBarsEnabled = false;
            this.wbResultado.Size = new System.Drawing.Size(662, 37);
            this.wbResultado.TabIndex = 25;
            this.wbResultado.WebBrowserShortcutsEnabled = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 281);
            this.Controls.Add(this.wbResultado);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btnIncluirB);
            this.Controls.Add(this.expB);
            this.Controls.Add(this.coefB);
            this.Controls.Add(this.expA);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDiferenciarB);
            this.Controls.Add(this.btnDiferenciarA);
            this.Controls.Add(this.btnIncluirA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrairBA);
            this.Controls.Add(this.btnSubtrairAB);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.coefA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.wbA);
            this.Controls.Add(this.wbB);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Polinômios";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox coefA;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrairAB;
        private System.Windows.Forms.Button btnSubtrairBA;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIncluirA;
        private System.Windows.Forms.Button btnDiferenciarA;
        private System.Windows.Forms.Button btnDiferenciarB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox expA;
        private System.Windows.Forms.TextBox coefB;
        private System.Windows.Forms.TextBox expB;
        private System.Windows.Forms.Button btnIncluirB;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.WebBrowser wbA;
        private System.Windows.Forms.WebBrowser wbB;
        private System.Windows.Forms.WebBrowser wbResultado;
    }
}

