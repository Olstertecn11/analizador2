namespace Proyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(253, 253, 253);
            button1.ForeColor = Color.FromArgb(13, 184, 168);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(13, 184, 168);
            button1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Analyzer anal = new Analyzer(txt_input.Text);
            if (anal.done == true)
            {
                string text = anal.output.ToString();
                txt_output.Text = text;
            }
            else
            {
                MessageBox.Show("Error in proccess");
            }
        }
    }
}