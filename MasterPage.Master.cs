using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartagerMU
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["adminUname"] != null)
            {
                panelLogin.Style.Add("visibility", "hidden");
                lblLoggedIn.Visible = true;
                lblLoggedIn.Text = "Welcome " + Session["adminUname"];
                Page.Controls.Remove(panelLogin);
                panelLogin.Visible = false;
                btnLogOut.Visible = true;
                panelUname.Visible = true;
                panelAdmin.Visible = true;

            }

            if (Session["donorUname"] != null)
            {
                panelLogin.Style.Add("visibility", "hidden");
                lblLoggedIn.Visible = true;
                lblLoggedIn.Text = "Welcome " + Session["donorUname"];
                Page.Controls.Remove(panelLogin);
                panelLogin.Visible = false;
                btnLogOut.Visible = true;
                panelUname.Visible = true;
                panelDonor.Visible = true;

            }

            if (Session["beneficiaryUname"] != null)
            {
                panelLogin.Style.Add("visibility", "hidden");
                lblLoggedIn.Visible = true;
                lblLoggedIn.Text = "Welcome " + Session["beneficiaryUname"];
                Page.Controls.Remove(panelLogin);
                panelLogin.Visible = false;
                btnLogOut.Visible = true;
                panelUname.Visible = true;
                panelBeneficiary.Visible = true;

            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            panelLogin.Visible = true;
            lblLoggedIn.Text = "";
            lblLoggedIn.Visible = false;
            panelUname.Visible = false;
            Response.Redirect("~/home.aspx");
            panelDonor.Visible = false;
            panelAdmin.Visible = false;
            panelBeneficiary.Visible = false;

        }
    }
}