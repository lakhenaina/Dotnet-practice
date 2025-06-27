// Addition
private void btnAdd_Click(object sender, EventArgs e)
{
    double a = Convert.ToDouble(textBox1.Text);
    double b = Convert.ToDouble(textBox2.Text);
    MessageBox.Show("Result: " + (a + b));
}

// Subtraction
private void btnSubtract_Click(object sender, EventArgs e)
{
    double a = Convert.ToDouble(textBox1.Text);
    double b = Convert.ToDouble(textBox2.Text);
    MessageBox.Show("Result: " + (a - b));
}

// Multiplication
private void btnMultiply_Click(object sender, EventArgs e)
{
    double a = Convert.ToDouble(textBox1.Text);
    double b = Convert.ToDouble(textBox2.Text);
    MessageBox.Show("Result: " + (a * b));
}

// Division
private void btnDivide_Click(object sender, EventArgs e)
{
    double a = Convert.ToDouble(textBox1.Text);
    double b = Convert.ToDouble(textBox2.Text);
    if (b != 0)
        MessageBox.Show("Result: " + (a / b));
    else
        MessageBox.Show("Cannot divide by zero");
}
