<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="LibraryWebApplication.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;
            <h2>Insert a new book record</h2>
            <br />
            <br />
&nbsp;&nbsp; Title:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTitle" runat="server" Width="176px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp; PageCount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPageCount" runat="server" Width="74px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp; Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrice" runat="server" Width="76px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp; AuthorFirstName:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAuthorFirstName" runat="server" Width="145px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp; AuthorLastName:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAuthorLastName" runat="server" Width="146px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp; TypeName:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTypeName" runat="server" style="margin-left: 1px" Width="149px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSubmitBook" runat="server" Text="Submit" Width="117px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblResultMessageBook" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="AddNewStudent" runat="server">Add new student</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="BorrowBook" runat="server">Borrow book</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="ReturnBook" runat="server">Return book</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
        </div>
    </form>
</body>
</html>
