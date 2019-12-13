using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWebApplication
{
    public partial class BorrowBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(this.Page.IsPostBack)
            {
                this.lblResultMessageBorrow.Text = "";
            }
        }

        protected void btnBorrow_Click(object sender, EventArgs e)
        {
            if(!this.Page.IsValid)
            {
                return;
            }

            int result = DataAccessLayer.UtilityToolsBorrowOrReturn.BorrowOrReturn(this.ddlStudentsBorrow.SelectedValue, this.ddlBooksAvailable.SelectedValue, "BorrowInsertOrUpdate");

            if (result == 1)
                this.lblResultMessageBorrow.Text = "Succesful submition!";
            else if (result == 0)
                this.lblResultMessageBorrow.Text = "There was an error at the Database level";
            else
                this.lblResultMessageBorrow.Text = "There was an error at the Method level";

            Response.Redirect(Request.Url.ToString());
        }

        protected void BtnBorrow_Click(object sender, EventArgs e)
        {

        }
    }
}