<%@ Page Title="Simulador de Plazo Fijo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimuladorPlazoFijo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-4">

        <!-- Título principal -->
        <div class="text-center mb-5">
            <h1 class="display-5 fw-bold text-primary">Simulador y Analizador de Plazos Fijos</h1>
            <p class="text-muted lead">Análisis de capital inicial de $850.000 con historial de tasas (3 Años)</p>
        </div>

        <!-- Tarjetas de ingreso de tasas -->
        <div class="row g-4 mb-4">
            <!-- Banco Provincia -->
            <div class="col-md-4">
                <div class="card shadow-sm border-0 h-100 rounded-4">
                    <div class="card-body p-4">
                        <h4 class="text-primary fw-bold border-bottom pb-2 mb-3">Banco Provincia</h4>
                        <div class="mb-3">
                            <label class="form-label small fw-semibold">Tasa Año 1 (%):</label>
                            <asp:TextBox ID="txtProvincia1" runat="server" CssClass="form-control" Text="70"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label small fw-semibold">Tasa Año 2 (%):</label>
                            <asp:TextBox ID="txtProvincia2" runat="server" CssClass="form-control" Text="72"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label small fw-semibold">Tasa Año 3 (%):</label>
                            <asp:TextBox ID="txtProvincia3" runat="server" CssClass="form-control" Text="75"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Banco Nación -->
            <div class="col-md-4">
                <div class="card shadow-sm border-0 h-100 rounded-4">
                    <div class="card-body p-4">
                        <h4 class="text-primary fw-bold border-bottom pb-2 mb-3">Banco Nación</h4>
                        <div class="mb-3">
                            <label class="form-label small fw-semibold">Tasa Año 1 (%):</label>
                            <asp:TextBox ID="txtNacion1" runat="server" CssClass="form-control" Text="68"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label small fw-semibold">Tasa Año 2 (%):</label>
                            <asp:TextBox ID="txtNacion2" runat="server" CssClass="form-control" Text="70"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label small fw-semibold">Tasa Año 3 (%):</label>
                            <asp:TextBox ID="txtNacion3" runat="server" CssClass="form-control" Text="73"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Banco Hipotecario -->
            <div class="col-md-4">
                <div class="card shadow-sm border-0 h-100 rounded-4">
                    <div class="card-body p-4">
                        <h4 class="text-primary fw-bold border-bottom pb-2 mb-3">Banco Hipotecario</h4>
                        <div class="mb-3">
                            <label class="form-label small fw-semibold">Tasa Año 1 (%):</label>
                            <asp:TextBox ID="txtHipotecario1" runat="server" CssClass="form-control" Text="72"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label small fw-semibold">Tasa Año 2 (%):</label>
                            <asp:TextBox ID="txtHipotecario2" runat="server" CssClass="form-control" Text="74"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label small fw-semibold">Tasa Año 3 (%):</label>
                            <asp:TextBox ID="txtHipotecario3" runat="server" CssClass="form-control" Text="76"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>