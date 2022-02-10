<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebAppIndigo.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../Scripts/bootstrap.min.js"></script>


    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <div class="container">
        <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Productos</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarScroll" aria-controls="navbarScroll" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarScroll">
                    <ul class="navbar-nav me-auto my-2 my-lg-0 navbar-nav-scroll" style="--bs-scroll-height: 100px;">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="HomeProveedor.aspx">Proveedor</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="HomeRemisionEntrada.aspx">Remison Entrada</a>
                        </li>
                    </ul>

                </div>
            </div>
        </nav>
        <form id="form1" runat="server" class="form-control b-20">
            <div class="row">
                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label">ProductoID:</label>
                    <asp:TextBox ID="idpro" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label">Codigo:</label>
                    <asp:TextBox ID="cod" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label">Nombre:</label>
                    <asp:TextBox ID="nom" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label">Descripcion:</label>
                    <asp:TextBox ID="des" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label">Precio de venta:</label>
                    <asp:TextBox ID="pre" CssClass="form-control" runat="server"></asp:TextBox>

                </div>

                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label">StockMinimo:</label>
                    <asp:TextBox ID="stockmin" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label">StockMaximo:</label>
                    <asp:TextBox ID="stockmax" CssClass="form-control" runat="server"></asp:TextBox>

                </div>


            </div>
            <div class="row p-1">
                <div class="col-3">
                    <asp:Button ID="btn_inserta" runat="server" CssClass="btn btn-success col-12" OnClick="Button1_Click" Text="Insertar" />
                </div>
                <div class="col-3">
                    <asp:Button ID="btn_buscar" runat="server" CssClass="btn btn-primary col-12" OnClick="Button2_Click" Text="Buscar" />
                </div>
                <div class="col-3">
                    <asp:Button ID="btn_update" runat="server" CssClass="btn btn-primary col-12" OnClick="Button3_Click" Text="Update" />
                </div>

                <div class="col-3">
                    <asp:Button ID="btn_delete" runat="server" CssClass="btn btn-danger col-12" OnClick="Button4_Click" Text="Delete" />
                </div>

            </div>
            <p>
                <asp:Label ID="msj" runat="server" Font-Bold="True" ForeColor="#009933"></asp:Label>
                <asp:GridView ID="grilla" CssClass="table table-hover" runat="server">
                </asp:GridView>
            </p>

        </form>
    </div>

</body>
</html>
