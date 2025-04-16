using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastros
{
    public partial class frmCadProd : Form
    {
        public frmCadProd()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        private void rtxtDescricao_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtDescricao.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(rtxtDescricao, "A Descrição está vazia!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(rtxtDescricao, "");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Registro salvo com sucesso.", "Informação",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("É necessário o preenchimento de " +
                                "todos os campos obrigatórios.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Descartar as alterações?",
                               "Confirmação",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void mtxtValor_Validating(object sender, CancelEventArgs e)
        {
            string valor = "";
            foreach (char i in mtxtValor.Text)
            {
                if (char.IsNumber(i))
                    valor += i;
            }
            if (string.IsNullOrEmpty(valor))
            {
                e.Cancel= true;
                errorProvider1.SetError(mtxtValor, "Insira um valor!");
            }
            else if (int.Parse(valor) <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtValor, "Insira um valor maior que zero!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtValor, "");
            }

        }

        private void mtxtCodBarra_Validating(object sender, CancelEventArgs e)
        {
            string Cod = "";
            foreach (char i in mtxtCodBarra.Text)
            {
                if (char.IsNumber(i))
                    Cod += i;
            }
            if (string.IsNullOrEmpty(Cod))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtCodBarra, "Insira um valor!");
            }
            else if (Cod.Length != 13)
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtCodBarra, "Deve-se conter 13 caracteres no código de barra!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtCodBarra, "");
            }
        }

        private void cmbUnidade_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbUnidade.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbUnidade, "Selecione a unidade do produto!");
            }
            else 
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbUnidade, "");
            }
        }

        private void cmbGrupo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbGrupo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbGrupo, "Selecione o grupo do produto!");
            }
            else 
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbGrupo, "");
            }
        }
    }
}
