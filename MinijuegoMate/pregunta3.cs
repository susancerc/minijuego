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
    public partial class pregunta3 : Form
    {
        public pregunta3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

            pregunta4 pregunta4 = new pregunta4();
            pregunta4.Show();
        }
    }
}
