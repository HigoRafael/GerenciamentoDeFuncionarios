using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeRelatorios
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnDeslisa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuVertical.Width == 283)
                {
                    MenuVertical.Width = 84;
                }
                else
                {
                    MenuVertical.Width = 283;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro !");
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro !");
            }
        }

        private void AbrirFormPanel(object ForFunci)
        {
                if (this.PanelPrincpal.Controls.Count > 0)
                    this.PanelPrincpal.Controls.RemoveAt(0);

                    Form fc = ForFunci as Form;
                    fc.TopLevel = false;
                    fc.Dock = DockStyle.Fill;
                    this.PanelPrincpal.Controls.Add(fc);
                    this.PanelPrincpal.Tag = fc;
                    fc.Show();    
        }
        private void buttonAcessar_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormFuncionarios());
        }
    }
}
