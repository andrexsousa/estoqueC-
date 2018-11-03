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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1GP3396;Initial Catalog=estoqueCamisetas;Integrated Security=True");

        private void loginValidate()
        {
            if (txtEmail.Text == "")
            {
                lblEmail.Text = "Digite um nome de usuário!";
            }

            else
            {
                lblEmail.Text = "";
            }
            if (txtSenha.Text == "")
            {
                lblSenha.Text = "Digite a senha";
            }
            else
            {
                lblSenha.Text = "";
            }

            if ((txtSenha.Text == "") || (txtEmail.Text == ""))
            {
                lblAviso.Text = "Preencha Todos os Campos";
            }
            else
            {

                SqlDataAdapter da = new SqlDataAdapter("select count(*) from tblLogin where Email =" + "'" + txtEmail.Text + "'" + "and senha =" + "'" + txtSenha.Text + "'", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Form1 f2 = new Form1();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("Senha Inválida");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginValidate();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != "")
            {
                lblSenha.Text = "";
            }
            else
            {
                lblSenha.Text = "Digite a senha";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                lblSenha.Text = "Digite a senha";
            }
            else
            {
                lblSenha.Text = "";
            }

            focus1 = true;
            this.Refresh();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loginValidate(); 
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                loginValidate();
            }
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        bool focus = false;
        bool focus1 = true;
        private void login_Paint(object sender, PaintEventArgs e)
        {
            if(focus)
            {
                txtEmail.BorderStyle = BorderStyle.None;
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(new Pen(Brushes.LightGray), txtEmail.Location.X - 1, txtEmail.Location.Y - 1, txtEmail.Width + 2, txtEmail.Height + 2);
            }
            else
            {
                
                txtEmail.BorderStyle = BorderStyle.None;
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(new Pen(Brushes.Orange), txtEmail.Location.X - 1, txtEmail.Location.Y - 1, txtEmail.Width + 2, txtEmail.Height + 2);
            }

            if (focus1)
            {
                txtSenha.BorderStyle = BorderStyle.None;
                Graphics h = this.CreateGraphics();
                h.DrawRectangle(new Pen(Brushes.LightGray), txtSenha.Location.X - 1, txtSenha.Location.Y - 1, txtSenha.Width + 2, txtSenha.Height + 2);
            }
            else
            {
                txtSenha.BorderStyle = BorderStyle.None;
                Graphics h = this.CreateGraphics();
                h.DrawRectangle(new Pen(Brushes.Orange), txtSenha.Location.X - 1, txtSenha.Location.Y - 1, txtSenha.Width + 2, txtSenha.Height + 2);
            }
            
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
           
            focus = false;
            this.Refresh();
        }

        private void txtEmail_Leave_1(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from tblLogin where Email =" + "'" + txtEmail.Text + "'", con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "0")
            {
                lblEmail.Text = "Email Inválido ou inexistente!";
                if (txtEmail.Text == "")
                {
                    lblEmail.Text = "Digite um email";
                }

            }
            else
            {
                lblEmail.Text = "";
            }

            focus = true;
            this.Refresh();
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            focus1 = false;
            this.Refresh();
            this.txtSenha.PasswordChar = '•';
        }
    }
}
