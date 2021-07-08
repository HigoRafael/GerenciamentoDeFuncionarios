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
        private int idFunc = 0;
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

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    user.Inserir(txtFilial.Text, Convert.ToInt32(txtMatricula.Text), txtMatriculaCC.Text, txtNome.Text, txtCentroCusto.Text, txtDescricaoDepartamento.Text, txtGrupo.Text, txtCargo.Text, txtFuncao.Text, txtDescrPosi.Text, textDesFuncOpe.Text, textBloco.Text, Convert.ToInt32(textNumeroArmario.Text), txtFoto.Text);
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
                    user.Editar(Convert.ToInt32(idFunc), txtFilial.Text, Convert.ToInt32(txtMatricula.Text), txtMatriculaCC.Text, txtNome.Text, txtCentroCusto.Text, txtDescricaoDepartamento.Text, txtGrupo.Text, txtCargo.Text, txtFuncao.Text, txtDescrPosi.Text, textDesFuncOpe.Text, textBloco.Text, Convert.ToInt32(textNumeroArmario.Text), txtFoto.Text);
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
                txtBuscMat.Clear();
                txtBuscMat.Focus();
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
                    idFunc = Convert.ToInt32(dataGridViewDados.CurrentRow.Cells["ID"].Value.ToString());
                    txtFilial.Text = dataGridViewDados.CurrentRow.Cells["FILIAL"].Value.ToString();
                    txtMatricula.Text = dataGridViewDados.CurrentRow.Cells["MATRICULA"].Value.ToString();
                    txtMatriculaCC.Text = dataGridViewDados.CurrentRow.Cells["MATRICULACC"].Value.ToString();
                    txtNome.Text = dataGridViewDados.CurrentRow.Cells["NOME"].Value.ToString();
                    txtCentroCusto.Text = dataGridViewDados.CurrentRow.Cells["CENTRO_CUSTO"].Value.ToString();
                    txtDescricaoDepartamento.Text = dataGridViewDados.CurrentRow.Cells["DESCRICAO_DEPARTAMENTO"].Value.ToString();
                    txtGrupo.Text = dataGridViewDados.CurrentRow.Cells["GRUPO"].Value.ToString();
                    txtCargo.Text = dataGridViewDados.CurrentRow.Cells["CARGO"].Value.ToString();
                    txtFuncao.Text = dataGridViewDados.CurrentRow.Cells["FUNCAO"].Value.ToString();
                    txtDescrPosi.Text = dataGridViewDados.CurrentRow.Cells["DESCRICAO_POSICAO"].Value.ToString();
                    textDesFuncOpe.Text = dataGridViewDados.CurrentRow.Cells["DES_FUN_OPE"].Value.ToString();
                    textBloco.Text = dataGridViewDados.CurrentRow.Cells["BLOCO_ARMARIO"].Value.ToString();
                    textNumeroArmario.Text = dataGridViewDados.CurrentRow.Cells["NUMERO_ARMARIO"].Value.ToString();
                    txtFoto.Text = dataGridViewDados.CurrentRow.Cells["FOTO"].Value.ToString();
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
                    LimpaCamposRedirecionaFoca();
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
            txtFilial.Clear();
            txtMatricula.Clear();
            txtMatriculaCC.Clear();
            txtNome.Clear();
            txtCentroCusto.Clear();
            txtDescricaoDepartamento.Clear();
            txtGrupo.Clear();
            txtCargo.Clear();
            txtFuncao.Clear();
            txtFoto.Clear();
            imgImagem.Image = null;

            txtFilial.Focus();
        }

        private void txtDep_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatricula.Focus();
            }
        }

        private void txtSetor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatriculaCC.Focus();
            }
        }

        private void txtFunc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNome.Focus();
            }
        }

        private void txtMat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCentroCusto.Focus();
            }
        }

        private void txtNumCard_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescricaoDepartamento.Focus();
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGrupo.Focus();
            }
        }

        private void txtRemark_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCargo.Focus();
            }
        }

        private void txtBloco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFuncao.Focus();
            }
        }

        private void txtNumArm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarFoto.Focus();
            }
        }

        private void txtBuscMat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarMat_Click(this, null);
            }
        }

        private void btnCinsultaRec_Click(object sender, EventArgs e)
        {
            LimpaCamposRedirecionaFoca();
            CarregarDados();
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFoto.Text = openFileDialog1.FileName;  
            }
        }

        private void dataGridViewDados_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDados.SelectedRows.Count > 0)
                {
                    imgImagem.Load(dataGridViewDados.SelectedRows[0].Cells[14].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foto não encontrada ou não cadastrado no sistema.");
            }
        }
    }
}
