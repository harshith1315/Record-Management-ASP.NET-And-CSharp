<%@ Page Language="C#" AutoEventWireup="true" CodeFile="displayrecord.aspx.cs" Inherits="WebApplication1.displayrecord" MasterPageFile="~/Site.Master"%>


<asp:Content ID="Content1" ContentPlaceHolderID="placeholder" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display Records</title>
    <style>
        body{
            text-align:center;
        }
        .test{
            margin:auto;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Records</h1>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="test">
                <Columns>
                    <asp:BoundField DataField="recordnumber" HeaderText="recordnumber" />
                    <asp:BoundField DataField="patientname" HeaderText="patientname" />
                    <asp:BoundField DataField="dtype" HeaderText="dtype" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
</asp:Content>