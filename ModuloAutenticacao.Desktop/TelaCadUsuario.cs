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
    public partial class TelaCadUsuario : Form
    {
        public TelaCadUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TelaCadUsuario_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtLogin.Enabled = false;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {

            TelaCadUsuario tcu = new TelaCadUsuario();
            tcu.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //txtLogin.Text = txtNome.Text + txtSobreNome.Text;
            txtLogin.Text = txtNome.Text;
            txtLogin.BackColor = Color.White;
            string[] nome = txtNome.Text.Split(' ');
            string[] sobrenome = txtSobreNome.Text.Split(' ');
            txtLogin.Text = nome[0].ToLower() +"."+ sobrenome[sobrenome.Length -1].ToLower();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
                   
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            var senha = txtSenha.Text;
            var confirmar = txtConfirmarSenha.Text;

            if (confirmar.Equals(senha))
            {
                txtSenha.Focus();
            }
            else
            {
                MessageBox.Show("Senhas incompativeis");
                txtSenha.Clear();
                txtConfirmarSenha.Clear();
                txtSenha.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
