<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeRemisionEntrada.aspx.cs" Inherits="WebAppIndigo.Views.HomeRemisionEntrada" %>

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
                <a class="navbar-brand" href="#">Remison Entrada</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarScroll" aria-controls="navbarScroll" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarScroll">
                    <ul class="navbar-nav me-auto my-2 my-lg-0 navbar-nav-scroll" style="--bs-scroll-height: 100px;">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="HomePage.aspx">Productos</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="HomeProveedor.aspx">Provedores</a>
                        </li>
                    </ul>

                </div>
            </div>
        </nav>
        <form id="form1" runat="server" class="form-control b-20">
            <div class="row">
                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label">RemisionID:</label>
                    <asp:TextBox ID="idremi" CssClass="form-control col-12" runat="server">0</asp:TextBox>

                </div>
                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label">Codigo:</label>
                    <asp:TextBox ID="cod" CssClass="form-control col-12" runat="server"></asp:TextBox>

                </div>
                <div class="col-4">
                    <div class="row">
                        <div class="col-12">
                            <label for="exampleInputEmail1" class="form-label">Fecha:</label>
                            <asp:TextBox ID="fecha" CssClass="form-control col-8" runat="server"></asp:TextBox>
                            <asp:Calendar ID="TextBox1" CssClass="form-control col-8" runat="server" OnSelectionChanged="TextBox1_SelectionChanged"></asp:Calendar>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label">Proveedor:</label>
                    <asp:DropDownList ID="Listaprove" CssClass="form-control col-12" runat="server" >
                    </asp:DropDownList>

                </div>
                <div class="col-4">
                    <label for="exampleInputEmail1" class="form-label ">Almacen:</label>
                    <asp:DropDownList ID="ListaAlamce" CssClass="form-control col-12" runat="server" >
                    </asp:DropDownList>

                </div>
                
            </div>
            <div class="row p-1">
                <div class="col-3 ">
                    <asp:Button ID="btn_inserta" runat="server" CssClass="btn btn-success col-12 m-1" OnClick="Button1_Click" Text="Guardar" />
                </div>
                <div class="col-3 ">
                    <asp:Button ID="btn_buscar" runat="server" CssClass="btn btn-primary col-12 m-1" OnClick="Button2_Click" Text="Buscar" />
                </div>
                <div class="col-3 ">
                    <asp:Button ID="btn_update" runat="server" CssClass="btn btn-primary col-12 m-1" OnClick="Button3_Click" Text="Guardar y Confirmar" />
                </div>

                <div class="col-3 ">
                    <asp:Button ID="btn_modifica" runat="server" CssClass="btn btn-primary col-12 m-1" OnClick="Button4_Click" Text="Modificar" />
                </div>
                <div class="col-3 ">
                    <asp:Button ID="btn_confirma" runat="server" CssClass="btn btn-primary col-12 m-1" OnClick="Button5_Click" Text="Confirmar" />
                </div>
                <div class="col-3 ">
                    <asp:Button ID="btn_anular" runat="server" CssClass="btn btn-danger col-12 m-1" OnClick="Button6_Click" Text="Anular" />
                </div>
            </div>
            <p>
                <asp:Label ID="msj" runat="server" Font-Bold="True" ForeColor="#009933"></asp:Label>
                <asp:GridView ID="grilla" CssClass="table table-hover" runat="server" OnSelectedIndexChanged="grilla_SelectedIndexChanged">
                </asp:GridView>
            </p>

        </form>
    </div>
</body>
</html>
