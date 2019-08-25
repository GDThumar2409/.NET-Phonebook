using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Phbook;
namespace PhoneBookWeb
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String temp="";
            List<People> r = (List<People>)Session["result"];
            if (r == null)
            {
                temp="NOT Found";
            }
            else
            {
                foreach(People p in r)
                {
                    temp += "Name:" + p.name +"<br/>City:" +p.city +"<br/>email:" + p.email+ "<br/>Contact:" +p.contact + "<br/>";
                    
                }
            }
            Response.Write(temp);
        }
    }
}