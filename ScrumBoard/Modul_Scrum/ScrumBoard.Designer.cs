namespace ScrumBoard.Modul_Scrum
{
    partial class ScrumBoard
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition5 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition6 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition6 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement8 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement9 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement10 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.SCRUMBASLIK = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.SCRUMONEMI = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.SCRUMACIKLAMA = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txtZaman = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOnemi = new DevExpress.XtraEditors.TextEdit();
            this.txtGorevli = new DevExpress.XtraEditors.TextEdit();
            this.txtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.txtProjeKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtEklenecekYer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.ID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.PROJEID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.KULLANICILARID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.SCRUMEKLENECEKYER = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.SCRUMGOREVLI = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOnemi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEklenecekYer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SCRUMBASLIK
            // 
            this.SCRUMBASLIK.Caption = "BAŞLIK";
            this.SCRUMBASLIK.FieldName = "SCRUMBASLIK";
            this.SCRUMBASLIK.Name = "SCRUMBASLIK";
            this.SCRUMBASLIK.OptionsColumn.AllowEdit = false;
            this.SCRUMBASLIK.OptionsColumn.AllowFocus = false;
            this.SCRUMBASLIK.OptionsColumn.FixedWidth = true;
            this.SCRUMBASLIK.Visible = true;
            this.SCRUMBASLIK.VisibleIndex = 2;
            // 
            // SCRUMONEMI
            // 
            this.SCRUMONEMI.Caption = "ÖNEMİ";
            this.SCRUMONEMI.FieldName = "SCRUMONEMI";
            this.SCRUMONEMI.Name = "SCRUMONEMI";
            this.SCRUMONEMI.OptionsColumn.AllowEdit = false;
            this.SCRUMONEMI.OptionsColumn.AllowFocus = false;
            this.SCRUMONEMI.OptionsColumn.FixedWidth = true;
            this.SCRUMONEMI.Visible = true;
            this.SCRUMONEMI.VisibleIndex = 5;
            // 
            // SCRUMACIKLAMA
            // 
            this.SCRUMACIKLAMA.Caption = "AÇIKLAMA";
            this.SCRUMACIKLAMA.FieldName = "SCRUMACIKLAMA";
            this.SCRUMACIKLAMA.Name = "SCRUMACIKLAMA";
            this.SCRUMACIKLAMA.OptionsColumn.AllowEdit = false;
            this.SCRUMACIKLAMA.OptionsColumn.AllowFocus = false;
            this.SCRUMACIKLAMA.OptionsColumn.FixedWidth = true;
            this.SCRUMACIKLAMA.Visible = true;
            this.SCRUMACIKLAMA.VisibleIndex = 6;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.txtZaman);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnSil);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnKaydet);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtOnemi);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtGorevli);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtBaslik);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtProjeKodu);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtAciklama);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtEklenecekYer);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1570, 641);
            this.splitContainerControl1.SplitterPosition = 133;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // txtZaman
            // 
            this.txtZaman.Location = new System.Drawing.Point(685, 85);
            this.txtZaman.Name = "txtZaman";
            this.txtZaman.Size = new System.Drawing.Size(200, 33);
            this.txtZaman.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(842, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 25);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Açıklama";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1127, 54);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(144, 44);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(592, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 25);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Zaman";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(293, 83);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(130, 25);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Eklenecek Yer";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(592, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 25);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Önemi";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(293, 43);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 25);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Görevli";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Başlık";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Proje Kodu";
            // 
            // txtOnemi
            // 
            this.txtOnemi.Location = new System.Drawing.Point(685, 41);
            this.txtOnemi.Name = "txtOnemi";
            this.txtOnemi.Size = new System.Drawing.Size(135, 34);
            this.txtOnemi.TabIndex = 0;
            // 
            // txtGorevli
            // 
            this.txtGorevli.Location = new System.Drawing.Point(430, 39);
            this.txtGorevli.Name = "txtGorevli";
            this.txtGorevli.Size = new System.Drawing.Size(135, 34);
            this.txtGorevli.TabIndex = 0;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(119, 78);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(140, 34);
            this.txtBaslik.TabIndex = 0;
            // 
            // txtProjeKodu
            // 
            this.txtProjeKodu.Location = new System.Drawing.Point(119, 39);
            this.txtProjeKodu.Name = "txtProjeKodu";
            this.txtProjeKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtProjeKodu.Size = new System.Drawing.Size(140, 34);
            this.txtProjeKodu.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(931, 41);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(178, 74);
            this.txtAciklama.TabIndex = 0;
            // 
            // txtEklenecekYer
            // 
            this.txtEklenecekYer.EditValue = "aTask";
            this.txtEklenecekYer.Location = new System.Drawing.Point(430, 79);
            this.txtEklenecekYer.Name = "txtEklenecekYer";
            this.txtEklenecekYer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEklenecekYer.Properties.Items.AddRange(new object[] {
            "aTask",
            "bNot Started",
            "cDo Today",
            "dIn Progress",
            "Done"});
            this.txtEklenecekYer.Size = new System.Drawing.Size(135, 34);
            this.txtEklenecekYer.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1570, 498);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.PROJEID,
            this.SCRUMBASLIK,
            this.KULLANICILARID,
            this.SCRUMEKLENECEKYER,
            this.SCRUMONEMI,
            this.SCRUMACIKLAMA,
            this.SCRUMGOREVLI});
            this.tileView1.ColumnSet.GroupColumn = this.SCRUMEKLENECEKYER;
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Tile.TileViewEditingMode.EditForm;
            this.tileView1.OptionsDragDrop.AllowDrag = true;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(370, 150);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.SCRUMEKLENECEKYER, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tileView1.TileColumns.Add(tableColumnDefinition4);
            this.tileView1.TileColumns.Add(tableColumnDefinition5);
            this.tileView1.TileColumns.Add(tableColumnDefinition6);
            this.tileView1.TileRows.Add(tableRowDefinition4);
            this.tileView1.TileRows.Add(tableRowDefinition5);
            this.tileView1.TileRows.Add(tableRowDefinition6);
            tileViewItemElement6.Column = this.SCRUMBASLIK;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.Text = "SCRUMBASLIK";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.Column = this.SCRUMONEMI;
            tileViewItemElement7.ColumnIndex = 1;
            tileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement7.RowIndex = 2;
            tileViewItemElement7.Text = "SCRUMONEMI";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.Column = this.SCRUMACIKLAMA;
            tileViewItemElement8.ColumnIndex = 2;
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement8.Text = "SCRUMACIKLAMA";
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement9.Column = this.SCRUMGOREVLI;
            tileViewItemElement9.ColumnIndex = 2;
            tileViewItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement9.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement9.RowIndex = 2;
            tileViewItemElement9.Text = "SCRUMGOREVLI";
            tileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement10.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement10.RowIndex = 2;
            tileViewItemElement10.Text = "Önemi :";
            tileViewItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement6);
            this.tileView1.TileTemplate.Add(tileViewItemElement7);
            this.tileView1.TileTemplate.Add(tileViewItemElement8);
            this.tileView1.TileTemplate.Add(tileViewItemElement9);
            this.tileView1.TileTemplate.Add(tileViewItemElement10);
            this.tileView1.DoubleClick += new System.EventHandler(this.tileView1_DoubleClick);
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
            // 
            // PROJEID
            // 
            this.PROJEID.Caption = "PROJEID";
            this.PROJEID.FieldName = "PROJEID";
            this.PROJEID.Name = "PROJEID";
            this.PROJEID.OptionsColumn.AllowEdit = false;
            this.PROJEID.OptionsColumn.AllowFocus = false;
            this.PROJEID.OptionsColumn.FixedWidth = true;
            this.PROJEID.Visible = true;
            this.PROJEID.VisibleIndex = 1;
            // 
            // KULLANICILARID
            // 
            this.KULLANICILARID.Caption = "GÖREVLİ";
            this.KULLANICILARID.FieldName = "KULLANICILARID";
            this.KULLANICILARID.Name = "KULLANICILARID";
            this.KULLANICILARID.OptionsColumn.AllowEdit = false;
            this.KULLANICILARID.OptionsColumn.AllowFocus = false;
            this.KULLANICILARID.OptionsColumn.FixedWidth = true;
            this.KULLANICILARID.Visible = true;
            this.KULLANICILARID.VisibleIndex = 3;
            // 
            // SCRUMEKLENECEKYER
            // 
            this.SCRUMEKLENECEKYER.Caption = "EKLENECEK YER";
            this.SCRUMEKLENECEKYER.FieldName = "SCRUMEKLENECEKYER";
            this.SCRUMEKLENECEKYER.Name = "SCRUMEKLENECEKYER";
            this.SCRUMEKLENECEKYER.OptionsColumn.AllowEdit = false;
            this.SCRUMEKLENECEKYER.OptionsColumn.AllowFocus = false;
            this.SCRUMEKLENECEKYER.OptionsColumn.FixedWidth = true;
            this.SCRUMEKLENECEKYER.Visible = true;
            this.SCRUMEKLENECEKYER.VisibleIndex = 4;
            // 
            // SCRUMGOREVLI
            // 
            this.SCRUMGOREVLI.Caption = "GÖREVLİ";
            this.SCRUMGOREVLI.FieldName = "SCRUMGOREVLI";
            this.SCRUMGOREVLI.Name = "SCRUMGOREVLI";
            this.SCRUMGOREVLI.Visible = true;
            this.SCRUMGOREVLI.VisibleIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1277, 54);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 44);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // ScrumBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 641);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScrumBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScrumBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScrumBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOnemi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjeKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEklenecekYer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtOnemi;
        private DevExpress.XtraEditors.TextEdit txtGorevli;
        private DevExpress.XtraEditors.TextEdit txtBaslik;
        private DevExpress.XtraEditors.ButtonEdit txtProjeKodu;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.ComboBoxEdit txtEklenecekYer;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.DateTimePicker txtZaman;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn ID;
        private DevExpress.XtraGrid.Columns.TileViewColumn PROJEID;
        private DevExpress.XtraGrid.Columns.TileViewColumn SCRUMBASLIK;
        private DevExpress.XtraGrid.Columns.TileViewColumn KULLANICILARID;
        private DevExpress.XtraGrid.Columns.TileViewColumn SCRUMEKLENECEKYER;
        private DevExpress.XtraGrid.Columns.TileViewColumn SCRUMONEMI;
        private DevExpress.XtraGrid.Columns.TileViewColumn SCRUMACIKLAMA;
        private DevExpress.XtraGrid.Columns.TileViewColumn SCRUMGOREVLI;
        private DevExpress.XtraEditors.SimpleButton btnSil;
    }
}