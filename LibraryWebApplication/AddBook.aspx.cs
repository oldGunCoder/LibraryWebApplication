using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace LibraryWebApplication
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.IsPostBack)
            {
                this.lblResultMessageBook.Text = "";
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (this.Page.IsValid)
            {
                BusinessLayer.Book book = new BusinessLayer.Book();
                book.Title = this.txtTitle.Text;
                book.PageCount = Convert.ToInt32(this.txtPageCount.Text);
                book.Price = Convert.ToDecimal(this.txtPrice.Text);
                
                BusinessLayer.Author author = new BusinessLayer.Author();
                author.FristName = this.txtAuthorFirstName.Text;
                author.LastName = this.txtAuthorLastName.Text;

                BusinessLayer.Type type = new BusinessLayer.Type();
                type.Name = this.txtTypeName.Text;

                int result = DataAccessLayer.UtilityToolsBook.ExecuteInsertBook(book, author, type);

                if (result == 1)
                    this.lblResultMessageBook.Text = "Succesful submition!";
                else if (result == 0)
                    this.lblResultMessageBook.Text = "There was an error at the Database level";
                else
                    this.lblResultMessageBook.Text = "There was an error at the Method level";


            }


        }

        protected void btnSubmitBook_Click(object sender, EventArgs e)
        {

        }
    }
}