namespace CompoundPrinting {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new CompoundPrinting.nwindDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productsTableAdapter = new CompoundPrinting.nwindDataSetTableAdapters.ProductsTableAdapter();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.categoriesViewLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.productsViewLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.compositeLink = new DevExpress.XtraPrintingLinks.CompositeLink(this.components);
            this.colProductID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoriesTableAdapter = new CompoundPrinting.nwindDataSetTableAdapters.CategoriesTableAdapter();
            this.colProductID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesViewLink.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewLink.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositeLink.ImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(412, 306);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(403, 275);
            this.xtraTabPage1.Text = "Categories";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.categoriesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(403, 275);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colCategoryName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 0;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(403, 275);
            this.xtraTabPage2.Text = "Products";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.productsBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(403, 275);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.nwindDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID4,
            this.colProductName4});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colProductID4
            // 
            this.colProductID4.FieldName = "ProductID";
            this.colProductID4.Name = "colProductID4";
            this.colProductID4.Visible = true;
            this.colProductID4.VisibleIndex = 0;
            // 
            // colProductName4
            // 
            this.colProductName4.FieldName = "ProductName";
            this.colProductName4.Name = "colProductName4";
            this.colProductName4.Visible = true;
            this.colProductName4.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 306);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(412, 33);
            this.panelControl1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Print";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.categoriesViewLink,
            this.productsViewLink,
            this.compositeLink});
            // 
            // categoriesViewLink
            // 
            this.categoriesViewLink.Component = this.gridControl1;
            // 
            // 
            // 
            this.categoriesViewLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("categoriesViewLink.ImageCollection.ImageStream")));
            this.categoriesViewLink.PrintingSystem = this.printingSystem1;
            // 
            // productsViewLink
            // 
            this.productsViewLink.Component = this.gridControl2;
            // 
            // 
            // 
            this.productsViewLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("productsViewLink.ImageCollection.ImageStream")));
            this.productsViewLink.PrintingSystem = this.printingSystem1;
            // 
            // compositeLink
            // 
            // 
            // 
            // 
            this.compositeLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("compositeLink.ImageCollection.ImageStream")));
            this.compositeLink.Links.AddRange(new object[] {
            this.categoriesViewLink,
            this.productsViewLink});
            this.compositeLink.PrintingSystem = this.printingSystem1;
            // 
            // colProductID1
            // 
            this.colProductID1.FieldName = "ProductID";
            this.colProductID1.Name = "colProductID1";
            this.colProductID1.Visible = true;
            this.colProductID1.VisibleIndex = 0;
            // 
            // colProductName1
            // 
            this.colProductName1.FieldName = "ProductName";
            this.colProductName1.Name = "colProductName1";
            this.colProductName1.Visible = true;
            this.colProductName1.VisibleIndex = 1;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // colProductID2
            // 
            this.colProductID2.FieldName = "ProductID";
            this.colProductID2.Name = "colProductID2";
            this.colProductID2.Visible = true;
            this.colProductID2.VisibleIndex = 0;
            // 
            // colProductName2
            // 
            this.colProductName2.FieldName = "ProductName";
            this.colProductName2.Name = "colProductName2";
            this.colProductName2.Visible = true;
            this.colProductName2.VisibleIndex = 1;
            // 
            // colProductID3
            // 
            this.colProductID3.FieldName = "ProductID";
            this.colProductID3.Name = "colProductID3";
            this.colProductID3.Visible = true;
            this.colProductID3.VisibleIndex = 0;
            // 
            // colProductName3
            // 
            this.colProductName3.FieldName = "ProductName";
            this.colProductName3.Name = "colProductName3";
            this.colProductName3.Visible = true;
            this.colProductName3.VisibleIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 339);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "DX Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesViewLink.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsViewLink.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositeLink.ImageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private nwindDataSet nwindDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private CompoundPrinting.nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink categoriesViewLink;
        private DevExpress.XtraPrinting.PrintableComponentLink productsViewLink;
        private DevExpress.XtraPrintingLinks.CompositeLink compositeLink;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName1;
        private CompoundPrinting.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID2;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName2;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID3;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID4;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName4;
    }
}

