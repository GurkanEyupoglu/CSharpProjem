namespace KursUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Text.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secili = listBox1.Items[listBox1.SelectedIndex].ToString();
            comboBox1.Items.Add(secili);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.BackColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string aktarilan = listBox3.Items[listBox3.SelectedIndex].ToString();
            listBox4.Items.Add(aktarilan);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string aktarlilan2 = listBox4.Items[listBox4.SelectedIndex].ToString();
            listBox5.Items.Add(aktarlilan2);
        }
    }
}