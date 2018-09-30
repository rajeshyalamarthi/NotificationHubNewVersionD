using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;

namespace NotificationHub
{
    public partial class AcceptTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Request.QueryString["id"]);
            SourecDal repo = new SourecDal();
            repo.TempUpdate(s);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ApprovalForm.aspx");
        }
    }
}