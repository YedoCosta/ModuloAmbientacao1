using ModuloAutenticacao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaAutenticacao : Form
    {
        public TelaAutenticacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Login = textLogin.Text;
            user.Senha = textSenha.Text;


            if (user.Login.Equals("") || user.Senha.Equals(""))
            {
                MessageBox.Show("Login Obrigatorio");
                textLogin.Focus();
            }
            else if (user.Login.Equals("senai") && user.Senha.Equals(123))
            {
                MessageBox.Show("Usuario ou senha invalido");
                textSenha.Focus();
            }
            else
            {
                TelaCadUsuario tcu = new TelaCadUsuario();
                tcu.Show();

            }
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaAutenticacao_Load(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
