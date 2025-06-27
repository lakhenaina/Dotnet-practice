private void button1_Click(object sender, EventArgs e)
{
    double p, t, r;
    if (double.TryParse(textBox1.Text, out p) &&
        double.TryParse(textBox2.Text, out t) &&
        double.TryParse(textBox3.Text, out r))
    {
        double si = (p * t * r) / 100;
        label1.Text = "Simple Interest = " + si;
    }
    else
    {
        MessageBox.Show("Enter valid numbers");
    }
}
