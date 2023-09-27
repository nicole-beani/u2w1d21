<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inserimento.aspx.cs" Inherits="Azienda.Inserimento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-12 text-center">
                <h2>Inserisci un nuovo Dipendente</h2>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Nome del dipendente:</p>
                <asp:TextBox ID="Nome" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Cognome del dipendente:</p>
                <asp:TextBox ID="Cognome" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Indirizzo del dipendente:</p>
                <asp:TextBox ID="Indirizzo" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">CF del dipendente:</p>
                <asp:TextBox ID="CF" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Numero dei figli del dipendente:</p>
                <asp:TextBox ID="NumFigli" TextMode="Number" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">E' sposato?</p>
                <asp:CheckBox ID="Coniugato" runat="server" />
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Mansione del dipendente:</p>
                <asp:TextBox ID="Mansione" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
             <div class="col-12 d-flex justify-content-center">
              
    <asp:Button runat="server" Text="Inserisci" CssClass="btn btn-outline-info my-5 w-50" OnClick="Bottone"/>
            </div>
        </div>
    </div>
</asp:Content>
