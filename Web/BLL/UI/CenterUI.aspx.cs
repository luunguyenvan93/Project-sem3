using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BLL;

namespace UI
{
    public partial class _Default : System.Web.UI.Page
    {
        CenterBUS centerBUS = new CenterBUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loadData();
            }
        }
        private void loadData()
        {
            grvCenter.DataSource = centerBUS.getAll();
            grvCenter.DataBind();
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string centerName = txtCenterName.Text;
            centerBUS.insert(centerName);
            loadData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {       
            int centerID = int.Parse(txtCenterID.Text);
            string centerName = txtCenterName.Text;
            centerBUS.update(centerID, centerName);
            loadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int centerID = int.Parse(txtCenterID.Text);
            centerBUS.delete(centerID);
            loadData();
        }

        protected void grvCenter_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex < 0) return;
                LinkButton edit = (LinkButton)e.Row.Cells[3].Controls[0];
        }
        protected void grvCenter_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int centerID = int.Parse(grvCenter.DataKeys[e.RowIndex].Value.ToString());
            centerBUS.delete(centerID);
            loadData();
        }
        protected void grvCenter_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvCenter.EditIndex = e.NewEditIndex;
            loadData();
        }

        protected void grvCenter_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvCenter.EditIndex = -1;
            loadData();
        }

        protected void grvCenter_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int centerID = int.Parse(grvCenter.DataKeys[e.RowIndex].Value.ToString());
            string centerName = (grvCenter.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox).Text;
            centerBUS.update(centerID, centerName);
            grvCenter.EditIndex = -1;
            loadData();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string centerName = txtSearch.Text;
            grvCenter.DataSource = centerBUS.search(centerName);
            grvCenter.DataBind();
        }
    }
}
