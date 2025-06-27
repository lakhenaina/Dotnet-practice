 (ValidationForm.aspx)
<html>
<head>
    <title>Validation Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registration Form</h2>

            Name: 
            <asp:TextBox ID="txtName" runat="server" /><br />
            <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                ControlToValidate="txtName"
                ErrorMessage="Name is required" 
                ForeColor="Red" /><br /><br />

            Email: 
            <asp:TextBox ID="txtEmail" runat="server" /><br />
            <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                ControlToValidate="txtEmail"
                ValidationExpression="\w+@\w+\.\w+"
                ErrorMessage="Invalid Email Address"
                ForeColor="Red" /><br /><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" /><br />
        </div>
    </form>
</body>
</html>
