 (EvenOddForm.aspx)
<html>
<head>
    <title>Even or Odd Checker</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Enter a Number</h2>
            <asp:TextBox ID="txtNum" runat="server" placeholder="Enter number" /><br /><br />
            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" /><br /><br />
            <asp:Label ID="lblResult" runat="server" Font-Bold="true" />
        </div>
    </form>
</body>
</html>

(EvenOddForm.aspx.cs)
using System;

public partial class EvenOddForm : System.Web.UI.Page
{
    protected void btnCheck_Click(object sender, EventArgs e)
    {
        try
        {
            int num = int.Parse(txtNum.Text);
            if (num % 2 == 0)
                lblResult.Text = "Even";
            else
                lblResult.Text = "Odd";
        }
        catch
        {
            lblResult.Text = "Please enter a valid number.";
        }
    }
}
