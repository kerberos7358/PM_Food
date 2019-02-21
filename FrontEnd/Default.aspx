<%@ Page Title="" Language="C#" MasterPageFile="~/CompanyBank.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PBFrontEnd.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="height: 129px; width: 567px; margin-left: 120px; position: fixed; top: 83px; left: 10px;">
        <asp:ListBox ID="lstUsers" runat="server" Height="88px" OnSelectedIndexChanged="lstUsers_SelectedIndexChanged" Width="120px"></asp:ListBox>
        <br />
    </p>
    <br />
    <p style="height: 222px; width: 572px; margin-left: 120px">
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        <asp:Button ID="btnPopulate" runat="server" OnClick="Button1_Click" Text="Populate" />
    </p>
    <p style="height: 222px; width: 572px; margin-left: 120px">
        &nbsp;</p>
    <p style="height: 222px; width: 572px; margin-left: 120px">
        &nbsp;</p>
    <p style="height: 222px; width: 572px; margin-left: 120px">
        </p>
    <p style="height: 222px; width: 572px; margin-left: 120px">
        </p>
    <p style="height: 222px; width: 572px; margin-left: 120px">
        &nbsp;</p>
</asp:Content>
