using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfServiceResults;

namespace WebApplicationResult
{
    public partial class List : System.Web.UI.Page
    {
        Service1 service = new Service1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var students = service.getStudents();
                ddlStudents.DataSource = students;
                ddlStudents.DataTextField = "ogrenciAd";
                ddlStudents.DataValueField = "ogrenciId";
                ddlStudents.DataBind();

                var years = service.getYears();
                ddlYears.DataSource = years;
                ddlYears.DataTextField = "yilAd";
                ddlYears.DataValueField = "yilId";
                ddlYears.DataBind();

                var types = service.getTypes();
                ddlTypes.DataSource = types;
                ddlTypes.DataTextField = "turAd";
                ddlTypes.DataValueField = "turId";
                ddlTypes.DataBind();


            }
        }

        protected void btnGetResult_Click(object sender, EventArgs e)
        {
            int yearId = Convert.ToInt32(ddlYears.SelectedValue);
            int studentId = Convert.ToInt32(ddlStudents.SelectedValue);
            int typeId = Convert.ToInt32(ddlTypes.SelectedValue);

            var result = service.getResult(studentId, typeId, yearId);

            lblResult.Text = result.ToString();
        }
    }
}