Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web
Imports DevExpress.Xpo
Imports System.Drawing
Imports System.Collections.Generic
Imports DevExpress.Data
Imports System.Collections
Imports System.Data.OleDb
Imports DevExpress.Web.Internal
Imports System.IO
Imports DevExpress.Data.Filtering

Partial Public Class Change_Skin_ID
	Inherits System.Web.UI.Page

	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		Dim index As Integer = 0
		Integer.TryParse(Request.Form("ASPxRadioButtonList1"), index)
		ASPxGridView1.SkinID = Convert.ToString(ASPxRadioButtonList1.Items(index).Value)
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
End Class
