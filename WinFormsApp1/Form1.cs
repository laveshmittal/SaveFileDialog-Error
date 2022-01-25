using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Random selection (*.rpc)|*.rpc";
            saveFileDialog.ShowHelp = true;
            saveFileDialog.HelpRequest += (object sender, EventArgs eventArgs) =>{};
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                WithHelpFileName.Text = saveFileDialog.FileName;
            }
            else
            {
                WithHelpFileName.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Random selection (*.rpc)|*.rpc";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                WithoutHelpFileName.Text = saveFileDialog.FileName;
            }
            else
            {
                WithoutHelpFileName.Text = "";
            }
        }
    }
}
