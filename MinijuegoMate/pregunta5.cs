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
    public partial class pregunta5 : Form
    {
        public pregunta5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

            pregunta6 pregunta6 = new pregunta6();
            pregunta6.Show();
        }
    }
}
