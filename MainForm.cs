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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void perilsOpen_Click(object sender, EventArgs e)
        {
            PerilsForm form = new PerilsForm();

            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Show(this);
        }

        private void critOpen_Click(object sender, EventArgs e)
        {
            DH1_CritForm form = new DH1_CritForm();

            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Show(this);
        }

        private void shockOpen_Click(object sender, EventArgs e)
        {
            Shock form = new Shock();

            form.Tag = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Show(this);
        }
    }
}
