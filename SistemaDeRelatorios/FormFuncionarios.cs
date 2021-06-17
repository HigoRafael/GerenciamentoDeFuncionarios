using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace SistemaDeRelatorios
{
    public partial class FormFuncionarios : Form
    {
        UserModel user = new UserModel();
        public int idFunc = 0;
        private bool editar;

        public FormFuncionarios()
        {
            InitializeComponent();
            CarregarDados();
            editar = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro !");
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CarregarDados()
        {
            dataGridViewDados.DataSource = user.CarregarDados();
        }

        private void dataGridViewDados_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDados.SelectedRows.Count > 0)
                {
                    imgImagem.Load(dataGridViewDados.SelectedRows[0].Cells[09].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foto não encontrada ou não cadastrado no sistema.");
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    user.Inserir(txtDep.Text, txtSetor.Text, txtFunc.Text, txtMat.Text, Convert.ToInt32(txtNumCard.Text), txtNome.Text, txtRemark.Text, txtBloco.Text, txtFoto.Text, Convert.ToInt32(txtNumArm.Text));
                    CarregarDados();
                    LimpaCamposRedirecionaFoca();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir registro. Verifique se todos os dados foram preenchidos corretamente.");
                }
            }
            if (editar == true)
            {
                try
                {
                    user.Editar(Convert.ToInt32(idFunc), txtDep.Text, txtSetor.Text, txtFunc.Text, txtMat.Text, Convert.ToInt32(txtNumCard.Text), txtNome.Text, txtRemark.Text, txtBloco.Text, txtFoto.Text, Convert.ToInt32(txtNumArm.Text));
                    MessageBox.Show("Dados atualizados com sucesso.");
                    CarregarDados();
                    editar = false;
                    LimpaCamposRedirecionaFoca();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar os dados. Verifique todos os campos e tente novamente.");
                }
            }
        }

        private void btnBuscarMat_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewDados.DataSource = user.CarregarDadosMatricula(Convert.ToInt32(txtBuscMat.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este campo não pode ser nulo e apenas números são permitidos.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDados.SelectedRows.Count > 0)
                {
                    editar = true;
                    idFunc = Convert.ToInt32(dataGridViewDados.CurrentRow.Cells["id"].Value.ToString());
                    txtDep.Text = dataGridViewDados.CurrentRow.Cells["departamento"].Value.ToString();
                    txtSetor.Text = dataGridViewDados.CurrentRow.Cells["setor"].Value.ToString();
                    txtFunc.Text = dataGridViewDados.CurrentRow.Cells["funcao"].Value.ToString();
                    txtMat.Text = dataGridViewDados.CurrentRow.Cells["matricula"].Value.ToString();
                    txtNumCard.Text = dataGridViewDados.CurrentRow.Cells["cardNo"].Value.ToString();
                    txtNome.Text = dataGridViewDados.CurrentRow.Cells["nome"].Value.ToString();
                    txtRemark.Text = dataGridViewDados.CurrentRow.Cells["remark"].Value.ToString();
                    txtBloco.Text = dataGridViewDados.CurrentRow.Cells["bloco"].Value.ToString();
                    txtFoto.Text = dataGridViewDados.CurrentRow.Cells["foto"].Value.ToString();
                    txtNumArm.Text = dataGridViewDados.CurrentRow.Cells["numArmario"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Selecione os dados que você alterar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDados.SelectedRows.Count > 0)
                {
                    idFunc = Convert.ToInt32(dataGridViewDados.CurrentRow.Cells["id"].Value.ToString());
                    user.Deletar(idFunc);
                    MessageBox.Show("Registro excluido com sucesso.");
                    CarregarDados();
                }
                else
                {
                    MessageBox.Show("Erro ao tentar exluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar exluir.");
            }
        }
        
        private void LimpaCamposRedirecionaFoca()
        {
            txtDep.Clear();
            txtSetor.Clear();
            txtFunc.Clear();
            txtMat.Clear();
            txtNumCard.Clear();
            txtNome.Clear();
            txtRemark.Clear();
            txtBloco.Clear();
            txtNumArm.Clear();
            txtFoto.Clear();

            txtDep.Focus();
        }

        private void txtDep_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSetor.Focus();
            }
        }

        private void txtSetor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFunc.Focus();
            }
        }

        private void txtFunc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMat.Focus();
            }
        }

        private void txtMat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumCard.Focus();
            }
        }

        private void txtNumCard_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNome.Focus();
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRemark.Focus();
            }
        }

        private void txtRemark_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBloco.Focus();
            }
        }

        private void txtBloco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumArm.Focus();
            }
        }

        private void txtNumArm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarFoto.Focus();
            }
        }
    }
}
