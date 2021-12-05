using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDI_Evaluation
{
    public partial class FormProblems : Form
    {
        public FormProblems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form = new FormCurrencyConverter();
            Form.ShowDialog();

            Form.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form = new FormRobotLoop();
            Form.ShowDialog();

            Form.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
