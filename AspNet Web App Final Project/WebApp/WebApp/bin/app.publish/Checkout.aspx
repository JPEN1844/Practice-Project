<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="WebApp.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <label>Name</label>
        <br />
        <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox><br />
        <label>Email</label>
        <br />
        <asp:TextBox ID="Emailtxt" runat="server" TextMode="Email"></asp:TextBox><br />
        <label>Shipping Address</label><br />
        <asp:TextBox ID="Addresstxt" runat="server"></asp:TextBox><br />
        <div>
            <div>
                <label>Country</label><br />
                <asp:TextBox ID="Contrytxt" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>City</label><br />
                <asp:TextBox ID="Citytxt" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>ZipCode</label><br />
                <asp:TextBox ID="ZipCodetxt" runat="server" Width="100px"></asp:TextBox>
            </div>
        </div>
    </div>
    <div>
        <label>Cart:</label> <br />
        <asp:Label ID="Productname" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Productquant" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Productprice" runat="server" Text="Label"></asp:Label><br /><br />
        <label>Total:</label>
        <asp:Label ID="Totalcost" runat="server" Text="Label"></asp:Label><br />
        <asp:Button ID="Paybtn" runat="server" Text="Pay" OnClick="Paybtn_Click" />
    </div>
</asp:Content>
