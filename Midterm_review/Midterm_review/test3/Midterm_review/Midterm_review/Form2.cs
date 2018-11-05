using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_review
{
    public partial class portfolio_form : Form
    {
        public portfolio_form()
        {
            InitializeComponent();
        }

        private void portfolio_form_Load(object sender, EventArgs e)
        {
            foreach (String s in Properties.Settings.Default.array) {
                txtrich_list.Items.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            investment_form pform = new investment_form();
            pform.Show();
            this.Hide();
        }

        private void txtrich_list_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  string a = txtrich_list.SelectedItem.ToString();
            txt_stockvalue.Text = Properties.Settings.Default.valuearray[txtrich_list.SelectedIndex];
               
            txt_portvalue.Text = Properties.Settings.Default.portvalue[txtrich_list.SelectedIndex];
        }
    }
}
