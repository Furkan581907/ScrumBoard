namespace ScrumBoard
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnProjeEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnProjeleriListele = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnScrumEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnKullaniciIslemleri = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.txtAltKullanici = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barbtnProjeEkle,
            this.barbtnProjeleriListele,
            this.barbtnScrumEkle,
            this.barbtnKullaniciIslemleri,
            this.barButtonItem1,
            this.txtAltKullanici});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage2});
            this.ribbon.QuickToolbarItemLinks.Add(this.barbtnKullaniciIslemleri);
            this.ribbon.Size = new System.Drawing.Size(1124, 282);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barbtnProjeEkle
            // 
            this.barbtnProjeEkle.Caption = "Proje Ekle";
            this.barbtnProjeEkle.Id = 1;
            this.barbtnProjeEkle.Name = "barbtnProjeEkle";
            this.barbtnProjeEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnProjeEkle_ItemClick);
            // 
            // barbtnProjeleriListele
            // 
            this.barbtnProjeleriListele.Caption = "Projeleri Listele";
            this.barbtnProjeleriListele.Id = 2;
            this.barbtnProjeleriListele.Name = "barbtnProjeleriListele";
            this.barbtnProjeleriListele.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnProjeleriListele_ItemClick);
            // 
            // barbtnScrumEkle
            // 
            this.barbtnScrumEkle.Caption = "Scrum Ekle";
            this.barbtnScrumEkle.Id = 3;
            this.barbtnScrumEkle.Name = "barbtnScrumEkle";
            this.barbtnScrumEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnScrumEkle_ItemClick);
            // 
            // barbtnKullaniciIslemleri
            // 
            this.barbtnKullaniciIslemleri.Caption = "barButtonItem1";
            this.barbtnKullaniciIslemleri.Id = 4;
            this.barbtnKullaniciIslemleri.Name = "barbtnKullaniciIslemleri";
            this.barbtnKullaniciIslemleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnKullaniciIslemleri_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Kullanıcı : ";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // txtAltKullanici
            // 
            this.txtAltKullanici.Id = 6;
            this.txtAltKullanici.Name = "txtAltKullanici";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Proje İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnProjeEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnProjeleriListele);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Proje İşlemleri";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Scrum İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnScrumEkle);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Scrum İşlemleri";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Kullanıcı İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.txtAltKullanici);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 643);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1124, 62);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 705);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barbtnProjeEkle;
        private DevExpress.XtraBars.BarButtonItem barbtnProjeleriListele;
        private DevExpress.XtraBars.BarButtonItem barbtnScrumEkle;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barbtnKullaniciIslemleri;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem txtAltKullanici;
    }
}