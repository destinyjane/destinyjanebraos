using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApplication
{
    public partial class Main : Form
    {
        private SubMain subMain;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            subMain = new SubMain();
            subMain.mainForm = this;
            subMain.Show();
        }

    }
}
