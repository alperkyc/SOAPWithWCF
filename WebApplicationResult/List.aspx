<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebApplicationResult.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <asp:Label ID="lblStudents" runat="server" CssClass="alert alert-warning" Text="Ögrenciler"></asp:Label>
        <asp:DropDownList ID="ddlStudents" CssClass="dropdown" runat="server"></asp:DropDownList>
    </div>
    <br />
     <br />
    <div class="col-md-12">
        <asp:Label ID="lblYears" runat="server" CssClass="alert alert-warning" Text="Yıllar"></asp:Label>
        <asp:DropDownList ID="ddlYears" runat="server"></asp:DropDownList>
    </div>
    <br />
     <br />
    <div class="col-md-12">
        <asp:Label ID="lblTypes" CssClass="alert alert-warning" runat="server" Text="Türler"></asp:Label>
        <asp:DropDownList ID="ddlTypes" runat="server"></asp:DropDownList>
    </div>
    <br />
     <br />
    <asp:Button ID="btnGetResult" runat="server" CssClass="btn btn-success" Text="Sonuç Getir" OnClick="btnGetResult_Click" />
    <br />
     <br />

    <asp:Label ID="lblResult" CssClass="alert alert-info" runat="server" Text="Gerekli Alanları Seçerek Sorgulama Yapabilirsiniz"></asp:Label>

</asp:Content>
