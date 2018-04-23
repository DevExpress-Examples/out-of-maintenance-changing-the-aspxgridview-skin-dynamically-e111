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
Imports DevExpress.Web.ASPxTabControl
Imports DevExpress.Xpo
Imports System.Drawing
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxEditors
Imports System.Collections.Generic
Imports DevExpress.Data
Imports DevExpress.Web.ASPxDataView
Imports System.Collections
Imports System.Data.OleDb
Imports DevExpress.Web.ASPxClasses.Internal
Imports System.IO
Imports DevExpress.Data.Filtering

Partial Public Class Change_Skin_ID
	Inherits System.Web.UI.Page

	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		If Request.Form("ASPxRadioButtonList1") = "Glass" Then
			ASPxGridView1.SkinID = "GlassSkin"
		Else
			ASPxGridView1.SkinID = "OfficeSkin"
		End If
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
End Class
