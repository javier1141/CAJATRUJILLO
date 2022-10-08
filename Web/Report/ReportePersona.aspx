<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="ReportePersona.aspx.cs" Inherits="Report_ReportePersona" %>



<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Buscar una cuenta.</h4>
        <hr />

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="buscar_Click" Text="Buscar Cuentas" CssClass="btn btn-default" />
            </div>
        </div>

        <div class="form-group">
            <asp:PlaceHolder ID = "PlaceHolder1" runat="server" />
        </div>
        
    </div>
</asp:Content>


