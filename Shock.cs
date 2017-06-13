using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40k_GM_Kit
{
    public partial class Shock : Form
    {
        public Shock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shockDesc.Text = "";

            Random rnd = new Random();
            int roll = rnd.Next(1, 100);
            int val = roll + (10 * Convert.ToInt32(this.degFail.Text));

            
        }
    }
}
