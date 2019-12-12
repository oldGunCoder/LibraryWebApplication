<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowBook.aspx.cs" Inherits="LibraryWebApplication.BorrowBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>&nbsp;&nbsp;Borrow Book</h2>
            <br />
            <br />
            <br />
&nbsp;&nbsp;
            <asp:DropDownList ID="ddlStudentsBorrow" runat="server" DataSourceID="Student" DataTextField="FirstName" DataValueField="LastName">
            </asp:DropDownList>
            <asp:SqlDataSource ID="Student" runat="server" ConnectionString="<%$ ConnectionStrings:LibraryWebApplicationConnectionString %>" SelectCommand="SELECT [FirstName], [LastName] FROM [Student]"></asp:SqlDataSource>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:DropDownList ID="ddlBooksAvailable" runat="server">
            </asp:DropDownList>
            <br />
            <br />
&nbsp;&nbsp;
            <br />
&nbsp;&nbsp; Taken Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Calendar ID="cldrTakenDate" runat="server" SelectedDate="2019-12-12"></asp:Calendar>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="btnBorrow" runat="server" Text="Borrow the book" />
&nbsp;&nbsp;
            <asp:Label ID="lblResultMessageBorrow" runat="server"></asp:Label>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="AddNewBook" runat="server">Add new book</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="ReturnBook" runat="server">Return book</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <br />
        </div>
    </form>
</body>
</html>
