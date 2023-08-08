using System.Data;

namespace HW1_Calculator
{
    public partial class Form1 : Form
    {
        private bool idle = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void genericButton_Click(object sender, EventArgs e)
        {
            if (idle)
            {
                textBox1.Clear();
            }
            textBox1.Text += (sender as Button).Text;
            idle = false;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var res = cal(textBox1.Text);
            textBox1.Text += " = " + res.ToString();
            idle = true;
        }

        private object cal(string text)
        {
            DataTable dt = new DataTable();
            var v = new object();
            try
            {
                v = dt.Compute(text, "");
            }
            catch (Exception e)
            {
                v = "NaN";
            }

            return v;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            textBox1.Clear();
        }
    }
}