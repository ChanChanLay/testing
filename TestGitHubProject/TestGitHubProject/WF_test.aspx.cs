using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestGitHubProject
{
    public partial class WF_test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BT_test_Click(object sender, EventArgs e)
        {
            Response.Redirect("WF_test1.aspx");
        }
    }
}