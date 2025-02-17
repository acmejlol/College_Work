namespace kalkuliatorius
{
    public partial class SuperDupeCalculator : Form
    {
        public SuperDupeCalculator()
        {
            InitializeComponent();
        }

        string CalTotal;
        decimal num1;
        decimal num2;
        string option;
        decimal result;

        private Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtbox.Text);

            txtbox.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn7.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn3.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn0.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn6.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn8.Text;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + btn9.Text;
        }
        private void btnplius_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = decimal.Parse(txtbox.Text);

            txtbox.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = decimal.Parse(txtbox.Text);

            txtbox.Clear();
        }

        private void btndal_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = decimal.Parse(txtbox.Text);

            txtbox.Clear();
        }

        private void btnlygu_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(txtbox.Text);

            if (option == ("+"))
                result = num1 + num2;
            if (option == ("-"))
                result = num1 - num2;
            if (option == ("*"))
                result = num1 * num2;
            if (option == ("/"))
                result = num1 / num2;

            txtbox.Text = result + "";
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            txtbox.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrdmn_Click(object sender, EventArgs e)
        {
            int randomNumber = random.Next(0, 9999);
            txtbox.Text = txtbox.Text + randomNumber;
        }

        private void btnrdms_Click(object sender, EventArgs e)
        {
            Button[] buttons = { btndal, btnminus, btnplius, btndaug };

            int randomSign = random.Next(0, buttons.Length);
            Button selectedButton = buttons[randomSign];

            selectedButton.PerformClick();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }
    }
}