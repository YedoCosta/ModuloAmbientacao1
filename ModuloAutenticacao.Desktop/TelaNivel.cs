using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ModuloAutenticacao.Classes;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaNivel : Form
    {
        int ID = 0;
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
            MessageBox.Show(nivel.Atualizar(txtID.Text,txtNome.Text));
            CarregarResponsabilidades();
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



        private void dgvNivel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgvNivel.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dgvNivel.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
