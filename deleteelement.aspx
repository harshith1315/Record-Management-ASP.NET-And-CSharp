<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deleteelement.aspx.cs" Inherits="WebApplication1.deleterecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Record</title>
    <style>
        body{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Delete Record</h1>
            <label for="dname" runat="server">Name:</label>
            <asp:TextBox ID="dname" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="db" runat="server" Text="Submit" OnClick="Remove"/>
            <label id="error" runat="server" visible="false"></label>
        </div>
    </form>
</body>
</html>
