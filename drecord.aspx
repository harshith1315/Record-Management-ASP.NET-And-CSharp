<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="drecord.aspx.cs" Inherits="WebApplication1.drecord" MasterPageFile="~/Site.Master"%>


<asp:Content ID="Content1" ContentPlaceHolderID="placeholder" runat="server">
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
            <label for="uname">Record number:</label>
            <asp:TextBox ID="rnum" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="rnumValidator" runat="server" ControlToValidate="rnum" ErrorMessage="Please enter a value." /><br /><br />
            <%-- <label for="dname" runat="server">Name:</label>
            <asp:TextBox ID="dname" runat="server"></asp:TextBox><br /><br />
            <label for="dropdown">Options:</label>
            <asp:DropDownList ID="dropdown" runat="server" CssClass="dd"></asp:DropDownList><br /><br /> --%>
            <asp:Button ID="db" runat="server" Text="Submit" OnClick="Remove"/><br />
            <label id="error" runat="server" visible="false"></label><br />
        </div>
    </form>
</body>
</html>
</asp:Content>