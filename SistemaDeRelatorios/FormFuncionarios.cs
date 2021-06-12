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

        public FormFuncionarios()
        {
            InitializeComponent();
            CarregarDados();
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
    }
}
