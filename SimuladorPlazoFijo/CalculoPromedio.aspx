<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalculoPromedio.aspx.cs" Inherits="SimuladorPlazoFijo.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Título principal -->
    <div class="text-center mb-5">
        <h1 class="display-5 fw-bold text-primary">Promedio de Tasas Anuales Por Banco</h1>
    </div>

    <!-- Tarjetas de resultados  -->
    <div class="row g-4 mb-4">
        
        <!-- Banco Provincia -->
        <div class="col-md-4">
            <div class="card shadow-sm border-0 h-100 rounded-4">
                <div class="card-body p-4">
                    <h4 class="text-primary fw-bold border-bottom pb-2 mb-3">Promedio Banco Provincia : </h4>
                    <div class="mb-3">
                        <asp:Label ID="lblPromedioProvincia" runat="server" Text="" CssClass="form-label fs-4 fw-semibold"></asp:Label>
                    </div>
                </div>
            </div>
        </div>

        <!-- Banco Nacion -->
        <div class="col-md-4">
            <div class="card shadow-sm border-0 h-100 rounded-4">
                <div class="card-body p-4">
                    <h4 class="text-primary fw-bold border-bottom pb-2 mb-3">Promedio Banco Nacion : </h4>
                    <div class="mb-3">
                        <asp:Label ID="lblPromedioNacion" runat="server" Text="" CssClass="form-label fs-4 fw-semibold"></asp:Label>
                    </div>
                </div>
            </div>
        </div>

        <!-- Banco Hipotecario -->
        <div class="col-md-4">
            <div class="card shadow-sm border-0 h-100 rounded-4">
                <div class="card-body p-4">
                    <h4 class="text-primary fw-bold border-bottom pb-2 mb-3">Promedio Banco Hipotecario : </h4>
                    <div class="mb-3">
                        <asp:Label ID="lblPromedioHipotecario" runat="server" Text="" CssClass="form-label fs-4 fw-semibold"></asp:Label>
                    </div>
                </div>
            </div>
        </div>

    </div> 

    <div class="text-center">
        <asp:Button ID="btnSiguiente" runat="server" Text="Calcular Mejor Opción" CssClass="btn btn-primary btn-lg" OnClick="btnSiguiente_Click" />
    </div>

</asp:Content>