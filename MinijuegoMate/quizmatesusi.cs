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
    public partial class quizmatesusi : Form
    {
        public quizmatesusi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Pregunta2 pregunta2 = new Pregunta2();
            pregunta2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
