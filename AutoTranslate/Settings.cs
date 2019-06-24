using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTranslate
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            Program.hotkey = domainUpDown1.Text;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.inputLang = comboBox1.Text;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.outputLang = comboBox2.Text;
        }
    }
}
