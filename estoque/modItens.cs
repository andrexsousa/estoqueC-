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
    public partial class modItens : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1GP3396;Initial Catalog=estoqueCamisetas;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader objDados;

        //receber o valor do checked
        public string cor = "";
        public string tamanho = "";
        public string categoria = "";
        public string tipo = "";
        public string preco { get; set; }//para receber o preço

        public string imagem = "";
        public string descricao = "";
        public int quan = 0;
        public string cod { get; set; } //receber do datagrid
        public int alterar = 0; //controle de insert e update

    public modItens()
        {
            InitializeComponent();
        }
        private void verificarCampos()
        {
            //campo código
            if (txtCod.Text == "0")
            {
                lblCod.Text = "id 0 não permitido";
            }
            if (txtCod.Text == String.Empty)
            {
                label4.Text = "Preencha o Campo";
            }
            else
            {
                label4.Text = "";
            }
            //campo nome
            if (txtNome.Text == String.Empty)
            {
                label5.Text = "Preencha o Campo";
            }
            else
            {
                label5.Text = "";
            }
            //verifica a quantidade
            if ((numQuant.Value <= 0)||(numQuant.Value > 1000))
            {
                lblQua.Text = "Informe um valor entre 1 e 1000";
            }

            if (txtPreco.Text != "")
            {
                preco = Convert.ToDecimal(txtPreco.Text).ToString("C");
                preco = preco.Replace("R$ ", "");
                preco = preco.Replace(",", ".");
            }
            

        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty)
            {
                label5.Text = "Preencha o Campo";
            }
            else
            {
                label5.Text = "";
            }
        }
        private void numQuant_ValueChanged(object sender, EventArgs e)
        {
            if ((numQuant.Value == 0) || (numQuant.Value > 1000))
            {
                lblQua.Text = "Informe um valor entre 1 e 1000";
            }
            else
            {
                lblQua.Text = "";

            }
        }
        private void marcarRadioButtons()
        {
            // cores checked box

            if (rbBranca.Checked)
            {
                cor = "Branca";
            }
            if (rbCinza.Checked)
            {
                cor = "Cinza";
            }

            if (rbPreta.Checked)
            {
                cor = "Preta";

            }
            // tamanho

            if (rbP.Checked)
            {
                tamanho = "P";

            }
            if (rbM.Checked)
            {
                tamanho = "M";

            }
            if (rbG.Checked)
            {
                tamanho = "G";

            }
            if (rbGG.Checked)
            {
                tamanho = "GG";
            }

            // tipo
            if (rbUni.Checked)
            {
                tipo = "Unissex";

            }
            if (rbBaby.Checked)
            {
                tipo = "Baby Look";

            }

            // categoria
            if (rbRock.Checked)
            {
                categoria = "Rock";

            }
            if (rbAnime.Checked)
            {
                categoria = "Anime";

            }
            if (rbFilmes.Checked)
            {
                categoria = "Filme";

            }
            if (rbGames.Checked)
            {
                categoria = "Games";

            }
            if (rbHumor.Checked)
            {
                categoria = "Humor";

            }
            if (rbHerois.Checked)
            {
                categoria = "Heróis";

            }
        }

        private void carregarAlterar()
        {
           
            //carregando informações para alterar
            //nome
            txtNome.Text = objDados["nome"].ToString();
            //cor
            if (objDados["cor"].ToString() == "Preta")
            {
                rbPreta.Checked = true;
            }
            if (objDados["cor"].ToString() == "Cinza")
            {
                rbCinza.Checked = true;
            }
            if (objDados["cor"].ToString() == "Branca")
            {
                rbBranca.Checked = true;
            }
            //tipo
            if (objDados["genero"].ToString() == "Baby Look")
            {
                rbBaby.Checked = true;
            }
            if (objDados["genero"].ToString() == "Unissex")
            {
                rbUni.Checked = true;
            }
            //tamanho
            if (objDados["tamanho"].ToString() == "P")
            {
                rbP.Checked = true;
            }
            if (objDados["tamanho"].ToString() == "M")
            {
                rbM.Checked = true;
            }
            if (objDados["tamanho"].ToString() == "G")
            {
                rbG.Checked = true;
            }
            if (objDados["tamanho"].ToString() == "GG")
            {
                rbGG.Checked = true;
            }
            //categoria
            if (objDados["categoria"].ToString() == "Rock")
            {
                rbRock.Checked = true;
            }
            if (objDados["categoria"].ToString() == "Anime")
            {
                rbAnime.Checked = true;
            }
            if (objDados["categoria"].ToString() == "Heróis")
            {
                rbHerois.Checked = true;
            }
            if (objDados["categoria"].ToString() == "Games")
            {
                rbGames.Checked = true;
            }
            if (objDados["categoria"].ToString() == "Filme")
            {
                rbFilmes.Checked = true;
            }
            if (objDados["categoria"].ToString() == "Humor")
            {
                rbHumor.Checked = true;
            }
            //preço
            txtPreco.Text = objDados["preco"].ToString();

            //quantidade
            quan = Convert.ToInt32(objDados["quantidade"]);
            numQuant.Value = quan;
            txtEstoque.Text = quan.ToString();
            //foto
            lblImg.Text = objDados["img"].ToString();
            pctFoto.ImageLocation = lblImg.Text;
            //pctFoto.Load();
            label2.Text = "Alterar";
            btnNovo.Enabled = true;
            this.txtCod.Enabled = false;
            alterar = 1;
        }
        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            verificarCampos();
            marcarRadioButtons();
            
            //validando campos vazios
            if ((cor == "") || (tamanho == "") || (tipo == "") || (categoria == "") || (txtNome.Text == "") || (txtCod.Text == "") || (txtCod.Text == "0") || (numQuant.Value == 0) || (numQuant.Value > 1000))
            {
                MessageBox.Show("Por favor, Preencha Todos os Campos");
            }
            else if (alterar == 0)
            {
                con.Open();
                cmd = new SqlCommand("insert into tblCamiseta (id, nome, cor, tamanho, categoria, genero, preco, quantidade, img) values('" + txtCod.Text + "','" + txtNome.Text + "','" + cor + "','" + tamanho + "','" + categoria + "','" + tipo + "','" + preco + "','" + numQuant.Value + "','" + lblImg.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Item Cadastrado!", "Aviso");

                LimparNovo();
            }
            else
            {
                cmd = new SqlCommand("UPDATE tblCamiseta SET nome=" + "'" + txtNome.Text + "'" + "," + "cor=" + "'" + cor + "'" + "," + "tamanho=" + "'" + tamanho + "'" + "," + "categoria=" + "'" + categoria + "'" + "," + "genero=" + "'" + tipo + "'" + "," + "preco=" + "'" + preco + "'" + "," + "quantidade=" + "'" + numQuant.Value + "'" + "," + "img=" + "'" + lblImg.Text + "'" + "where id=" + "'" + txtCod.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Item Salvo !", "Aviso");

                LimparNovo();
                
            }
        }

        private void Limpar()
        {
            txtNome.Clear();
            txtPreco.Clear();
            numQuant.Value = 0;
            lblPre.Text = "";
            lblQua.Text = "";
            label5.Text = "";
        }

        private void LimparNovo()
        {
            txtCod.Enabled = true;
            btnNovo.Enabled = false;
            label2.Text = "Novo";
            txtCod.Clear();
            txtEstoque.Clear();
            txtCod.Focus();
            Limpar();
            lblImg.Text = "";
            pctFoto.ImageLocation = "";
            alterar = 0;
        }
       
 
        private void button3_Click(object sender, EventArgs e)
        {
            LimparNovo();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                pctFoto.ImageLocation = ofdFoto.FileName;
                pctFoto.Load();
                lblImg.Text = ofdFoto.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblImg.Text = "";
            pctFoto.ImageLocation = "";

        }

        private void modItens_Load(object sender, EventArgs e)
        {
            
            txtCod.Text = this.cod;
            txtPreco.Text = this.preco;
            lblImg.Text = this.imagem;
            pctFoto.ImageLocation = this.imagem;
            numQuant.Value = this.quan;
            txtEstoque.Text = this.quan.ToString();
            txtNome.Text = this.descricao;

            //carregando informações do grid
            //cor
            if(cor == "Preta")
            {
                rbPreta.Checked = true;
            }
            if (cor == "Branca")
            {
                rbBranca.Checked = true;
            }
            if (cor == "Cinza")
            {
                rbCinza.Checked = true;
            }
            //tipo
            if (tipo == "Unissex")
            {
                rbUni.Checked = true;
            }
            if (tipo == "Baby Look")
            {
                rbBaby.Checked = true;
            }
            //tamanho
            if(tamanho == "P")
            {
                rbP.Checked = true;
            }
            if (tamanho == "M")
            {
                rbM.Checked = true;
            }
            if (tamanho == "G")
            {
                rbG.Checked = true;
            }
            if (tamanho == "GG")
            {
                rbGG.Checked = true;
            }
            //Categoria
            if(categoria == "Rock")
            {
                rbRock.Checked = true;
            }
            if (categoria == "Anime")
            {
                rbAnime.Checked = true;
            }
            if (categoria == "Filme")
            {
                rbFilmes.Checked = true;
            }
            if (categoria == "Humor")
            {
                rbHumor.Checked = true;
            }
            if (categoria == "Games")
            {
                rbGames.Checked = true;
            }
            if (categoria == "Heróis")
            {
                rbHerois.Checked = true;
            }
        }

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}",v);
                txt.SelectionStart = txt.Text.Length;

            }
            catch (Exception)
            {
                

            }
        }
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            if (txtPreco.Text == "")
            {
                lblPre.Text = "Preencha o Campo";
            }
            else
            {
                lblPre.Text = "";
            }
            
            Moeda(ref txtPreco);
        }
        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void txtCod_Leave_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblCamiseta where id =" + "'" + txtCod.Text + "'", con);
            con.Open();
            objDados = cmd.ExecuteReader();

            if (objDados.Read())
            {
                if (MessageBox.Show("Item Já Cadastrado\nDeseja realizar alterações?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    txtCod.Clear();
                    txtCod.Focus();
                }
                else
                {
                    carregarAlterar();

                }
            }

            con.Close();
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text == String.Empty)
            {
                label4.Text = "Preencha o Campo";
            }
            else
            {
                label4.Text = "";
            }
            if (txtCod.Text == "0")
            {
                label4.Text = "id 0 não permitido";
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
