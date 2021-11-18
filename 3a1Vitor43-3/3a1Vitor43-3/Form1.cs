using System;
using System.Windows.Forms;

namespace _3a1Vitor43_3
{
    public partial class Form1 : Form
    {
        Loja objLoja = new Loja();
        public FrLoja()
        {
            InitializeComponent();
            dtgLoja.DataSource = objCurso.ListarLoja();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objCurso.nomeFuncionario = txtNomeCurso.Text;
            objCurso.nomeCargo = txtNomeCargo.Text;
            objCurso.nomeDescricao = txtNomeDescricao.Text;
            objCurso.nomeHoras = txtNomeHoras.Int;
            objCurso.nomeCadastro = txtNomeCadastro.Text;

            objCurso.CadastrarCurso();

            MessageBox.Show("Registro realizado com sucesso!");

            txtNomeCurso.Clear();
            txtNomeCargo.Clear();
            txtNomeDescricao.Clear();
            txtNomeHoras.Clear();
            txtNomeCadastro.Clear();
        }
    }
}
