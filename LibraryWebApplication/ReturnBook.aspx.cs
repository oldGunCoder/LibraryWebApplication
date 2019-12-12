using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryWebApplication
{
    public partial class ReturnBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.IsPostBack)
            {
                this.lblResultMessageReturn.Text = "";
            }
        }

        protected void ReturnBook_Click(object sender, EventArgs e)
        {
            if (!this.Page.IsValid)
            {
                return;
            }

            int result = DataAccessLayer.UtilityToolsBorrowOrReturn.BorrowOrReturn(this.ddlStudentsReturn.SelectedValue, this.ddlBooksBorrowed.SelectedValue, "ReturnUpdate");

            if (result == 1)
                this.lblResultMessageReturn.Text = "Succesful submition!";
            else if (result == 0)
                this.lblResultMessageReturn.Text = "There was an error at the Database level";
            else
                this.lblResultMessageReturn.Text = "There was an error at the Method level";

            Response.Redirect(Request.Url.ToString());
        }
    }
}