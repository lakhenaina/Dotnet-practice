private void button1_Click(object sender, EventArgs e)
{
    int number;
    if (int.TryParse(textBox1.Text, out number))
    {
        if (number % 2 == 0)
            MessageBox.Show("Even Number");
        else
            MessageBox.Show("Odd Number");
    }
    else
    {
        MessageBox.Show("Please enter a valid number");
    }
}
