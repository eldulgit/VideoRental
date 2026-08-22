namespace VideoRental
{
    partial class formVideoInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_VideoInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.textProduction = new System.Windows.Forms.TextBox();
            this.textDirector = new System.Windows.Forms.TextBox();
            this.textActor = new System.Windows.Forms.TextBox();
            this.textVideoTitle = new System.Windows.Forms.TextBox();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.textVideoCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textTotalVideo = new System.Windows.Forms.TextBox();
            this.videoList = new System.Windows.Forms.DataGridView();
            this.Col_Video_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Video_Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Video_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Video_Actor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Video_Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Video_Production = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Video_ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_VideoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoList)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_VideoInfo
            // 
            this.gb_VideoInfo.Controls.Add(this.label7);
            this.gb_VideoInfo.Controls.Add(this.label6);
            this.gb_VideoInfo.Controls.Add(this.label5);
            this.gb_VideoInfo.Controls.Add(this.label4);
            this.gb_VideoInfo.Controls.Add(this.label3);
            this.gb_VideoInfo.Controls.Add(this.label2);
            this.gb_VideoInfo.Controls.Add(this.label1);
            this.gb_VideoInfo.Controls.Add(this.Dtp_ReleaseDate);
            this.gb_VideoInfo.Controls.Add(this.textProduction);
            this.gb_VideoInfo.Controls.Add(this.textDirector);
            this.gb_VideoInfo.Controls.Add(this.textActor);
            this.gb_VideoInfo.Controls.Add(this.textVideoTitle);
            this.gb_VideoInfo.Controls.Add(this.textGenre);
            this.gb_VideoInfo.Controls.Add(this.textVideoCode);
            this.gb_VideoInfo.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_VideoInfo.Location = new System.Drawing.Point(13, 12);
            this.gb_VideoInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_VideoInfo.Name = "gb_VideoInfo";
            this.gb_VideoInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_VideoInfo.Size = new System.Drawing.Size(582, 157);
            this.gb_VideoInfo.TabIndex = 0;
            this.gb_VideoInfo.TabStop = false;
            this.gb_VideoInfo.Text = "비디오 정보";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(325, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "출시일 :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(322, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "감독 :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(335, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "장르 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "제작 및 배급 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "주연 배우 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(74, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "제목 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "비디오 코드 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dtp_ReleaseDate
            // 
            this.Dtp_ReleaseDate.Location = new System.Drawing.Point(393, 125);
            this.Dtp_ReleaseDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dtp_ReleaseDate.Name = "Dtp_ReleaseDate";
            this.Dtp_ReleaseDate.Size = new System.Drawing.Size(141, 24);
            this.Dtp_ReleaseDate.TabIndex = 13;
            // 
            // textProduction
            // 
            this.textProduction.Location = new System.Drawing.Point(130, 125);
            this.textProduction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textProduction.Name = "textProduction";
            this.textProduction.Size = new System.Drawing.Size(140, 24);
            this.textProduction.TabIndex = 11;
            // 
            // textDirector
            // 
            this.textDirector.Location = new System.Drawing.Point(393, 89);
            this.textDirector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDirector.Name = "textDirector";
            this.textDirector.Size = new System.Drawing.Size(140, 24);
            this.textDirector.TabIndex = 9;
            // 
            // textActor
            // 
            this.textActor.Location = new System.Drawing.Point(130, 89);
            this.textActor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textActor.Name = "textActor";
            this.textActor.Size = new System.Drawing.Size(140, 24);
            this.textActor.TabIndex = 7;
            // 
            // textVideoTitle
            // 
            this.textVideoTitle.Location = new System.Drawing.Point(130, 59);
            this.textVideoTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textVideoTitle.Name = "textVideoTitle";
            this.textVideoTitle.Size = new System.Drawing.Size(403, 24);
            this.textVideoTitle.TabIndex = 5;
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(393, 24);
            this.textGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(140, 24);
            this.textGenre.TabIndex = 3;
            // 
            // textVideoCode
            // 
            this.textVideoCode.Location = new System.Drawing.Point(130, 24);
            this.textVideoCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textVideoCode.Name = "textVideoCode";
            this.textVideoCode.Size = new System.Drawing.Size(140, 24);
            this.textVideoCode.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(20, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "전체 비디오 수 :";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(17, 179);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(125, 179);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(232, 179);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(340, 179);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(492, 179);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "나가기";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textTotalVideo
            // 
            this.textTotalVideo.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textTotalVideo.Location = new System.Drawing.Point(142, 226);
            this.textTotalVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTotalVideo.Name = "textTotalVideo";
            this.textTotalVideo.Size = new System.Drawing.Size(93, 24);
            this.textTotalVideo.TabIndex = 7;
            // 
            // videoList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.videoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.videoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Video_Code,
            this.Col_Video_Genre,
            this.Col_Video_Title,
            this.Col_Video_Actor,
            this.Col_Video_Director,
            this.Col_Video_Production,
            this.Col_Video_ReleaseDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.videoList.DefaultCellStyle = dataGridViewCellStyle2;
            this.videoList.Location = new System.Drawing.Point(13, 263);
            this.videoList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.videoList.Name = "videoList";
            this.videoList.RowHeadersWidth = 62;
            this.videoList.RowTemplate.Height = 30;
            this.videoList.Size = new System.Drawing.Size(582, 251);
            this.videoList.TabIndex = 9;
            this.videoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.videoList_CellClick);
            // 
            // Col_Video_Code
            // 
            this.Col_Video_Code.HeaderText = "코드";
            this.Col_Video_Code.MinimumWidth = 8;
            this.Col_Video_Code.Name = "Col_Video_Code";
            this.Col_Video_Code.Width = 150;
            // 
            // Col_Video_Genre
            // 
            this.Col_Video_Genre.HeaderText = "장르";
            this.Col_Video_Genre.MinimumWidth = 8;
            this.Col_Video_Genre.Name = "Col_Video_Genre";
            this.Col_Video_Genre.Width = 150;
            // 
            // Col_Video_Title
            // 
            this.Col_Video_Title.HeaderText = "제목";
            this.Col_Video_Title.MinimumWidth = 8;
            this.Col_Video_Title.Name = "Col_Video_Title";
            this.Col_Video_Title.Width = 150;
            // 
            // Col_Video_Actor
            // 
            this.Col_Video_Actor.HeaderText = "주연 배우";
            this.Col_Video_Actor.MinimumWidth = 8;
            this.Col_Video_Actor.Name = "Col_Video_Actor";
            this.Col_Video_Actor.Width = 150;
            // 
            // Col_Video_Director
            // 
            this.Col_Video_Director.HeaderText = "감독";
            this.Col_Video_Director.MinimumWidth = 8;
            this.Col_Video_Director.Name = "Col_Video_Director";
            this.Col_Video_Director.Width = 150;
            // 
            // Col_Video_Production
            // 
            this.Col_Video_Production.HeaderText = "제작 및 배급";
            this.Col_Video_Production.MinimumWidth = 8;
            this.Col_Video_Production.Name = "Col_Video_Production";
            this.Col_Video_Production.Width = 150;
            // 
            // Col_Video_ReleaseDate
            // 
            this.Col_Video_ReleaseDate.HeaderText = "출시일";
            this.Col_Video_ReleaseDate.MinimumWidth = 8;
            this.Col_Video_ReleaseDate.Name = "Col_Video_ReleaseDate";
            this.Col_Video_ReleaseDate.Width = 150;
            // 
            // formVideoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 531);
            this.Controls.Add(this.videoList);
            this.Controls.Add(this.textTotalVideo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gb_VideoInfo);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formVideoInfo";
            this.Text = "비디오 정보";
            this.Load += new System.EventHandler(this.formVideoInfo_Load);
            this.gb_VideoInfo.ResumeLayout(false);
            this.gb_VideoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_VideoInfo;
        private System.Windows.Forms.TextBox textProduction;
        private System.Windows.Forms.TextBox textDirector;
        private System.Windows.Forms.TextBox textActor;
        private System.Windows.Forms.TextBox textVideoTitle;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.TextBox textVideoCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_ReleaseDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textTotalVideo;
        private System.Windows.Forms.DataGridView videoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Video_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Video_Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Video_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Video_Actor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Video_Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Video_Production;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Video_ReleaseDate;
    }
}