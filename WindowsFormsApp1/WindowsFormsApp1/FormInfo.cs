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
    public partial class FormInfo : Form
    {
     //   public event EventHandler<AccountEventArgs> Not_enough_money;
        public FormInfo()
        {
            InitializeComponent();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            Address.AutoCompleteCustomSource = source;
            Address.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Address.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Address.TextChanged += Address_TextChanged;
        }
       
      
        private void Form2_Load_1(object sender, EventArgs e)
        {
          
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            var rez = Convert.ToString(Address.Text);
            Address.Clear();
            Bancomat.Address = rez;
            Address.Text = Bancomat.Show_address();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           decimal sum = int.Parse(textBox1.Text);
            Bancomat.Put_money(sum);
            textBox1.Text = Bancomat.Show_current_amount();
           
        }
    }
}
