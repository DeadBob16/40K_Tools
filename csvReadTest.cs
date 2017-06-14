using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVS_test
{
    public partial class csvReadTest : Form
    {
        public csvReadTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 100);

            if (roll >= 75)
            {
                roll = rnd.Next(1, 100) + 75;
            }

            int lineNum = roll;

            var lines = File.ReadAllLines("D:/Warhammer 40K RP/- My Apps/Test projects/CVS test/CVS test/data/PerilsOfTheWarp.csv");
            var line = lines[lineNum];

            richTextBox1.Text = line;
        }
    }
}
