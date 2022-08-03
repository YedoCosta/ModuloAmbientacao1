using System;
using System.Windows.Forms;
using ModuloAutenticacao.Classes;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaNivel : Form
    {
        public TelaNivel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
            CarregarResponsabilidades();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Atualizar());
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Deletar());
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void TelaNivel_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            CarregarResponsabilidades();
        }
        private void CarregarResponsabilidades()
        {
            NivelDAO nivelPesquisa = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
