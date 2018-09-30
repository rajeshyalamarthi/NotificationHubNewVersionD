﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;

namespace NotificationHub
{
    public partial class SourceHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table table = new Table();
            table.ID = "1";
            PlaceHolder1.Controls.Add(table);

            SourecDal sourecDal = new SourecDal();
            sourecDal.GetSources();

            for (int count = 0; count < sourecDal.Sourceslist.Count; count++)
            {
                TableRow tableRow = new TableRow();
                table.Rows.Add(tableRow);
                TableCell cell = new TableCell();
                tableRow.Cells.Add(cell);
                Label label = new Label();
                PlaceHolder1.Controls.Add(label);
                label.Text = sourecDal.Sourceslist[count].Name;
                label.Width = 200;

                HyperLink Edit = new HyperLink();
                PlaceHolder1.Controls.Add(Edit);
                Edit.Text = "EDIT";
                Edit.NavigateUrl = ("~/EditSource.aspx?id=" + Convert.ToString(sourecDal.Sourceslist[count].Id));
                Edit.Width = 150;
                HyperLink Delete = new HyperLink();
                PlaceHolder1.Controls.Add(Delete);
                Delete.Text = "DELETE" + "<br/>" + "<br/>";
                Delete.NavigateUrl = ("~/DeleteSource.aspx?id=" + Convert.ToString(sourecDal.Sourceslist[count].Id));


                //Delete.Width = 600;




            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSource.aspx");
        }
    }
}
