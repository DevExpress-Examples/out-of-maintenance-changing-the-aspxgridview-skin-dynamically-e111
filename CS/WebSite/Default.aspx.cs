using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxTabControl;
using DevExpress.Xpo;
using System.Drawing;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;
using System.Collections.Generic;
using DevExpress.Data;
using DevExpress.Web.ASPxDataView;
using System.Collections;
using System.Data.OleDb;
using DevExpress.Web.ASPxClasses.Internal;
using System.IO;
using DevExpress.Data.Filtering;

public partial class Change_Skin_ID: System.Web.UI.Page 
{

    protected void Page_PreInit(object sender, EventArgs e) {
        if(Request.Form["ASPxRadioButtonList1"] == "Glass")
            ASPxGridView1.SkinID = "GlassSkin";
        else
            ASPxGridView1.SkinID = "OfficeSkin";
    }

    protected void Page_Load(object sender, EventArgs e) {
   }
}
