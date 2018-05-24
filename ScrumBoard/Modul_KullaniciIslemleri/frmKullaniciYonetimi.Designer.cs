namespace ScrumBoard.Modul_KullaniciIslemleri
{
    partial class frmKullaniciYonetimi
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSeciliKullaniciyiSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeciliKullaniciyiGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKullaniciEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KULLANICIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KULLANICIADSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KULLANICIAKTIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KULLANICIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSeciliKullaniciyiSil);
            this.groupControl1.Controls.Add(this.btnSeciliKullaniciyiGuncelle);
            this.groupControl1.Controls.Add(this.btnYeniKullaniciEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1041, 114);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnSeciliKullaniciyiSil
            // 
            this.btnSeciliKullaniciyiSil.Location = new System.Drawing.Point(737, 52);
            this.btnSeciliKullaniciyiSil.Name = "btnSeciliKullaniciyiSil";
            this.btnSeciliKullaniciyiSil.Size = new System.Drawing.Size(262, 45);
            this.btnSeciliKullaniciyiSil.TabIndex = 0;
            this.btnSeciliKullaniciyiSil.Text = "Seçili Kullanıcıyı Sil";
            this.btnSeciliKullaniciyiSil.Click += new System.EventHandler(this.btnSeciliKullaniciyiSil_Click);
            // 
            // btnSeciliKullaniciyiGuncelle
            // 
            this.btnSeciliKullaniciyiGuncelle.Location = new System.Drawing.Point(414, 52);
            this.btnSeciliKullaniciyiGuncelle.Name = "btnSeciliKullaniciyiGuncelle";
            this.btnSeciliKullaniciyiGuncelle.Size = new System.Drawing.Size(262, 45);
            this.btnSeciliKullaniciyiGuncelle.TabIndex = 0;
            this.btnSeciliKullaniciyiGuncelle.Text = "Seçili Kullanıcıyı Güncelle";
            this.btnSeciliKullaniciyiGuncelle.Click += new System.EventHandler(this.btnSeciliKullaniciyiGuncelle_Click);
            // 
            // btnYeniKullaniciEkle
            // 
            this.btnYeniKullaniciEkle.Location = new System.Drawing.Point(86, 52);
            this.btnYeniKullaniciEkle.Name = "btnYeniKullaniciEkle";
            this.btnYeniKullaniciEkle.Size = new System.Drawing.Size(262, 45);
            this.btnYeniKullaniciEkle.TabIndex = 0;
            this.btnYeniKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.btnYeniKullaniciEkle.Click += new System.EventHandler(this.btnYeniKullaniciEkle_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 114);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1041, 452);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "groupControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1035, 409);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KULLANICIADI,
            this.KULLANICIADSOYAD,
            this.KULLANICIAKTIF,
            this.KULLANICIKODU});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            // 
            // KULLANICIADI
            // 
            this.KULLANICIADI.Caption = "KULLANICI ADI";
            this.KULLANICIADI.FieldName = "KULLANICIADI";
            this.KULLANICIADI.Name = "KULLANICIADI";
            this.KULLANICIADI.OptionsColumn.AllowEdit = false;
            this.KULLANICIADI.OptionsColumn.AllowFocus = false;
            this.KULLANICIADI.OptionsColumn.FixedWidth = true;
            this.KULLANICIADI.OptionsColumn.ReadOnly = true;
            this.KULLANICIADI.Visible = true;
            this.KULLANICIADI.VisibleIndex = 0;
            // 
            // KULLANICIADSOYAD
            // 
            this.KULLANICIADSOYAD.Caption = "KULLANICI ADI SOYADI";
            this.KULLANICIADSOYAD.FieldName = "KULLANICIADSOYAD";
            this.KULLANICIADSOYAD.Name = "KULLANICIADSOYAD";
            this.KULLANICIADSOYAD.OptionsColumn.AllowEdit = false;
            this.KULLANICIADSOYAD.OptionsColumn.AllowFocus = false;
            this.KULLANICIADSOYAD.OptionsColumn.FixedWidth = true;
            this.KULLANICIADSOYAD.OptionsColumn.ReadOnly = true;
            this.KULLANICIADSOYAD.Visible = true;
            this.KULLANICIADSOYAD.VisibleIndex = 1;
            // 
            // KULLANICIAKTIF
            // 
            this.KULLANICIAKTIF.Caption = "AKTİF ";
            this.KULLANICIAKTIF.FieldName = "KULLANICIAKTIF";
            this.KULLANICIAKTIF.Name = "KULLANICIAKTIF";
            this.KULLANICIAKTIF.OptionsColumn.AllowEdit = false;
            this.KULLANICIAKTIF.OptionsColumn.AllowFocus = false;
            this.KULLANICIAKTIF.OptionsColumn.FixedWidth = true;
            this.KULLANICIAKTIF.OptionsColumn.ReadOnly = true;
            this.KULLANICIAKTIF.Visible = true;
            this.KULLANICIAKTIF.VisibleIndex = 2;
            // 
            // KULLANICIKODU
            // 
            this.KULLANICIKODU.Caption = "KULLANICI KODU";
            this.KULLANICIKODU.FieldName = "KULLANICIKODU";
            this.KULLANICIKODU.Name = "KULLANICIKODU";
            this.KULLANICIKODU.OptionsColumn.AllowEdit = false;
            this.KULLANICIKODU.OptionsColumn.AllowFocus = false;
            this.KULLANICIKODU.OptionsColumn.FixedWidth = true;
            this.KULLANICIKODU.OptionsColumn.ReadOnly = true;
            this.KULLANICIKODU.Visible = true;
            this.KULLANICIKODU.VisibleIndex = 3;
            // 
            // frmKullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 566);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSeciliKullaniciyiSil;
        private DevExpress.XtraEditors.SimpleButton btnSeciliKullaniciyiGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnYeniKullaniciEkle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn KULLANICIADI;
        private DevExpress.XtraGrid.Columns.GridColumn KULLANICIADSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn KULLANICIAKTIF;
        private DevExpress.XtraGrid.Columns.GridColumn KULLANICIKODU;
    }
}