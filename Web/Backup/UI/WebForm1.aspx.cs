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
using System.Data.SqlClient;
using BLL;
namespace UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void txtCenterName_TextChanged(object sender, EventArgs e)
        {
            CenterBUS centerBUS = new CenterBUS();
            string centerName = txtCenterName.Text;
            centerBUS.insert(centerName);
        }
    }
}
