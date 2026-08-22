namespace VideoRental
{
    partial class formInformationCheck
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
            this.gbCheckInfo = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textCustomerType = new System.Windows.Forms.TextBox();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRentalVideo = new System.Windows.Forms.RadioButton();
            this.rbCustomerRentalRanking = new System.Windows.Forms.RadioButton();
            this.rbVideoRentalRanking = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_Rental_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cusomer_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCheckInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCheckInfo
            // 
            this.gbCheckInfo.Controls.Add(this.btnExit);
            this.gbCheckInfo.Controls.Add(this.btnSearch);
            this.gbCheckInfo.Controls.Add(this.textCustomerType);
            this.gbCheckInfo.Controls.Add(this.textGenre);
            this.gbCheckInfo.Controls.Add(this.label2);
            this.gbCheckInfo.Controls.Add(this.label1);
            this.gbCheckInfo.Controls.Add(this.rbRentalVideo);
            this.gbCheckInfo.Controls.Add(this.rbCustomerRentalRanking);
            this.gbCheckInfo.Controls.Add(this.rbVideoRentalRanking);
            this.gbCheckInfo.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbCheckInfo.Location = new System.Drawing.Point(18, 15);
            this.gbCheckInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbCheckInfo.Name = "gbCheckInfo";
            this.gbCheckInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbCheckInfo.Size = new System.Drawing.Size(734, 87);
            this.gbCheckInfo.TabIndex = 0;
            this.gbCheckInfo.TabStop = false;
            this.gbCheckInfo.Text = "조회 정보";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(630, 25);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "나가기";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(535, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 48);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textCustomerType
            // 
            this.textCustomerType.Location = new System.Drawing.Point(405, 53);
            this.textCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerType.Name = "textCustomerType";
            this.textCustomerType.Size = new System.Drawing.Size(118, 24);
            this.textCustomerType.TabIndex = 6;
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(405, 27);
            this.textGenre.Margin = new System.Windows.Forms.Padding(2);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(118, 24);
            this.textGenre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "고객 신분 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "장르 :";
            // 
            // rbRentalVideo
            // 
            this.rbRentalVideo.AutoSize = true;
            this.rbRentalVideo.Location = new System.Drawing.Point(174, 28);
            this.rbRentalVideo.Margin = new System.Windows.Forms.Padding(2);
            this.rbRentalVideo.Name = "rbRentalVideo";
            this.rbRentalVideo.Size = new System.Drawing.Size(135, 19);
            this.rbRentalVideo.TabIndex = 2;
            this.rbRentalVideo.TabStop = true;
            this.rbRentalVideo.Text = "대여중인 비디오";
            this.rbRentalVideo.UseVisualStyleBackColor = true;
            // 
            // rbCustomerRentalRanking
            // 
            this.rbCustomerRentalRanking.AutoSize = true;
            this.rbCustomerRentalRanking.Location = new System.Drawing.Point(27, 56);
            this.rbCustomerRentalRanking.Margin = new System.Windows.Forms.Padding(2);
            this.rbCustomerRentalRanking.Name = "rbCustomerRentalRanking";
            this.rbCustomerRentalRanking.Size = new System.Drawing.Size(125, 19);
            this.rbCustomerRentalRanking.TabIndex = 1;
            this.rbCustomerRentalRanking.TabStop = true;
            this.rbCustomerRentalRanking.Text = "고객 대여 순위";
            this.rbCustomerRentalRanking.UseVisualStyleBackColor = true;
            // 
            // rbVideoRentalRanking
            // 
            this.rbVideoRentalRanking.AutoSize = true;
            this.rbVideoRentalRanking.Location = new System.Drawing.Point(27, 27);
            this.rbVideoRentalRanking.Margin = new System.Windows.Forms.Padding(2);
            this.rbVideoRentalRanking.Name = "rbVideoRentalRanking";
            this.rbVideoRentalRanking.Size = new System.Drawing.Size(140, 19);
            this.rbVideoRentalRanking.TabIndex = 0;
            this.rbVideoRentalRanking.TabStop = true;
            this.rbVideoRentalRanking.Text = "비디오 대여 순위";
            this.rbVideoRentalRanking.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Rental_Count,
            this.Col_Customer_Name,
            this.Col_Cusomer_Type,
            this.Col_Gender,
            this.Col_Phone,
            this.Col_CellPhone,
            this.Col_Addr});
            this.dataGridView1.Location = new System.Drawing.Point(18, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(734, 379);
            this.dataGridView1.TabIndex = 1;
            // 
            // Col_Rental_Count
            // 
            this.Col_Rental_Count.HeaderText = "대여횟수";
            this.Col_Rental_Count.MinimumWidth = 8;
            this.Col_Rental_Count.Name = "Col_Rental_Count";
            this.Col_Rental_Count.Width = 150;
            // 
            // Col_Customer_Name
            // 
            this.Col_Customer_Name.HeaderText = "고객 이름";
            this.Col_Customer_Name.MinimumWidth = 8;
            this.Col_Customer_Name.Name = "Col_Customer_Name";
            this.Col_Customer_Name.Width = 150;
            // 
            // Col_Cusomer_Type
            // 
            this.Col_Cusomer_Type.HeaderText = "등급";
            this.Col_Cusomer_Type.MinimumWidth = 8;
            this.Col_Cusomer_Type.Name = "Col_Cusomer_Type";
            this.Col_Cusomer_Type.Width = 150;
            // 
            // Col_Gender
            // 
            this.Col_Gender.HeaderText = "성별";
            this.Col_Gender.MinimumWidth = 8;
            this.Col_Gender.Name = "Col_Gender";
            this.Col_Gender.Width = 150;
            // 
            // Col_Phone
            // 
            this.Col_Phone.HeaderText = "연락처";
            this.Col_Phone.MinimumWidth = 8;
            this.Col_Phone.Name = "Col_Phone";
            this.Col_Phone.Width = 150;
            // 
            // Col_CellPhone
            // 
            this.Col_CellPhone.HeaderText = "휴대폰";
            this.Col_CellPhone.MinimumWidth = 8;
            this.Col_CellPhone.Name = "Col_CellPhone";
            this.Col_CellPhone.Width = 150;
            // 
            // Col_Addr
            // 
            this.Col_Addr.HeaderText = "주소";
            this.Col_Addr.MinimumWidth = 8;
            this.Col_Addr.Name = "Col_Addr";
            this.Col_Addr.Width = 150;
            // 
            // formInformationCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbCheckInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formInformationCheck";
            this.Text = "비디오 조회 관리";
            this.gbCheckInfo.ResumeLayout(false);
            this.gbCheckInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCheckInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textCustomerType;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRentalVideo;
        private System.Windows.Forms.RadioButton rbCustomerRentalRanking;
        private System.Windows.Forms.RadioButton rbVideoRentalRanking;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Rental_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cusomer_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Addr;
    }
}