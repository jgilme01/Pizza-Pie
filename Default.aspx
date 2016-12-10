<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza Order</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Pizza Pie:</h1>
        <h2>Size:</h2>
        <asp:RadioButtonList ID="RBLSize" runat="server">
            <asp:ListItem Text="Large" Value="Large" />
            <asp:ListItem Text="Medium" Value="Medium" />
            <asp:ListItem Text="Small" Value="Small" />    
        </asp:RadioButtonList>

      
        <h2>Toppings:</h2>
        <asp:CheckBoxList ID="CBLToppings" runat="server">


        </asp:CheckBoxList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
