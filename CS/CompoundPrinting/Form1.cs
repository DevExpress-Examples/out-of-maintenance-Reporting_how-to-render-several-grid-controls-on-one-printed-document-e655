using System;
using DevExpress.XtraEditors;

namespace CompoundPrinting {
    public partial class Form1 :XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            productsTableAdapter.Fill(nwindDataSet.Products);
            categoriesTableAdapter.Fill(nwindDataSet.Categories);
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            compositeLink.ShowPreview();
        }
    }
}