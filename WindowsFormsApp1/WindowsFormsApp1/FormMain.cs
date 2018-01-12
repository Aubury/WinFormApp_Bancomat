using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        FormInfo bancomat = new FormInfo();
        Form_Bancomat Display_of_bancomat = new Form_Bancomat();
        public FormMain()
        {
            InitializeComponent();
            this.Text = "Info_window!";
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            bancomat.MdiParent = this;
            bancomat.Show();
            Display_of_bancomat.MdiParent = this;
            Display_of_bancomat.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          bancomat.Close();
           Display_of_bancomat.Close();

        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
