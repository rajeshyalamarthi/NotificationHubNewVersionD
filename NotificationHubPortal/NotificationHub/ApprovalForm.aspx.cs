using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;

namespace NotificationHub
{
    public partial class ApprovalForm : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {

            Table table = new Table();
            table.ID = "1";
            PlaceHolder1.Controls.Add(table);

            SourecDal repo = new SourecDal();
            repo.GetTemplates();

            for(int count=0;count< repo.templateslist.Count; count++)
            {
                TableRow tableRow = new TableRow();
                table.Rows.Add(tableRow);
                TableCell tableCell = new TableCell();
                tableRow.Cells.Add(tableCell);
                Label label = new Label();
                label.Text = " NEW_TEMPLATE--";
                label.Width = 200;
                PlaceHolder1.Controls.Add(label);

                Label label1 = new Label();
                label1.Text = repo.templateslist[count].TemplateName;
                label1.Width = 150;
                PlaceHolder1.Controls.Add(label1);

                Label label2 = new Label();
                label2.Text = repo.templateslist[count].OperationManager;
                label2.Width = 250;
                PlaceHolder1.Controls.Add(label2);

               HyperLink hyper = new HyperLink();
                hyper.Text = "Approve";
                hyper.Width = 100;
                hyper.NavigateUrl = ("~/AcceptTemplate.aspx?id=" + Convert.ToString(repo.templateslist[count].Id));
                PlaceHolder1.Controls.Add(hyper);

                HyperLink hyper1 = new HyperLink();
                hyper1.Text = "Decline";
                hyper1.Width = 400;
                hyper1.NavigateUrl = ("~/DeclineTemplate.aspx?id=" + Convert.ToString(repo.templateslist[count].Id));
                PlaceHolder1.Controls.Add(hyper1);

               
                
            }
        }
    }
}