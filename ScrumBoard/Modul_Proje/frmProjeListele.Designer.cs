namespace ScrumBoard.Modul_Proje
{
    partial class frmProjeListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtOnemi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtProjeKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtProjeAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROJEKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROJEADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROJEONEMI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROJEBASLANGICTARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROJEADISOYADI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOnemi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1163, 605);
            this.splitContainerControl1.SplitterPosition = 264;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(264, 605);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtOnemi);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtProjeKodu);
            this.xtraTabPage1.Controls.Add(this.txtProjeAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(252, 552);
            this.xtraTabPage1.Text = "Arama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(116, 303);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 40);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(10, 303);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 40);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtOnemi
            // 
            this.txtOnemi.Location = new System.Drawing.Point(10, 250);
            this.txtOnemi.Name = "txtOnemi";
            this.txtOnemi.Size = new System.Drawing.Size(206, 34);
            this.txtOnemi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 219);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 25);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Önemi :";
            // 
            // txtProjeKodu
            // 
            this.txtProjeKodu.Location = new System.Drawing.Point(10, 102);
            this.txtProjeKodu.Name = "txtProjeKodu";
            this.txtProjeKodu.Size = new System.Drawing.Size(206, 34);
            this.txtProjeKodu.TabIndex = 1;
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(10, 175);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(206, 34);
            this.txtProjeAdi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(116, 25);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Proje Kodu :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 144);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Proje Adı :";
            // 
            // liste
            // 
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.MainView = this.gridView1;
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(889, 605);
            this.liste.TabIndex = 0;
            this.liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.PROJEKODU,
            this.PROJEADI,
            this.PROJEONEMI,
            this.PROJEBASLANGICTARIHI,
            this.PROJEADISOYADI});
            this.gridView1.GridControl = this.liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 25;
            // 
            // PROJEKODU
            // 
            this.PROJEKODU.Caption = "PROJE KODU";
            this.PROJEKODU.FieldName = "PROJEKODU";
            this.PROJEKODU.Name = "PROJEKODU";
            this.PROJEKODU.OptionsColumn.AllowEdit = false;
            this.PROJEKODU.OptionsColumn.AllowFocus = false;
            this.PROJEKODU.OptionsColumn.FixedWidth = true;
            this.PROJEKODU.Visible = true;
            this.PROJEKODU.VisibleIndex = 2;
            this.PROJEKODU.Width = 63;
            // 
            // PROJEADI
            // 
            this.PROJEADI.Caption = "PROJE ADI";
            this.PROJEADI.FieldName = "PROJEADI";
            this.PROJEADI.Name = "PROJEADI";
            this.PROJEADI.OptionsColumn.AllowEdit = false;
            this.PROJEADI.OptionsColumn.AllowFocus = false;
            this.PROJEADI.OptionsColumn.FixedWidth = true;
            this.PROJEADI.Visible = true;
            this.PROJEADI.VisibleIndex = 1;
            // 
            // PROJEONEMI
            // 
            this.PROJEONEMI.Caption = "ÖNEMİ";
            this.PROJEONEMI.FieldName = "PROJEONEMI";
            this.PROJEONEMI.Name = "PROJEONEMI";
            this.PROJEONEMI.OptionsColumn.AllowEdit = false;
            this.PROJEONEMI.OptionsColumn.AllowFocus = false;
            this.PROJEONEMI.OptionsColumn.FixedWidth = true;
            this.PROJEONEMI.Visible = true;
            this.PROJEONEMI.VisibleIndex = 3;
            this.PROJEONEMI.Width = 61;
            // 
            // PROJEBASLANGICTARIHI
            // 
            this.PROJEBASLANGICTARIHI.Caption = "BAŞLANGIÇ TARİHİ";
            this.PROJEBASLANGICTARIHI.FieldName = "PROJEBASLANGICTARIHI";
            this.PROJEBASLANGICTARIHI.Name = "PROJEBASLANGICTARIHI";
            this.PROJEBASLANGICTARIHI.OptionsColumn.AllowEdit = false;
            this.PROJEBASLANGICTARIHI.OptionsColumn.AllowFocus = false;
            this.PROJEBASLANGICTARIHI.OptionsColumn.FixedWidth = true;
            this.PROJEBASLANGICTARIHI.Visible = true;
            this.PROJEBASLANGICTARIHI.VisibleIndex = 4;
            // 
            // PROJEADISOYADI
            // 
            this.PROJEADISOYADI.Caption = "PROJE SAHIBI";
            this.PROJEADISOYADI.FieldName = "PROJEADISOYADI";
            this.PROJEADISOYADI.Name = "PROJEADISOYADI";
            this.PROJEADISOYADI.OptionsColumn.AllowEdit = false;
            this.PROJEADISOYADI.OptionsColumn.AllowFocus = false;
            this.PROJEADISOYADI.OptionsColumn.FixedWidth = true;
            this.PROJEADISOYADI.Visible = true;
            this.PROJEADISOYADI.VisibleIndex = 5;
            // 
            // frmProjeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 605);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProjeListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje Listesi";
            this.Load += new System.EventHandler(this.frmProjeListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOnemi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtOnemi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtProjeAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtProjeKodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn PROJEKODU;
        private DevExpress.XtraGrid.Columns.GridColumn PROJEADI;
        private DevExpress.XtraGrid.Columns.GridColumn PROJEONEMI;
        private DevExpress.XtraGrid.Columns.GridColumn PROJEBASLANGICTARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn PROJEADISOYADI;
    }
}