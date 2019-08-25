using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Phbook;

namespace PhoneBookWeb
{
    public partial class Input : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TextBox1.Visible = true;
                TextBox1.ToolTip = "Enter True or False";
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Phonebook pb = new Phonebook();
            int result = Convert.ToInt32(DropDownList1.SelectedValue);
            if (result == 0)
            {
                if (TextBox1.Text == "true")
                    Session["result"] = pb[true];
                else
                    Session["result"] = pb[false];
            }
            if (result == 1)
            {
                Session["result"] = pb[TextBox1.Text];
            }
            if (result == 2)
            { 
                Session["result"] = pb[TextBox1.Text,TextBox2.Text];
            }
            Response.Redirect("Result.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(DropDownList1.SelectedValue);
            if (result == 0)
            {
                TextBox1.Visible = true;
                TextBox1.ToolTip = "Enter true or false";
            }
            if (result == 1)
            {
                TextBox1.Visible = true;
                TextBox1.ToolTip = "Enter Name";
            }
            if (result == 2)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox1.ToolTip = "Enter Name";
                TextBox2.ToolTip = "Enter City";
            }
        }
    }
}