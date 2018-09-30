using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;

namespace NotificationHub
{
    public partial class DeclineTemplate : System.Web.UI.Page
    {
        int s, Aid, Did;
        protected void Page_Load(object sender, EventArgs e)
        {
          
            Aid = Convert.ToInt32(Request.QueryString["id"]);
            Did = Convert.ToInt32(Request.QueryString["id"]);
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ApprovalForm.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            s = Convert.ToInt32(Request.QueryString["id"]);
            SourecDal repo = new SourecDal();
            repo.TempDecline(s);

            Response.Redirect("~/ApprovalForm.aspx");
        }
    }
}