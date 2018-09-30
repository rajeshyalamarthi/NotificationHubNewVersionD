using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Repository;

namespace NotificationHub
{
    public partial class AcceptTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    int s = Convert.ToInt32(Request.QueryString["id"]);
            //    if (!IsPostBack)
            //    {


            //        SourecDal repo = new SourecDal();
            //        List<TemplateAccess> l = repo.GetTemplates();

            //        foreach (Source sou in l)
            //        {
            //            if (sou.Id == s)
            //            {
            //                TextBox1.Text = sou.Name;
            //            }
            //        }

            //    }
            //}

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Request.QueryString["id"]);
            int Aid= Convert.ToInt32(Request.QueryString["Aid"]);
            int Did=Convert.ToInt32(Request.QueryString["Did"]);
          
            SourecDal repo = new SourecDal();
            repo.TempUpdate(s);
            

            Response.Redirect("~/ApprovalForm.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ApprovalForm.aspx");
        }
    }
}