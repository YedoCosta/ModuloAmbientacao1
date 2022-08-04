using ModuloAutenticacao.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaCadUsuario : Form
    {
        public TelaCadUsuario()
        {
            InitializeComponent();
        }

        private void TelaCadUsuario_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtLogin.Enabled = false;
            ChamarNiveis();

        }
        private void ChamarNiveis()
        {
            NivelDAO nivel = new NivelDAO();
            cbNivel.DataSource = nivel.Pesquisar();
            cbNivel.DisplayMember = "nome";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TelaNivel().Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //txtLogin.Text = txtNome.Text + txtSobreNome.Text;
            txtLogin.Text = txtNome.Text;
            txtLogin.BackColor = Color.White;
            string[] nome = txtNome.Text.Split(' ');
            string[] sobrenome = txtSobreNome.Text.Split(' ');
            txtLogin.Text = nome[0].ToLower() + "." + sobrenome[sobrenome.Length - 1].ToLower();
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

        private void cbNivel_Enter(object sender, EventArgs e)
        {
            ChamarNiveis();
        }

  
    }
}
