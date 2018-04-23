Imports Microsoft.VisualBasic
Imports System
Namespace CompoundPrinting
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New CompoundPrinting.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductID4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.productsTableAdapter = New CompoundPrinting.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.categoriesViewLink = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
			Me.productsViewLink = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
			Me.compositeLink = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
			Me.colProductID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.categoriesTableAdapter = New CompoundPrinting.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.colProductID2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductID3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName3 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesViewLink.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsViewLink.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.compositeLink.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(412, 306)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.xtraTabPage1.Controls.Add(Me.gridControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(403, 275)
			Me.xtraTabPage1.Text = "Categories"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.categoriesBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(403, 275)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID, Me.colCategoryName})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colCategoryID
			' 
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 0
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.xtraTabPage2.Controls.Add(Me.gridControl2)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(403, 275)
			Me.xtraTabPage2.Text = "Products"
			' 
			' gridControl2
			' 
			Me.gridControl2.DataSource = Me.productsBindingSource
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl2.Location = New System.Drawing.Point(0, 0)
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(403, 275)
			Me.gridControl2.TabIndex = 2
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID4, Me.colProductName4})
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.Name = "gridView2"
			' 
			' colProductID4
			' 
			Me.colProductID4.FieldName = "ProductID"
			Me.colProductID4.Name = "colProductID4"
			Me.colProductID4.Visible = True
			Me.colProductID4.VisibleIndex = 0
			' 
			' colProductName4
			' 
			Me.colProductName4.FieldName = "ProductName"
			Me.colProductName4.Name = "colProductName4"
			Me.colProductName4.Visible = True
			Me.colProductName4.VisibleIndex = 1
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 306)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(412, 33)
			Me.panelControl1.TabIndex = 2
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(5, 5)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Print"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' colProductID
			' 
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			Me.colProductID.Visible = True
			Me.colProductID.VisibleIndex = 0
			' 
			' colProductName
			' 
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 1
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' printingSystem1
			' 
			Me.printingSystem1.Links.AddRange(New Object() { Me.categoriesViewLink, Me.productsViewLink, Me.compositeLink})
			' 
			' categoriesViewLink
			' 
			Me.categoriesViewLink.Component = Me.gridControl1
			' 
			' 
			' 
			Me.categoriesViewLink.ImageCollection.ImageStream = (CType(resources.GetObject("categoriesViewLink.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.categoriesViewLink.PrintingSystem = Me.printingSystem1
			' 
			' productsViewLink
			' 
			Me.productsViewLink.Component = Me.gridControl2
			' 
			' 
			' 
			Me.productsViewLink.ImageCollection.ImageStream = (CType(resources.GetObject("productsViewLink.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.productsViewLink.PrintingSystem = Me.printingSystem1
			' 
			' compositeLink
			' 
			' 
			' 
			' 
			Me.compositeLink.ImageCollection.ImageStream = (CType(resources.GetObject("compositeLink.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.compositeLink.Links.AddRange(New Object() { Me.categoriesViewLink, Me.productsViewLink})
			Me.compositeLink.PrintingSystem = Me.printingSystem1
			' 
			' colProductID1
			' 
			Me.colProductID1.FieldName = "ProductID"
			Me.colProductID1.Name = "colProductID1"
			Me.colProductID1.Visible = True
			Me.colProductID1.VisibleIndex = 0
			' 
			' colProductName1
			' 
			Me.colProductName1.FieldName = "ProductName"
			Me.colProductName1.Name = "colProductName1"
			Me.colProductName1.Visible = True
			Me.colProductName1.VisibleIndex = 1
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' colProductID2
			' 
			Me.colProductID2.FieldName = "ProductID"
			Me.colProductID2.Name = "colProductID2"
			Me.colProductID2.Visible = True
			Me.colProductID2.VisibleIndex = 0
			' 
			' colProductName2
			' 
			Me.colProductName2.FieldName = "ProductName"
			Me.colProductName2.Name = "colProductName2"
			Me.colProductName2.Visible = True
			Me.colProductName2.VisibleIndex = 1
			' 
			' colProductID3
			' 
			Me.colProductID3.FieldName = "ProductID"
			Me.colProductID3.Name = "colProductID3"
			Me.colProductID3.Visible = True
			Me.colProductID3.VisibleIndex = 0
			' 
			' colProductName3
			' 
			Me.colProductName3.FieldName = "ProductName"
			Me.colProductName3.Name = "colProductName3"
			Me.colProductName3.Visible = True
			Me.colProductName3.VisibleIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(412, 339)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "DX Sample"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesViewLink.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsViewLink.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.compositeLink.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private nwindDataSet As nwindDataSet
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As CompoundPrinting.nwindDataSetTableAdapters.ProductsTableAdapter
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
		Private categoriesViewLink As DevExpress.XtraPrinting.PrintableComponentLink
		Private productsViewLink As DevExpress.XtraPrinting.PrintableComponentLink
		Private compositeLink As DevExpress.XtraPrintingLinks.CompositeLink
		Private colProductID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName1 As DevExpress.XtraGrid.Columns.GridColumn
		Private categoriesTableAdapter As CompoundPrinting.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private colProductID2 As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName2 As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductID3 As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colProductID4 As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName4 As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

