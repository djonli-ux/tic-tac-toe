using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class ticTacToe : Form
    {
        public ticTacToe()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 900;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString());
            sender.GetType().GetProperty("Text").SetValue(sender, "x");
        }
    }
}
