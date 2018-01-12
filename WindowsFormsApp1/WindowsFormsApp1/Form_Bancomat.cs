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
    public partial class Form_Bancomat : Form
    {
        int sum_withraw;
        FormInfo infobank = new FormInfo();
        public Form_Bancomat()
        {
            InitializeComponent();
           // infobank.Not_enough_money+= B_Not_enough_money;
            //b.Not_enough_money += B_Not_enough_money;
        }

        private void B_Not_enough_money(object sender, AccountEventArgs e)
        {
            info_display.Text=$"At ATM not enough money";

        }

        private void INPUT_AMOUNT_MouseClick(object sender, MouseEventArgs e)
        {
            INPUT_AMOUNT.Clear();
        }

        private void INPUT_AMOUNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Withraw_Click(object sender, EventArgs e)
        {
          //  info_display.Text = $"Current amount : {Bancomat.Show_current_amount()}";
            sum_withraw = int.Parse(INPUT_AMOUNT.Text);
            
            var current_amount=Bancomat.Withdraw(sum_withraw);
             info_display.Text = current_amount;
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
