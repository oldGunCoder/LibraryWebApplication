<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBook.aspx.cs" Inherits="LibraryWebApplication.ReturnBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700">
            <h2>&nbsp;&nbsp;Return Book</h2>
            <br />
            <br />
            <br />
&nbsp;&nbsp;
            <asp:DropDownList ID="ddlStudentsReturn" runat="server" DataSourceID="Student" DataTextField="FirstName" DataValueField="LastName">
            </asp:DropDownList>
            <asp:SqlDataSource ID="Student" runat="server" ConnectionString="<%$ ConnectionStrings:LibraryWebApplicationConnectionString %>" SelectCommand="SELECT [FirstName], [LastName] FROM [Student]"></asp:SqlDataSource>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:DropDownList ID="ddlBooksBorrowed" runat="server">
            </asp:DropDownList>
            <br />
            <br />
&nbsp;&nbsp;
            <br />
&nbsp;&nbsp; Return Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Calendar ID="cldrBroughtDate" runat="server" SelectedDate="2019-12-12"></asp:Calendar>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="btnBorrow" runat="server" Text="Return the book" />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblResultMessageReturn" runat="server"></asp:Label>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="http://localhost:58708/AddBook.aspx">Add new book</a>
            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="http://localhost:58708/BorrowBook.aspx">Borrow book</a>
            
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="http://localhost:58708/AddStudent.aspx">Add new student</a>
            
&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
