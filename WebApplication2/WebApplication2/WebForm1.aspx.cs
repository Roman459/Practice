using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


using System.Configuration;

using System.Web.Security;

using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Data.Sql;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
   

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Users tab = new Users();
            tab.FIO_user = TextBox1.Text;
            tab.login_use = TextBox2.Text;
            tab.age_user = Convert.ToInt32(TextBox3.Text);
            tab.phone_user = TextBox4.Text;
            
            tab.foto_user = FileUpload1.FileBytes;

            db.Users.InsertOnSubmit(tab);
            db.SubmitChanges();

           
            Response.Redirect("/WebForm1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
           
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
           
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
           
            

        }

        protected void Button2_Click2(object sender, System.EventArgs e)
        {
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            FileUpload1.Visible = true;
            Button1.Visible =true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
        }
    }
}