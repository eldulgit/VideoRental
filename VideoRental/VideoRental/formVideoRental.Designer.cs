namespace VideoRental
{
    partial class formVideoRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVideoRental));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRentalReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVideoManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCustomerManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInfoCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tb_Rental_Return = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tb_VideoManage = new System.Windows.Forms.ToolStripButton();
            this.Tb_CustomerManage = new System.Windows.Forms.ToolStripButton();
            this.Tb_InfoCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tb_Setting = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.MnuRentalReturn,
            this.MnuVideoManage,
            this.MnuCustomerManage,
            this.MnuInfoCheck,
            this.MnuSetting,
            this.MnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1486, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(64, 29);
            this.Menu_File.Text = "파일";
            // 
            // Mnu_Exit
            // 
            this.Mnu_Exit.Name = "Mnu_Exit";
            this.Mnu_Exit.Size = new System.Drawing.Size(270, 34);
            this.Mnu_Exit.Text = "종료";
            this.Mnu_Exit.Click += new System.EventHandler(this.Mnu_Exit_Click);
            // 
            // MnuRentalReturn
            // 
            this.MnuRentalReturn.Name = "MnuRentalReturn";
            this.MnuRentalReturn.Size = new System.Drawing.Size(167, 29);
            this.MnuRentalReturn.Text = "비디오 대여/반납";
            this.MnuRentalReturn.Click += new System.EventHandler(this.MnuRentalReturn_Click);
            // 
            // MnuVideoManage
            // 
            this.MnuVideoManage.Name = "MnuVideoManage";
            this.MnuVideoManage.Size = new System.Drawing.Size(124, 29);
            this.MnuVideoManage.Text = "비디오 관리";
            this.MnuVideoManage.Click += new System.EventHandler(this.MnuVideoManage_Click);
            // 
            // MnuCustomerManage
            // 
            this.MnuCustomerManage.Name = "MnuCustomerManage";
            this.MnuCustomerManage.Size = new System.Drawing.Size(106, 29);
            this.MnuCustomerManage.Text = "고객 관리";
            this.MnuCustomerManage.Click += new System.EventHandler(this.MnuCustomerManage_Click);
            // 
            // MnuInfoCheck
            // 
            this.MnuInfoCheck.Name = "MnuInfoCheck";
            this.MnuInfoCheck.Size = new System.Drawing.Size(106, 29);
            this.MnuInfoCheck.Text = "정보 조회";
            this.MnuInfoCheck.Click += new System.EventHandler(this.MnuInfoCheck_Click);
            // 
            // MnuSetting
            // 
            this.MnuSetting.Name = "MnuSetting";
            this.MnuSetting.Size = new System.Drawing.Size(100, 29);
            this.MnuSetting.Text = "환경설정";
            this.MnuSetting.Click += new System.EventHandler(this.MnuSetting_Click);
            // 
            // MnuHelp
            // 
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(82, 29);
            this.MnuHelp.Text = "도움말";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tb_Rental_Return,
            this.toolStripSeparator1,
            this.Tb_VideoManage,
            this.Tb_CustomerManage,
            this.Tb_InfoCheck,
            this.toolStripSeparator2,
            this.Tb_Setting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1486, 58);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tb_Rental_Return
            // 
            this.Tb_Rental_Return.Image = ((System.Drawing.Image)(resources.GetObject("Tb_Rental_Return.Image")));
            this.Tb_Rental_Return.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tb_Rental_Return.Name = "Tb_Rental_Return";
            this.Tb_Rental_Return.Size = new System.Drawing.Size(95, 53);
            this.Tb_Rental_Return.Text = "대여/반납";
            this.Tb_Rental_Return.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tb_Rental_Return.Click += new System.EventHandler(this.Tb_Rental_Return_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // Tb_VideoManage
            // 
            this.Tb_VideoManage.Image = ((System.Drawing.Image)(resources.GetObject("Tb_VideoManage.Image")));
            this.Tb_VideoManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tb_VideoManage.Name = "Tb_VideoManage";
            this.Tb_VideoManage.Size = new System.Drawing.Size(106, 53);
            this.Tb_VideoManage.Text = "비디오관리";
            this.Tb_VideoManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tb_VideoManage.Click += new System.EventHandler(this.Tb_VideoManage_Click);
            // 
            // Tb_CustomerManage
            // 
            this.Tb_CustomerManage.Image = ((System.Drawing.Image)(resources.GetObject("Tb_CustomerManage.Image")));
            this.Tb_CustomerManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tb_CustomerManage.Name = "Tb_CustomerManage";
            this.Tb_CustomerManage.Size = new System.Drawing.Size(88, 53);
            this.Tb_CustomerManage.Text = "고객관리";
            this.Tb_CustomerManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tb_CustomerManage.Click += new System.EventHandler(this.Tb_CustomerManage_Click);
            // 
            // Tb_InfoCheck
            // 
            this.Tb_InfoCheck.Image = ((System.Drawing.Image)(resources.GetObject("Tb_InfoCheck.Image")));
            this.Tb_InfoCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tb_InfoCheck.Name = "Tb_InfoCheck";
            this.Tb_InfoCheck.Size = new System.Drawing.Size(94, 53);
            this.Tb_InfoCheck.Text = "정보 조회";
            this.Tb_InfoCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tb_InfoCheck.Click += new System.EventHandler(this.Tb_InfoCheck_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // Tb_Setting
            // 
            this.Tb_Setting.Image = ((System.Drawing.Image)(resources.GetObject("Tb_Setting.Image")));
            this.Tb_Setting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tb_Setting.Name = "Tb_Setting";
            this.Tb_Setting.Size = new System.Drawing.Size(88, 53);
            this.Tb_Setting.Text = "환경설정";
            this.Tb_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tb_Setting.Click += new System.EventHandler(this.Tb_Setting_Click);
            // 
            // formVideoRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 872);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formVideoRental";
            this.Text = "비디오 관리 프로그램";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem MnuRentalReturn;
        private System.Windows.Forms.ToolStripMenuItem MnuVideoManage;
        private System.Windows.Forms.ToolStripMenuItem MnuCustomerManage;
        private System.Windows.Forms.ToolStripMenuItem MnuInfoCheck;
        private System.Windows.Forms.ToolStripMenuItem MnuSetting;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tb_Rental_Return;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Tb_VideoManage;
        private System.Windows.Forms.ToolStripButton Tb_CustomerManage;
        private System.Windows.Forms.ToolStripButton Tb_InfoCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Tb_Setting;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Exit;
    }
}

