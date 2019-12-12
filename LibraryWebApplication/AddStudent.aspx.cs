using System;
using System.Data.SqlClient;

namespace LibraryWebApplication
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                lblResultMessage.Text = "";
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                BusinessLayer.Student student = new BusinessLayer.Student
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = Convert.ToDateTime(txtBirthDate.Text),
                    Gender = txtGender.Text,
                    Class = txtClass.Text
                };

                int result = BusinessLayer.UtilityTools.ExecuteInsert(student);

                if (result == 1)
                    lblResultMessage.Text = "Succesful submition!";
                else if (result == 0)
                    lblResultMessage.Text = "There was an error at the Database level";
                else
                    lblResultMessage.Text = "There was an error at the Method level";


            }


        }
    }
}