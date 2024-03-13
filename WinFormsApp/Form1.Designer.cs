namespace WinFormsApp
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
            groupBox1 = new GroupBox();
            txtCidade = new TextBox();
            label6 = new Label();
            txtCep = new TextBox();
            label5 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtSobrenome = new TextBox();
            label3 = new Label();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnImprimir = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCep);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSobrenome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(758, 262);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Usuário:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(348, 218);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(299, 37);
            txtCidade.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 190);
            label6.Name = "label6";
            label6.Size = new Size(86, 30);
            label6.TabIndex = 10;
            label6.Text = "Cidade:";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(17, 218);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(299, 37);
            txtCep.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 190);
            label5.Name = "label5";
            label5.Size = new Size(55, 30);
            label5.TabIndex = 8;
            label5.Text = "CEP:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(348, 143);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(299, 37);
            txtBairro.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 115);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 6;
            label4.Text = "Bairro:";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(348, 64);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(299, 37);
            txtSobrenome.TabIndex = 5;
            txtSobrenome.Text = "Digite aqui";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 36);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 4;
            label3.Text = "Sobrenome:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(17, 143);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(299, 37);
            txtEndereco.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 115);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 2;
            label2.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 65);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(299, 37);
            txtNome.TabIndex = 1;
            txtNome.Text = "Digite aqui";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 36);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnImprimir);
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(btnSalvar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnNovo);
            groupBox2.Font = new Font("Segoe UI", 11F);
            groupBox2.Location = new Point(19, 300);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(757, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ações:";
           
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(577, 42);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(153, 34);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(430, 42);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(292, 42);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(153, 42);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(13, 42);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(112, 34);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 411);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnImprimir;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
        private TextBox txtBairro;
        private Label label4;
        private TextBox txtSobrenome;
        private Label label3;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtCidade;
        private Label label6;
        private TextBox txtCep;
        private Label label5;
    }
}
