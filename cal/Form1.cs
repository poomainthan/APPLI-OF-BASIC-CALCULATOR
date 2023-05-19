namespace cal
{
    public partial class CALCULATOR : Form
    {
        private decimal valuefirst = 0.0m;
        private decimal valuesecond = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";


        public CALCULATOR()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text = textBox1.Text + "0";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            textBox1.Text = text.Remove(text.Length - 1);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "%";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    valuesecond = decimal.Parse(textBox1.Text);
                    result = valuefirst + valuesecond;
                    textBox1.Text = result.ToString();
                    break;

                case "-":
                    valuesecond = decimal.Parse(textBox1.Text);
                    result = valuefirst - valuesecond;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    valuesecond = decimal.Parse(textBox1.Text);
                    result = valuefirst * valuesecond;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    valuesecond = decimal.Parse(textBox1.Text);
                    result = valuefirst / valuesecond;
                    textBox1.Text = result.ToString();
                    break;
                case "%":
                    valuesecond = decimal.Parse(textBox1.Text);
                    result = valuefirst % valuesecond;
                    textBox1.Text = result.ToString();
                    break;


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "/";
        }
    }
}