namespace VideoRental
{
    partial class formVideoInfoSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbPrintExcel = new System.Windows.Forms.GroupBox();
            this.btnVideoRentalStatus = new System.Windows.Forms.Button();
            this.btnVideoList = new System.Windows.Forms.Button();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbPrintExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "비디오 장르 :";
            // 
            // gbPrintExcel
            // 
            this.gbPrintExcel.Controls.Add(this.btnVideoRentalStatus);
            this.gbPrintExcel.Controls.Add(this.btnVideoList);
            this.gbPrintExcel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbPrintExcel.Location = new System.Drawing.Point(23, 48);
            this.gbPrintExcel.Margin = new System.Windows.Forms.Padding(2);
            this.gbPrintExcel.Name = "gbPrintExcel";
            this.gbPrintExcel.Padding = new System.Windows.Forms.Padding(2);
            this.gbPrintExcel.Size = new System.Drawing.Size(298, 69);
            this.gbPrintExcel.TabIndex = 1;
            this.gbPrintExcel.TabStop = false;
            this.gbPrintExcel.Text = "엑셀로 출력";
            // 
            // btnVideoRentalStatus
            // 
            this.btnVideoRentalStatus.Location = new System.Drawing.Point(160, 21);
            this.btnVideoRentalStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideoRentalStatus.Name = "btnVideoRentalStatus";
            this.btnVideoRentalStatus.Size = new System.Drawing.Size(127, 34);
            this.btnVideoRentalStatus.TabIndex = 1;
            this.btnVideoRentalStatus.Text = "대여 현황";
            this.btnVideoRentalStatus.UseVisualStyleBackColor = true;
            this.btnVideoRentalStatus.Click += new System.EventHandler(this.btnVideoRentalStatus_Click);
            // 
            // btnVideoList
            // 
            this.btnVideoList.Location = new System.Drawing.Point(15, 21);
            this.btnVideoList.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideoList.Name = "btnVideoList";
            this.btnVideoList.Size = new System.Drawing.Size(127, 34);
            this.btnVideoList.TabIndex = 0;
            this.btnVideoList.Text = "비디오 목록";
            this.btnVideoList.UseVisualStyleBackColor = true;
            this.btnVideoList.Click += new System.EventHandler(this.btnVideoList_Click);
            // 
            // comboGenre
            // 
            this.comboGenre.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(122, 17);
            this.comboGenre.Margin = new System.Windows.Forms.Padding(2);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(190, 23);
            this.comboGenre.TabIndex = 2;
            // 
            // formVideoInfoSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 133);
            this.Controls.Add(this.comboGenre);
            this.Controls.Add(this.gbPrintExcel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formVideoInfoSetting";
            this.Text = "비디오 정보";
            this.Load += new System.EventHandler(this.formVideoInfoSetting_Load);
            this.gbPrintExcel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPrintExcel;
        private System.Windows.Forms.Button btnVideoRentalStatus;
        private System.Windows.Forms.Button btnVideoList;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}