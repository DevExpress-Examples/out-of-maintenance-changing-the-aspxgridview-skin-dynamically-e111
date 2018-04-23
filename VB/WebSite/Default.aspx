<%-- BeginRegion TagPrefix and page properties --%>
<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="Change_Skin_ID" Culture="auto" Theme="MyTheme" %>

<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web" TagPrefix="dxwgv" %>

<%-- EndRegion --%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>Changing the ASPxGridView Skin dynamically</title>
</head>
<body>
	<form id="form1" runat="server">

		<dxe:ASPxRadioButtonList ID="ASPxRadioButtonList1" runat="server" AutoPostBack="True"
			SelectedIndex="0">
			<Items>
				<dxe:ListEditItem Text="Glass" Value="GlassSkin" />
				<dxe:ListEditItem Text="Office" Value="OfficeSkin" />
			</Items>
		</dxe:ASPxRadioButtonList>
		<br />
		<br />
		&nbsp; &nbsp;&nbsp;
		<dxwgv:ASPxGridView ID="ASPxGridView1" runat="server" DataSourceID="AccessDataSource1" KeyFieldName="job_id" AutoGenerateColumns="False" Width="326px" SkinID="OfficeSkin" >            
			<Settings ShowGroupPanel="True" />
			<Columns>
                <dxwgv:GridViewCommandColumn VisibleIndex="0" ShowEditButton="True"/>
				<dxwgv:GridViewDataTextColumn FieldName="job_id" ReadOnly="True" VisibleIndex="1">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="job_desc" VisibleIndex="2">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="min_lvl" VisibleIndex="3">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="max_lvl" VisibleIndex="4">
				</dxwgv:GridViewDataTextColumn>
			</Columns>
		</dxwgv:ASPxGridView>
		&nbsp;
		<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/pubs.mdb"
			SelectCommand="SELECT * FROM [jobs]">
		</asp:AccessDataSource>
		&nbsp;&nbsp;&nbsp;<br />
		&nbsp;&nbsp;
	</form>    
</body>
</html>
