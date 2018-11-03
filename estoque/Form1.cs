using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace estoque
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1GP3396;Initial Catalog=estoqueCamisetas;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            modItens Tela = new modItens();
            Tela.ShowDialog();
            
        }
        private void buscarTudo()
        {
            adpt = new SqlDataAdapter("select * from tblCamiseta", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvData.DataSource = dt;
        }
        public void buscarPorId()
        {
            adpt = new SqlDataAdapter("select * from tblCamiseta where id =" + txtSrc.Text, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvData.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueCamisetasDataSet.tblCamiseta' table. You can move, or remove it, as needed.
            //this.tblCamisetaTableAdapter.Fill(this.estoqueCamisetasDataSet.tblCamiseta);
            buscarTudo();
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            if (txtSrc.Text != "")
            {
                buscarPorId();
            }
            else
            {
                MessageBox.Show("Campo em Branco!");
            }


        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
            login tlogin = new login();
            tlogin.Show();

        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Nenhum Item Selecionado","Aviso");
            }
            else
            {
                if (MessageBox.Show("Deseja Alterar\n" + dgvData.CurrentRow.Cells[1].Value.ToString() + "? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    modItens Tela = new modItens();
                    Tela.cod = dgvData.CurrentRow.Cells[0].Value.ToString();
                    Tela.descricao = dgvData.CurrentRow.Cells[1].Value.ToString();
                    Tela.cor = dgvData.CurrentRow.Cells[2].Value.ToString();
                    Tela.tamanho = dgvData.CurrentRow.Cells[3].Value.ToString();
                    Tela.categoria = dgvData.CurrentRow.Cells[4].Value.ToString();
                    Tela.tipo = dgvData.CurrentRow.Cells[5].Value.ToString();
                    Tela.preco =dgvData.CurrentRow.Cells[6].Value.ToString();
                    Tela.quan = Convert.ToInt32(dgvData.CurrentRow.Cells[7].Value);
                    Tela.imagem = dgvData.CurrentRow.Cells[8].Value.ToString();
                    Tela.txtCod.Enabled = false;
                    Tela.label2.Text = "Alterar";
                    Tela.btnNovo.Enabled = true;
                    Tela.alterar = 1;
                    Tela.ShowDialog();

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarTudo();
        }
        private void txtSrc_MouseClick(object sender, MouseEventArgs e)
        {
            
          /*txtSrc.SelectionStart = 0;
           txtSrc.SelectAll();*/
        }


        private void txtSrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtSrc.Text != "")
                {
                    buscarPorId();
                }
                else
                {
                    MessageBox.Show("Campo em Branco!");
                }
            }
        }

       
        //ver Foto
        private void button1_Click_2(object sender, EventArgs e)
        {
                if(dgvData.CurrentRow != null)
            {
                imagem foto = new imagem();
                foto.img = dgvData.CurrentRow.Cells[8].Value.ToString();
                foto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum Item Selecionado!","Aviso");
            }
                
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dgvData.CurrentRow == null)
            {
                MessageBox.Show("Nenhum Item Selecionado","Aviso");
            }
            else
            { 
                if (MessageBox.Show("Deseja realmente excluir\n" + dgvData.CurrentRow.Cells[1].Value.ToString() + "? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE tblCamiseta WHERE id=" + "'" + dgvData.CurrentRow.Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Item Excluído!", "Aviso");

                    buscarTudo();
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnFoto.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            lblData.Text = dataHora.ToShortDateString() + "  " +dataHora.ToShortTimeString();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow != null)
            {
                saida saida = new saida();
                saida.cod = dgvData.CurrentRow.Cells[0].Value.ToString();
                saida.eS = 0;
                saida.ShowDialog();
            }
            
        }
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if(dgvData.CurrentRow != null)
            {
                saida saida = new saida();
                saida.cod = dgvData.CurrentRow.Cells[0].Value.ToString();
                saida.lblEntradaSaida.Text = "Entrada";
                saida.lblQuant.Text = "Quantidade de Entrada";
                saida.eS = 1;
                saida.ShowDialog();
            }
            
        }

        private void txtSrc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)

            {

                e.Handled = true;

            }
            if (e.KeyChar == 13)
            {
                if (txtSrc.Text != "")
                {
                    buscarPorId();
                }
                else
                {
                    MessageBox.Show("Campo em Branco!");
                }
            }
        }
    }
}
