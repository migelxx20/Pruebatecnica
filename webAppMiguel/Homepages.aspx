<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepages.aspx.cs" Inherits="webAppMiguel.Homepages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grilla" runat="server">
            </asp:GridView>
            <asp:Button ID="btn_consultar" runat="server" OnClick="btn_consultar_Click" Text="Consultar" />
        </div>
    </form>
</body>
</html>
