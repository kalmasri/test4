using Midterm_review.DataSet1TableAdapters;
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
    public partial class investment_form : Form
    {

        DataSet1 ds;
        stockTableAdapter st;
        stockTableAdapter st2;

        int random;
        List<String> list;


        public investment_form()
        {
            InitializeComponent();
            Properties.Settings.Default.array = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.valuearray = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.portvalue = new System.Collections.Specialized.StringCollection();

            //insert();
        }

        private void get_data()
        {
            ds = new DataSet1();

            st = new stockTableAdapter();
            st.Fill(ds.stock);
        }


        private void insert()
        {
            get_data();


            DataSet1.stockRow sr1 = ds.stock.NewstockRow();
            DataSet1.stockRow sr2 = ds.stock.NewstockRow();
            DataSet1.stockRow sr3 = ds.stock.NewstockRow();
            DataSet1.stockRow sr4 = ds.stock.NewstockRow();
            DataSet1.stockRow sr5 = ds.stock.NewstockRow();

            Random rnd = new Random();
            
            sr1.s_name = "Yahoo";
            sr1.s_symbol = "YAY";
            sr1.s_notes = "Yahoo search engine";
            sr1.s_type = "index";
            sr1.s_value = rnd.Next(30, 1500);
            sr1.stocks = decimal.Parse("200");



            ds.stock.AddstockRow(sr1);


            generate_random();


            sr2.s_name = "GameThornes";
            sr2.s_symbol = "GTHO";
            sr2.s_notes = "TV series";
            sr2.s_type = "blue chip";
            sr2.s_value = rnd.Next(30, 1500);
            sr2.stocks = decimal.Parse("400");



            ds.stock.AddstockRow(sr2);

            generate_random();

            sr3.s_name = "USDollar";
            sr3.s_symbol = "USD";
            sr3.s_notes = "American Currency";
            sr3.s_type = "currency";
            sr3.s_value = rnd.Next(0, 30);
            sr3.stocks = decimal.Parse("50000");



            ds.stock.AddstockRow(sr3);


            generate_random();

            sr4.s_name = "CDNDollar";
            sr4.s_symbol = "CDN";
            sr4.s_notes = "Canadian Currency";
            sr4.s_type = "currency";
            sr4.s_value = rnd.Next(0, 30);
            sr4.stocks = decimal.Parse("30000");



            ds.stock.AddstockRow(sr4);

            generate_random();

            sr5.s_name = "Euro";
            sr5.s_symbol = "Euro";
            sr5.s_notes = "Eurpoean Currency";
            sr5.s_type = "index";
            sr5.s_value = rnd.Next(50, 100);
            sr5.stocks = decimal.Parse("60000");



            ds.stock.AddstockRow(sr5);


            st.Update(ds.stock);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            portfolio_form pform = new portfolio_form();
            pform.Show();
            this.Hide();
        }

        private void investment_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            get_data();
            DataRow[] dr = ds.stock.Select("s_symbol = '" + txt_symbol.Text + "'");

            if (dr.Length == 0)
            {

                errorProvider1.SetError(txt_symbol, "Symbol Not found");
            }
            else
            {
                foreach (DataRow d in dr)
                {
                    txtrich_notes.Text = d[2].ToString();
                    combo_type.Text = d[3].ToString();
                    lbl_value.Text = d[4].ToString();
                }
            }

        }

        private void generate_random()
        {

       

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btn_purchase_Click(object sender, EventArgs e)

        {
            String name ="";

            get_data();
            DataRow[] dr = ds.stock.Select("s_symbol = '" + txt_symbol.Text + "'");

            foreach (DataRow d in dr)
            {
                name = d[0].ToString();
                
            }


            if (radioButton1.Checked == true)
            {
                String one ="";

                int amount = int.Parse(txt_amount.Text);
                String val = lbl_value.Text;
                Double value = Double.Parse(val);

                one = name + " (" + txt_symbol.Text + ", " + amount + ") ";

                double port = amount * value;
                Properties.Settings.Default.valuearray.Add(val);
                Properties.Settings.Default.portvalue.Add(port.ToString());
                Properties.Settings.Default.array.Add(one);


            }
            
            if (radioButton2.Checked == true)
            {
                String one ="";

                int amount = int.Parse(txt_amount.Text);
                String val = lbl_value.Text;
                Double value = Double.Parse(val);
                Double amount2 = amount / value;

                one = name + " (" + txt_symbol.Text + ", " + amount2 + ") ";

                Properties.Settings.Default.valuearray.Add(val);
                Properties.Settings.Default.portvalue.Add(amount2.ToString());
                Properties.Settings.Default.array.Add(one);

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
