namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result = 0;
        bool isoperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true) { textBox1.Clear(); }

            if (but.Text == ".")
            {

                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but.Text; }
            }
            else { textBox1.Text = textBox1.Text + but.Text; }
            isoperation = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            result = double.Parse(textBox1.Text);
            isoperation = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString(); break;

                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString(); break;

                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString(); break;

                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString(); break;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abdalbare","Mazen_Abdulsalam",MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
