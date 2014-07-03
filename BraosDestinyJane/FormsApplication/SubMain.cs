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
    public partial class SubMain : Form
    {
        public int mainNumber;
        public Main mainForm;

        public SubMain()
        {
            InitializeComponent();
        }

        private void SubMain_Load(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int number;

            try
            {
                number = int.Parse(numberBox.Text);
                mainNumber = int.Parse(mainForm.resultButton.Text);
                mainForm.resultButton.Text = (mainNumber + number).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("WRONG!!!!!!!!!!\n\nNUMBER ONLY.....!!!!!!!!!!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.numberBox.Text = "";
            this.Close();
        }
    }
}
