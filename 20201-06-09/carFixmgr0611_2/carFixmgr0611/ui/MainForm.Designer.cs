
namespace carFixmgr0611
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.custFixview = new CxFlatUI.CxFlatRoundButton();
            this.custFixAdmin = new CxFlatUI.CxFlatRoundButton();
            this.custFixRandData = new CxFlatUI.CxFlatRoundButton();
            this.custFixinfo = new CxFlatUI.CxFlatRoundButton();
            this.custFixAdd = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(12, 71);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(329, 534);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 0;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // custFixview
            // 
            this.custFixview.BackColor = System.Drawing.Color.Transparent;
            this.custFixview.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custFixview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixview.Location = new System.Drawing.Point(412, 183);
            this.custFixview.Name = "custFixview";
            this.custFixview.Size = new System.Drawing.Size(363, 64);
            this.custFixview.TabIndex = 2;
            this.custFixview.Text = "수리내역";
            this.custFixview.TextColor = System.Drawing.Color.White;
            this.custFixview.Click += new System.EventHandler(this.custFixview_Click);
            // 
            // custFixAdmin
            // 
            this.custFixAdmin.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custFixAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixAdmin.Location = new System.Drawing.Point(412, 281);
            this.custFixAdmin.Name = "custFixAdmin";
            this.custFixAdmin.Size = new System.Drawing.Size(363, 64);
            this.custFixAdmin.TabIndex = 3;
            this.custFixAdmin.Text = "관리자 모드";
            this.custFixAdmin.TextColor = System.Drawing.Color.White;
            this.custFixAdmin.Click += new System.EventHandler(this.custFixAdmin_Click);
            // 
            // custFixRandData
            // 
            this.custFixRandData.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custFixRandData.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixRandData.Location = new System.Drawing.Point(412, 379);
            this.custFixRandData.Name = "custFixRandData";
            this.custFixRandData.Size = new System.Drawing.Size(363, 64);
            this.custFixRandData.TabIndex = 4;
            this.custFixRandData.Text = "랜덤 데이터 추가";
            this.custFixRandData.TextColor = System.Drawing.Color.White;
            this.custFixRandData.Click += new System.EventHandler(this.custFixRandData_Click);
            // 
            // custFixinfo
            // 
            this.custFixinfo.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custFixinfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixinfo.Location = new System.Drawing.Point(412, 477);
            this.custFixinfo.Name = "custFixinfo";
            this.custFixinfo.Size = new System.Drawing.Size(363, 64);
            this.custFixinfo.TabIndex = 5;
            this.custFixinfo.Text = "앱정보";
            this.custFixinfo.TextColor = System.Drawing.Color.White;
            this.custFixinfo.Click += new System.EventHandler(this.custFixinfo_Click);
            // 
            // custFixAdd
            // 
            this.custFixAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixAdd.Location = new System.Drawing.Point(412, 85);
            this.custFixAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixAdd.Name = "custFixAdd";
            this.custFixAdd.Size = new System.Drawing.Size(363, 64);
            this.custFixAdd.Symbol = 62004;
            this.custFixAdd.TabIndex = 6;
            this.custFixAdd.Text = "고객정보접수";
            this.custFixAdd.Click += new System.EventHandler(this.custFixAdd_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.ForeColor = System.Drawing.Color.FloralWhite;
            this.mainExit.IsCircle = true;
            this.mainExit.Location = new System.Drawing.Point(819, 4);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(50, 50);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.SymbolSize = 45;
            this.mainExit.TabIndex = 7;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(41, 11);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(243, 43);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61881;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Silver;
            this.uiSymbolLabel1.TabIndex = 8;
            this.uiSymbolLabel1.Text = "카센터 관리앱 V1.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 617);
            this.ControlBox = false;
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.custFixAdd);
            this.Controls.Add(this.custFixinfo);
            this.Controls.Add(this.custFixRandData);
            this.Controls.Add(this.custFixAdmin);
            this.Controls.Add(this.custFixview);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatRoundButton custFixview;
        private CxFlatUI.CxFlatRoundButton custFixAdmin;
        private CxFlatUI.CxFlatRoundButton custFixRandData;
        private CxFlatUI.CxFlatRoundButton custFixinfo;
        private Sunny.UI.UISymbolButton custFixAdd;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}

