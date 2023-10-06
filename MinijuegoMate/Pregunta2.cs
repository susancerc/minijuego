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
    public partial class Pregunta2 : Form
    {
        public Pregunta2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

            pregunta3 pregunta3 = new pregunta3();
            pregunta3.Show();
        }
    }
}
