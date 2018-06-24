using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Solution solution = new Solution();

       

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(tbA.Text);
                int B = Convert.ToInt32(tbB.Text);
                label_Answer.Text = "Answer = ";
                label_Answer.Text += " " + (solution.solution(A, B)).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Attention! You enter a letter.\n Please, enter number!!!");
            }
        }
    }
}
