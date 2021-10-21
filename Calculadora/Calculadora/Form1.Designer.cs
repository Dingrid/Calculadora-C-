
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSubtrai = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btMultiplica = new System.Windows.Forms.Button();
            this.btResto = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(196, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num1.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Num2";
            // 
            // tb_num1
            // 
            this.tb_num1.Location = new System.Drawing.Point(84, 92);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(190, 23);
            this.tb_num1.TabIndex = 3;
            this.tb_num1.TextChanged += new System.EventHandler(this.tb_num1_TextChanged);
            // 
            // tb_num2
            // 
            this.tb_num2.Enabled = false;
            this.tb_num2.Location = new System.Drawing.Point(84, 132);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(190, 23);
            this.tb_num2.TabIndex = 4;
            this.tb_num2.TextChanged += new System.EventHandler(this.tb_num2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resultado";
            // 
            // tb_resultado
            // 
            this.tb_resultado.Enabled = false;
            this.tb_resultado.Location = new System.Drawing.Point(94, 216);
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.Size = new System.Drawing.Size(180, 23);
            this.tb_resultado.TabIndex = 6;
            // 
            // btSoma
            // 
            this.btSoma.Enabled = false;
            this.btSoma.Location = new System.Drawing.Point(12, 175);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(28, 23);
            this.btSoma.TabIndex = 7;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSubtrai
            // 
            this.btSubtrai.Enabled = false;
            this.btSubtrai.Location = new System.Drawing.Point(48, 175);
            this.btSubtrai.Name = "btSubtrai";
            this.btSubtrai.Size = new System.Drawing.Size(30, 23);
            this.btSubtrai.TabIndex = 8;
            this.btSubtrai.Text = "-";
            this.btSubtrai.UseVisualStyleBackColor = true;
            this.btSubtrai.Click += new System.EventHandler(this.btSubtrai_Click);
            // 
            // btDivide
            // 
            this.btDivide.Enabled = false;
            this.btDivide.Location = new System.Drawing.Point(86, 175);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(32, 23);
            this.btDivide.TabIndex = 9;
            this.btDivide.Text = "/";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btMultiplica
            // 
            this.btMultiplica.Enabled = false;
            this.btMultiplica.Location = new System.Drawing.Point(125, 176);
            this.btMultiplica.Name = "btMultiplica";
            this.btMultiplica.Size = new System.Drawing.Size(33, 23);
            this.btMultiplica.TabIndex = 10;
            this.btMultiplica.Text = "*";
            this.btMultiplica.UseVisualStyleBackColor = true;
            this.btMultiplica.Click += new System.EventHandler(this.btMultiplica_Click);
            // 
            // btResto
            // 
            this.btResto.Enabled = false;
            this.btResto.Location = new System.Drawing.Point(166, 177);
            this.btResto.Name = "btResto";
            this.btResto.Size = new System.Drawing.Size(82, 22);
            this.btResto.TabIndex = 11;
            this.btResto.Text = "Resto Div";
            this.btResto.UseVisualStyleBackColor = true;
            this.btResto.Click += new System.EventHandler(this.btResto_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Enabled = false;
            this.btLimpar.Location = new System.Drawing.Point(254, 177);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(64, 22);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(330, 298);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btResto);
            this.Controls.Add(this.btMultiplica);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btSubtrai);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.tb_resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_resultado;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSubtrai;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btMultiplica;
        private System.Windows.Forms.Button btResto;
        private System.Windows.Forms.Button btLimpar;
    }
}

