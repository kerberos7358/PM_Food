<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PBFrontEnd.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListBox ID="lstSupplier" runat="server" style="z-index: 1; left: 10px; top: 39px; position: absolute" OnSelectedIndexChanged="lstSupplier_SelectedIndexChanged"></asp:ListBox>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 329px; top: 234px; position: absolute"></asp:Label>

    <asp:Button ID="btnPopulate" runat="server" OnClick="btnPopulate_Click1" Text="Button" />

</asp:Content>
