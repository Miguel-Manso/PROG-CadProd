namespace AppCadastros
{
    partial class frmCadProd
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
            this.components = new System.ComponentModel.Container();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrat = new System.Windows.Forms.TextBox();
            this.mtxtCodBarra = new System.Windows.Forms.MaskedTextBox();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.rtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.mtxtValor = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(194, 313);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 40);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 40);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Prateleira:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Unidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Codigo de Barras:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrat
            // 
            this.txtPrat.Location = new System.Drawing.Point(190, 82);
            this.txtPrat.Name = "txtPrat";
            this.txtPrat.Size = new System.Drawing.Size(100, 20);
            this.txtPrat.TabIndex = 19;
            // 
            // mtxtCodBarra
            // 
            this.mtxtCodBarra.Location = new System.Drawing.Point(12, 30);
            this.mtxtCodBarra.Mask = "9999999999999";
            this.mtxtCodBarra.Name = "mtxtCodBarra";
            this.mtxtCodBarra.Size = new System.Drawing.Size(100, 20);
            this.mtxtCodBarra.TabIndex = 18;
            this.mtxtCodBarra.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtCodBarra_Validating);
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "UN",
            "PC",
            "KG",
            "ML",
            "LT"});
            this.cmbUnidade.Location = new System.Drawing.Point(194, 146);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(121, 21);
            this.cmbUnidade.TabIndex = 17;
            this.cmbUnidade.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUnidade_Validating);
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "BEBIDAS",
            "IOGURTES",
            "FARINHAS",
            "CONGELADOS"});
            this.cmbGrupo.Location = new System.Drawing.Point(12, 146);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupo.TabIndex = 16;
            this.cmbGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGrupo_Validating);
            // 
            // rtxtDescricao
            // 
            this.rtxtDescricao.Location = new System.Drawing.Point(12, 200);
            this.rtxtDescricao.Name = "rtxtDescricao";
            this.rtxtDescricao.Size = new System.Drawing.Size(303, 96);
            this.rtxtDescricao.TabIndex = 15;
            this.rtxtDescricao.Text = "";
            this.rtxtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtDescricao_Validating);
            // 
            // mtxtValor
            // 
            this.mtxtValor.Location = new System.Drawing.Point(12, 82);
            this.mtxtValor.Mask = "9999,99";
            this.mtxtValor.Name = "mtxtValor";
            this.mtxtValor.Size = new System.Drawing.Size(100, 20);
            this.mtxtValor.TabIndex = 14;
            this.mtxtValor.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtValor_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 365);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrat);
            this.Controls.Add(this.mtxtCodBarra);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.rtxtDescricao);
            this.Controls.Add(this.mtxtValor);
            this.Name = "frmCadProd";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrat;
        private System.Windows.Forms.MaskedTextBox mtxtCodBarra;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.RichTextBox rtxtDescricao;
        private System.Windows.Forms.MaskedTextBox mtxtValor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}