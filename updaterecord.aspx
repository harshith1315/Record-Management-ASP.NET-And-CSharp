<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updaterecord.aspx.cs" Inherits="WebApplication1.updaterecord" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="placeholder" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Record</title>
    <style>
        body{
            text-align:center;
        }
    </style>
</head>
<body>
    <h1>Update Record</h1>
    <form id="form1" runat="server">
     <label for="uname">Record number:</label>
    <asp:TextBox ID="rnum" runat="server"></asp:TextBox><br /><br />
    &nbsp<label for="uname">Name:</label>&nbsp 
    <asp:TextBox ID="uname" runat="server"></asp:TextBox><br /><br />
    <label for="dropdown">Options:</label>
    <asp:DropDownList ID="dropdown" runat="server" CssClass="dd"></asp:DropDownList><br /><br />
     <asp:Button ID="b" runat="server" Text="Submit" onclick="Udata"/><br /><br />
    <label ID="error" runat="server" Visible="false"></label>
    </form>
</body>
</html>
</asp:Content>