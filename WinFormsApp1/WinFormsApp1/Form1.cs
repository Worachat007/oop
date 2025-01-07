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
            string inputnum1 = Num1.Text;
            string inputnum2 = Num2.Text;
            float input1 = float.Parse(inputnum1);
            float input2 = float.Parse(inputnum2);
            float plus = input1 + input2;
            result.Text = plus.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputnum1 = Num1.Text;
            string inputnum2 = Num2.Text;
            float input1 = float.Parse(inputnum1);
            float input2 = float.Parse(inputnum2);
            float plus = input1 - input2;
            result.Text = plus.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputnum1 = Num1.Text;
            string inputnum2 = Num2.Text;
            float input1 = float.Parse(inputnum1);
            float input2 = float.Parse(inputnum2);
            float plus = input1 * input2;
            result.Text = plus.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputnum1 = Num1.Text;
            string inputnum2 = Num2.Text;
            float input1 = float.Parse(inputnum1);
            float input2 = float.Parse(inputnum2);
            float plus = input1 / input2;
            result.Text = plus.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Num1.Clear();
            Num2.Clear();
            result.Clear();
        }
    }
}
