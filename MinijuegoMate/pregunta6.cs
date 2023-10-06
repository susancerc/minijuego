using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinijuegoMate
{
    public partial class pregunta6 : Form
    {
        public pregunta6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

            pregunta7 pregunta7 = new pregunta7();
            pregunta7.Show();
        }
    }
}
