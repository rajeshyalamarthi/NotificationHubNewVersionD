﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using DAL.Repository;

namespace NotificationHub
{
    public partial class AddSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SourecDal sourcerepo = new SourecDal();

            sourcerepo.Entersource(TextBox1.Text + "\n");




            Response.Redirect("SourceHome.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SourceHome.aspx");
        }
    }
}
