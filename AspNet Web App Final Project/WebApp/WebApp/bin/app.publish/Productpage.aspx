<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Productpage.aspx.cs" Inherits="WebApp.Productpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Productname" runat="server" CssClass="text1"></asp:Label> <br />
        <asp:Label ID="Productprice" runat="server" CssClass="text2"></asp:Label> <br />
        <asp:Label ID="Productquant" runat="server" CssClass="text3"></asp:Label> <br />
        <asp:label ID="reviews" runat="server" CssClass="text4"></asp:label> <br /> <br />
    </div>
    <div>
        <label class="text4">QTY</label>
        <asp:DropDownList ID="quantbuy" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList> <br />
        <asp:Button ID="buybtn" runat="server" Text="Buy" OnClick="buybtn_Click" /> <br /> <br />
        <label class="text4">Stars:</label>
        <asp:DropDownList ID="starsreview" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="userreviewbtn" runat="server" Text="Leave review" OnClick="userreviewbtn_Click" /> 
        <br /> <br />
    </div>
    <div>
        <label class="text4">Description:</label> <br />
        <asp:Label ID="Description" runat="server" CssClass="text5"></asp:Label>
    </div>
</asp:Content>
