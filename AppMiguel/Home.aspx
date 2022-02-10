<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AppMiguel.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_consultar" runat="server" OnClick="btn_consultar_Click" Text="Consultar" />
            <asp:GridView ID="grilla" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
