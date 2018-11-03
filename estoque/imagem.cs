using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque
{
    public partial class imagem : Form
    {
        public imagem()
        {
            InitializeComponent();
        }

        public string img { get; set; }

        private void imagem_Load(object sender, EventArgs e)
        {
            pctWin.ImageLocation = this.img;
        }
    }
}
