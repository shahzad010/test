<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="plus1.aspx.cs" Inherits="design.plus1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Image ID="Image2" runat="server" Height="80px" ImageUrl="~/images/plusCapture.PNG" />
        <br />
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
        <br />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="90px" ImageUrl="~/images/equal.png" OnClick="ImageButton2_Click" />
        <br />
        <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
        <br />
        <asp:ImageButton ID="ImageButton3" runat="server" Height="50pt" ImageUrl="~/images/nextCapture.PNG" OnClick="ImageButton3_Click" />
    </div>
</asp:Content>
