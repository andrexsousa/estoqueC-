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
    public partial class saida : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1GP3396;Initial Catalog=estoqueCamisetas;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader objData;
        public saida()
        {
            InitializeComponent();
        }

        int quant;
        int quantF;
        public int eS = 0;
        public string cod { get; set; }

        private void saida_Load(object sender, EventArgs e)
        {
            txtCodS.Text = this.cod;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtCodS.Text != "")
            {
                numUpDown.Enabled = true;
                btnConfirmar.Enabled = true;
                cod = txtCodS.Text;

                cmd = new SqlCommand("select * from tblCamiseta where id =" + "'" + cod + "'", con);
                con.Open();
                objData = cmd.ExecuteReader();

                if (objData.Read())
                {
                    txtDesc.Text = objData["nome"].ToString();
                    txtCor.Text = objData["cor"].ToString();
                    txtTipo.Text = objData["genero"].ToString();
                    txtCategoria.Text = objData["categoria"].ToString();
                    txtEstoque.Text = objData["quantidade"].ToString();
                    quant = Int32.Parse(txtEstoque.Text);
                    txtTamanho.Text = objData["tamanho"].ToString();
                    pctSaida.ImageLocation = objData["img"].ToString();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Campo Vazio");
            }
            
        }
        private void numUpDown_ValueChanged(object sender, EventArgs e)
        {
            switch (eS)
            {
                case 0:
                    quantF = quant - Convert.ToInt32(numUpDown.Value);
                    break;
                default:
                    quantF = quant + Convert.ToInt32(numUpDown.Value);
                    break;
            }

            txtQuantF.Text = quantF.ToString();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (eS)
            {
                case 1:
                    if (quantF > 1000)
                    {
                        MessageBox.Show("Estoque Futuro não pode ser maior que 1000");
                    }
                    if (numUpDown.Value == 0)
                    {
                        MessageBox.Show("Valor de Entrada não poder ser 0");
                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE tblCamiseta SET quantidade =" + "'" + quantF + "'" + "where id =" + "'" + cod + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Alteração efetuada\nEstoque atual " + quantF + " Itens");

                        txtEstoque.Text = quantF.ToString();
                        
                    }
                    break;
                default:
                    if (numUpDown.Value > quant)
                    {
                        MessageBox.Show("Valor de Saída não poder ser maior que o estoque");
                    }
                    else if(numUpDown.Value == 0)
                    {
                        MessageBox.Show("Valor de Saída não poder ser 0");
                        quantF = 0;
                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE tblCamiseta SET quantidade =" + "'" + quantF + "'" + "where id =" + "'" + txtCodS.Text + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Alteração efetuada\nEstoque atual " + quantF + " Itens");

                        txtEstoque.Text = quantF.ToString();
                        quantF = 0;
                    }
                    break;
            }
            
        }
        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {
            numUpDown.Value = 0;
            txtQuantF.Text = "";
        }
        private void txtCodS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
