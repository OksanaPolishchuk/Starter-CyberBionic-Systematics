using System;
using System.Windows.Forms;

namespace lesson8Ex4
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton3.Checked = true;
            radioButton4.Checked = true;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = 0, value2;
            double sum = 0;
            string a = textBox1.Text;
            int.TryParse(a, out value1);
            string b = textBox2.Text;
            int.TryParse(b, out value2);

            if (radioButton1.Checked)
            {
                sum = value1 % value2;
                string sum2 = sum.ToString();
                MessageBox.Show(sum2);
            }
            if (radioButton2.Checked)
            {
                sum = Math.Pow(value1, value2);
                string sum2 = sum.ToString();
                MessageBox.Show(sum2);
            }
            if (radioButton3.Checked)
            {
                string sum2 = String.Concat(a, b);
                MessageBox.Show(sum2);
            }
            if (radioButton4.Checked)
            { 
                if (value2 <= 0)
                {
                    MessageBox.Show(" Error.You are trying to divide by '0'");
                }
                else
                {
                    sum = value1 / value2;
                    string sum2 = sum.ToString();
                    MessageBox.Show(sum2);
                }
            }
        }
    }
}
