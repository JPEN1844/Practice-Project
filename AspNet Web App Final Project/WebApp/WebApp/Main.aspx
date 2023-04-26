<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApp.Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:DropDownList ID="Tablelist" runat="server" OnSelectedIndexChanged="Tablelist_SelectedIndexChanged" AutoPostBack="true" Width="200px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Electronics</asp:ListItem>
        </asp:DropDownList>
    </div>
    <br />
    <asp:Table ID="Table1" runat="server"></asp:Table>
    </asp:Content>

