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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Equals("USUARIO"))
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.LightGray;
            }
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if (textBoxUser.Text.Equals(""))
            {
                textBoxUser.Text = "USUARIO";
                textBoxUser.ForeColor = Color.DimGray;
            }

        }

        private void textBoxSenha_Enter(object sender, EventArgs e)
        {
            if (textBoxSenha.Text.Equals("SENHA"))
            {
                textBoxSenha.Text = "";
                textBoxSenha.ForeColor = Color.LightGray;
                textBoxSenha.UseSystemPasswordChar = true;
            }
        }

        private void textBoxSenha_Leave(object sender, EventArgs e)
        {
            if (textBoxSenha.Text.Equals(""))
            {
                textBoxSenha.Text = "SENHA";
                textBoxSenha.ForeColor = Color.DimGray;
                textBoxSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonAcessar_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "USUARIO")
            {
                if (textBoxSenha.Text != "SENHA")
                {
                    UserModel user = new UserModel();
                    var validaLogin = user.LoginUser(textBoxUser.Text,textBoxSenha.Text);
                    if (validaLogin == true)
                    {
                        FormularioPrincipal formularioPrincipal = new FormularioPrincipal();
                        formularioPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario ou senha invalida \n " +
                            "Por favor tente novamente.");
                        textBoxSenha.Clear();
                        textBoxUser.Focus();
                    }
                }
                else
                {
                    msgError("Por favor digite sua senha");
                }
            }
            else
            {
                msgError("Por favor digite seu nome de usuario");
            }
        }
        private void msgError(string mensagem)
        {
            lblMensagemErro.Text = "  " + mensagem;
            lblMensagemErro.Visible = true;
        }

        private void textBoxUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
               textBoxSenha.Focus();
            }
        }

        private void textBoxSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAcessar_Click(this, null);
            }
        }
    }
}
