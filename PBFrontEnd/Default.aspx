<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PBFrontEnd.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListBox ID="lstSupplier" runat="server" style="z-index: 1; left: 10px; top: 39px; position: absolute"></asp:ListBox>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 267px; top: 234px; position: absolute"></asp:Label>
    <asp:Button ID="btnPopulate" runat="server" style="z-index: 1; left: 22px; top: 143px; position: absolute" Text="Populate" />
</asp:Content>
