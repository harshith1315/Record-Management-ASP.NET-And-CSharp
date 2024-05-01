<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication1.home" MasterPageFile="~/Site.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="placeholder" runat="server">
    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Record Management</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            text-align: center;
        }

        .action-button {
            padding: 7px 17px;
            font-size: 12px;
            margin: 7px;
            border: 1px solid;
            background-color: #f0f0f0;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .action-button:hover {
            background-color: #ccc;
        }

        .action-box {
            width: 700px;
            height: 60px;
            border: 1px solid;
            margin: 20px auto;
            padding: 20px;
            box-sizing: border-box;
            display: flex;
            align-items: center;
        }

        .action-name {
            flex: 1;
            text-align: left;
        }

        .action-button-container {
            flex: 1;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h2>Record Management System</h2>
    <div class="action-box">
        <div class="action-name">
            <h3>Add Record</h3>
        </div>
        
            <div class="action-button-container">
                <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Test" CssClass="action-button" />
            </div>
    </div>


    <div class="action-box">
        <div class="action-name">
            <h2>Delete Record</h2>
        </div>
            <div class="action-button-container">
                <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Test1" CssClass="action-button" />
            </div>
    </div>


    <div class="action-box">
        <div class="action-name">
            <h2>Update Record</h2>
        </div>
            <div class="action-button-container">
                <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Test2" CssClass="action-button" />
            </div>
    </div>


    <div class="action-box">
        <div class="action-name">
            <h2>Display Records</h2>
        </div>
            <div class="action-button-container">
                <asp:Button ID="Button4" runat="server" Text="Display" OnClick="Test3" CssClass="action-button" />
            </div>
    </div>
    </form>

</body>
</html>
</asp:Content>
