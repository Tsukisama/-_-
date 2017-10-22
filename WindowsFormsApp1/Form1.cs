using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cows;





namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userDigit;
            if ((int.TryParse(textBox1.Text, out userDigit)) != true)
            MessageBox.Show("Вы вводите не число!");        
            label2.Text = Cows.Program.CowCounter(userDigit);
            
        }
}
}
