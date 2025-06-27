private void button1_Click(object sender, EventArgs e)
{
    int start, end;
    if (int.TryParse(textBox1.Text, out start) && int.TryParse(textBox2.Text, out end))
    {
        textBox3.Clear();
        for (int i = start; i <= end; i++)
        {
            textBox3.AppendText(i.ToString() + Environment.NewLine);
        }
    }
    else
    {
        MessageBox.Show("Enter valid numbers in both fields.");
    }
}
