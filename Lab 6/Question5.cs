 (SumForm.aspx)
<html>
<head>
    <title>Sum of Two Numbers</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Enter Two Numbers</h2>

            <asp:TextBox ID="txtNum1" runat="server" placeholder="Enter first number" /><br /><br />
            <asp:TextBox ID="txtNum2" runat="server" placeholder="Enter second number" /><br /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Add" OnClick="btnSubmit_Click" /><br /><br />
            <asp:Label ID="lblResult" runat="server" Font-Bold="true" />
        </div>
    </form>
</body>
</html>

(SumForm.aspx.cs)
using System;

public partial class SumForm : System.Web.UI.Page
{
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int sum = num1 + num2;
            lblResult.Text = "Sum = " + sum;
        }
        catch
        {
            lblResult.Text = "Please enter valid numbers.";
        }
    }
}
