<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MejorInversion.aspx.cs" Inherits="SimuladorPlazoFijo.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center mb-5">
    <h1 class="display-5 fw-bold text-primary">Resultados de la inversión</h1>
    <p class="lead">Comparación de rendimientos por banco y tipo de inversión:</p>
        <asp:GridView ID="GVResultados" runat="server"
    AutoGenerateColumns="False"
    CssClass="table table-bordered table-striped text-center mx-auto"
    HeaderStyle-CssClass="table-primary"
    HorizontalAlign="Center">

    <Columns>
        <asp:BoundField DataField="Banco" HeaderText="Banco" />
        <asp:BoundField DataField="Forma de inversión" HeaderText="Forma de inversión" />
        <asp:BoundField DataField="Rendimiento" HeaderText="Rendimiento" />
    </Columns>

</asp:GridView>
</div>
    <div class="alert alert-success text-center mt-4">
    <h3>La mejor opción de inversión es: </h3>
    <asp:Label ID="lblMejorOpcion" runat="server" CssClass="fs-5 fw-bold"></asp:Label>
</div>
</asp:Content>
