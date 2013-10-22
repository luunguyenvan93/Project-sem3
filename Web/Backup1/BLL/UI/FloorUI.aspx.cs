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
    public partial class FloorUI : System.Web.UI.Page
    {
        FloorBUS floorBUS = new FloorBUS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loadData();
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string floorName = txtFloorName.Text;
            int centerID = ddlCenterID.SelectedIndex+1;
            Response.Write(centerID);
            floorBUS.insert(floorName, centerID);
            loadData();
        }
        private void loadData()
        {
            grvFloor.DataSource = floorBUS.getAll();
            grvFloor.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int floorID = Int32.Parse(txtFloorID.Text);
            string floorName = txtFloorName.Text;
            int centerID = ddlCenterID.SelectedIndex+1;
            Response.Write(centerID);
            floorBUS.update(floorID,floorName,centerID);
            loadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int floorID = Int32.Parse(txtFloorID.Text);
            floorBUS.delete(floorID);
            loadData();
        }
    }
}
