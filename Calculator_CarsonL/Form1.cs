namespace Calculator_CarsonL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "2";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "6";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "9";
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "-";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "/";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text += "*";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                object calculation = new System.Data.DataTable().Compute(result.Text, "");
                result.Text = calculation.ToString();
            }
            catch (Exception ex)
            {
                result.Text = "Error";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (result.Text == "Error") result.Text = "";
            result.Text = "";
        }
    }
}
