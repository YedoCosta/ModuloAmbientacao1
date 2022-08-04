using System;
using System.Data;
using System.Data.SqlClient;
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
            CarregarNivel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Atualizar(txtID.Text,txtNome.Text));
            CarregarNivel();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Deletar(txtID.Text));
            CarregarNivel();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            NivelDAO nivelPesquisa = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisa.PesquisarPorNome(txtNome.Text);

            if (txtNome.Text.Equals("")) {

                CarregarNivel();
                txtID.Clear();
            }



        }

        private void TelaNivel_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            CarregarNivel();
            
        }
        private void CarregarNivel()
        {
            NivelDAO nivelPesquisa = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
        }


        // ao clicar na seleção de pesquisa busca Id e Nome e MOSTRA
        private void dgvNivel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dgvNivel.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvNivel.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgvNivel_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            //dgvNivel.Refresh();
        }
    }
}
