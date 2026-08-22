namespace VideoRental
{
    partial class formVideoRentalManage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbInputCustomer = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textInputCustomerCell = new System.Windows.Forms.TextBox();
            this.textInputCustomerPhone = new System.Windows.Forms.TextBox();
            this.textInputCustomerCode = new System.Windows.Forms.TextBox();
            this.textInputCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSelectCustomer = new System.Windows.Forms.TabPage();
            this.Ls_CustomerChoice = new System.Windows.Forms.ListBox();
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.textCustomerCell = new System.Windows.Forms.TextBox();
            this.textCustomerType = new System.Windows.Forms.TextBox();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.textCustomerAddr = new System.Windows.Forms.TextBox();
            this.textCustomerMail = new System.Windows.Forms.TextBox();
            this.textCustomerPhone = new System.Windows.Forms.TextBox();
            this.textCustomerResidentNum = new System.Windows.Forms.TextBox();
            this.textCustomerCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbRentalVideoInput = new System.Windows.Forms.GroupBox();
            this.btnAttend = new System.Windows.Forms.Button();
            this.Date_RentalDate = new System.Windows.Forms.DateTimePicker();
            this.Lb_LateFee = new System.Windows.Forms.Label();
            this.Lb_RentalFee = new System.Windows.Forms.Label();
            this.textVideoTitle = new System.Windows.Forms.TextBox();
            this.textVideoCode = new System.Windows.Forms.TextBox();
            this.Lb_ReturnDate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_VideoRentalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_VideoCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_VideoTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_RentalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_LateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Lb_TotalRentalCount = new System.Windows.Forms.Label();
            this.Lb_TotalRentalFee = new System.Windows.Forms.Label();
            this.Lb_TotalLateFee = new System.Windows.Forms.Label();
            this.btnVideoReturn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbInputCustomer.SuspendLayout();
            this.tbSelectCustomer.SuspendLayout();
            this.gbCustomerInfo.SuspendLayout();
            this.gbRentalVideoInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbInputCustomer);
            this.tabControl1.Controls.Add(this.tbSelectCustomer);
            this.tabControl1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(17, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(238, 213);
            this.tabControl1.TabIndex = 0;
            // 
            // tbInputCustomer
            // 
            this.tbInputCustomer.Controls.Add(this.btnSearch);
            this.tbInputCustomer.Controls.Add(this.textInputCustomerCell);
            this.tbInputCustomer.Controls.Add(this.textInputCustomerPhone);
            this.tbInputCustomer.Controls.Add(this.textInputCustomerCode);
            this.tbInputCustomer.Controls.Add(this.textInputCustomerName);
            this.tbInputCustomer.Controls.Add(this.label4);
            this.tbInputCustomer.Controls.Add(this.label3);
            this.tbInputCustomer.Controls.Add(this.label2);
            this.tbInputCustomer.Controls.Add(this.label1);
            this.tbInputCustomer.Location = new System.Drawing.Point(4, 25);
            this.tbInputCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tbInputCustomer.Name = "tbInputCustomer";
            this.tbInputCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.tbInputCustomer.Size = new System.Drawing.Size(230, 184);
            this.tbInputCustomer.TabIndex = 0;
            this.tbInputCustomer.Text = "고객 입력";
            this.tbInputCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(67, 153);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 27);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "찾기";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textInputCustomerCell
            // 
            this.textInputCustomerCell.Location = new System.Drawing.Point(92, 120);
            this.textInputCustomerCell.Margin = new System.Windows.Forms.Padding(2);
            this.textInputCustomerCell.Name = "textInputCustomerCell";
            this.textInputCustomerCell.Size = new System.Drawing.Size(124, 24);
            this.textInputCustomerCell.TabIndex = 7;
            // 
            // textInputCustomerPhone
            // 
            this.textInputCustomerPhone.Location = new System.Drawing.Point(92, 84);
            this.textInputCustomerPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textInputCustomerPhone.Name = "textInputCustomerPhone";
            this.textInputCustomerPhone.Size = new System.Drawing.Size(124, 24);
            this.textInputCustomerPhone.TabIndex = 6;
            // 
            // textInputCustomerCode
            // 
            this.textInputCustomerCode.Location = new System.Drawing.Point(92, 48);
            this.textInputCustomerCode.Margin = new System.Windows.Forms.Padding(2);
            this.textInputCustomerCode.Name = "textInputCustomerCode";
            this.textInputCustomerCode.Size = new System.Drawing.Size(124, 24);
            this.textInputCustomerCode.TabIndex = 5;
            // 
            // textInputCustomerName
            // 
            this.textInputCustomerName.Location = new System.Drawing.Point(92, 11);
            this.textInputCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.textInputCustomerName.Name = "textInputCustomerName";
            this.textInputCustomerName.Size = new System.Drawing.Size(124, 24);
            this.textInputCustomerName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "휴대폰 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "전화번호 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "고객코드 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "고객명 :";
            // 
            // tbSelectCustomer
            // 
            this.tbSelectCustomer.Controls.Add(this.Ls_CustomerChoice);
            this.tbSelectCustomer.Location = new System.Drawing.Point(4, 25);
            this.tbSelectCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tbSelectCustomer.Name = "tbSelectCustomer";
            this.tbSelectCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.tbSelectCustomer.Size = new System.Drawing.Size(230, 184);
            this.tbSelectCustomer.TabIndex = 1;
            this.tbSelectCustomer.Text = "고객 선택";
            this.tbSelectCustomer.UseVisualStyleBackColor = true;
            // 
            // Ls_CustomerChoice
            // 
            this.Ls_CustomerChoice.FormattingEnabled = true;
            this.Ls_CustomerChoice.ItemHeight = 15;
            this.Ls_CustomerChoice.Location = new System.Drawing.Point(0, 0);
            this.Ls_CustomerChoice.Name = "Ls_CustomerChoice";
            this.Ls_CustomerChoice.Size = new System.Drawing.Size(230, 184);
            this.Ls_CustomerChoice.TabIndex = 0;
            this.Ls_CustomerChoice.SelectedIndexChanged += new System.EventHandler(this.Ls_CustomerChoice_SelectedIndexChanged);
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.Controls.Add(this.textCustomerCell);
            this.gbCustomerInfo.Controls.Add(this.textCustomerType);
            this.gbCustomerInfo.Controls.Add(this.textCustomerName);
            this.gbCustomerInfo.Controls.Add(this.textCustomerAddr);
            this.gbCustomerInfo.Controls.Add(this.textCustomerMail);
            this.gbCustomerInfo.Controls.Add(this.textCustomerPhone);
            this.gbCustomerInfo.Controls.Add(this.textCustomerResidentNum);
            this.gbCustomerInfo.Controls.Add(this.textCustomerCode);
            this.gbCustomerInfo.Controls.Add(this.label12);
            this.gbCustomerInfo.Controls.Add(this.label11);
            this.gbCustomerInfo.Controls.Add(this.label10);
            this.gbCustomerInfo.Controls.Add(this.label9);
            this.gbCustomerInfo.Controls.Add(this.label8);
            this.gbCustomerInfo.Controls.Add(this.label7);
            this.gbCustomerInfo.Controls.Add(this.label6);
            this.gbCustomerInfo.Controls.Add(this.label5);
            this.gbCustomerInfo.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbCustomerInfo.Location = new System.Drawing.Point(263, 36);
            this.gbCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbCustomerInfo.Size = new System.Drawing.Size(460, 189);
            this.gbCustomerInfo.TabIndex = 1;
            this.gbCustomerInfo.TabStop = false;
            this.gbCustomerInfo.Text = "고객 정보";
            // 
            // textCustomerCell
            // 
            this.textCustomerCell.Location = new System.Drawing.Point(313, 89);
            this.textCustomerCell.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerCell.Name = "textCustomerCell";
            this.textCustomerCell.Size = new System.Drawing.Size(131, 24);
            this.textCustomerCell.TabIndex = 18;
            // 
            // textCustomerType
            // 
            this.textCustomerType.Location = new System.Drawing.Point(313, 59);
            this.textCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerType.Name = "textCustomerType";
            this.textCustomerType.Size = new System.Drawing.Size(131, 24);
            this.textCustomerType.TabIndex = 17;
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(313, 25);
            this.textCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(131, 24);
            this.textCustomerName.TabIndex = 16;
            // 
            // textCustomerAddr
            // 
            this.textCustomerAddr.Location = new System.Drawing.Point(96, 154);
            this.textCustomerAddr.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerAddr.Name = "textCustomerAddr";
            this.textCustomerAddr.Size = new System.Drawing.Size(131, 24);
            this.textCustomerAddr.TabIndex = 15;
            // 
            // textCustomerMail
            // 
            this.textCustomerMail.Location = new System.Drawing.Point(96, 121);
            this.textCustomerMail.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerMail.Name = "textCustomerMail";
            this.textCustomerMail.Size = new System.Drawing.Size(131, 24);
            this.textCustomerMail.TabIndex = 14;
            // 
            // textCustomerPhone
            // 
            this.textCustomerPhone.Location = new System.Drawing.Point(96, 89);
            this.textCustomerPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerPhone.Name = "textCustomerPhone";
            this.textCustomerPhone.Size = new System.Drawing.Size(131, 24);
            this.textCustomerPhone.TabIndex = 13;
            // 
            // textCustomerResidentNum
            // 
            this.textCustomerResidentNum.Location = new System.Drawing.Point(96, 59);
            this.textCustomerResidentNum.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerResidentNum.Name = "textCustomerResidentNum";
            this.textCustomerResidentNum.Size = new System.Drawing.Size(131, 24);
            this.textCustomerResidentNum.TabIndex = 12;
            // 
            // textCustomerCode
            // 
            this.textCustomerCode.Location = new System.Drawing.Point(96, 25);
            this.textCustomerCode.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerCode.Name = "textCustomerCode";
            this.textCustomerCode.Size = new System.Drawing.Size(131, 24);
            this.textCustomerCode.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(246, 93);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "휴대폰 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "고객신분 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "고객명 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "주소 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "우편번호 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "전화번호 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "주민번호 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "고객코드 :";
            // 
            // gbRentalVideoInput
            // 
            this.gbRentalVideoInput.Controls.Add(this.btnAttend);
            this.gbRentalVideoInput.Controls.Add(this.Date_RentalDate);
            this.gbRentalVideoInput.Controls.Add(this.Lb_LateFee);
            this.gbRentalVideoInput.Controls.Add(this.Lb_RentalFee);
            this.gbRentalVideoInput.Controls.Add(this.textVideoTitle);
            this.gbRentalVideoInput.Controls.Add(this.textVideoCode);
            this.gbRentalVideoInput.Controls.Add(this.Lb_ReturnDate);
            this.gbRentalVideoInput.Controls.Add(this.label18);
            this.gbRentalVideoInput.Controls.Add(this.label17);
            this.gbRentalVideoInput.Controls.Add(this.label16);
            this.gbRentalVideoInput.Controls.Add(this.label15);
            this.gbRentalVideoInput.Controls.Add(this.label14);
            this.gbRentalVideoInput.Controls.Add(this.label13);
            this.gbRentalVideoInput.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbRentalVideoInput.Location = new System.Drawing.Point(20, 232);
            this.gbRentalVideoInput.Margin = new System.Windows.Forms.Padding(2);
            this.gbRentalVideoInput.Name = "gbRentalVideoInput";
            this.gbRentalVideoInput.Padding = new System.Windows.Forms.Padding(2);
            this.gbRentalVideoInput.Size = new System.Drawing.Size(704, 79);
            this.gbRentalVideoInput.TabIndex = 2;
            this.gbRentalVideoInput.TabStop = false;
            this.gbRentalVideoInput.Text = "대여 비디오 입력";
            // 
            // btnAttend
            // 
            this.btnAttend.Location = new System.Drawing.Point(605, 18);
            this.btnAttend.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.Size = new System.Drawing.Size(82, 24);
            this.btnAttend.TabIndex = 10;
            this.btnAttend.Text = "등록";
            this.btnAttend.UseVisualStyleBackColor = true;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // Date_RentalDate
            // 
            this.Date_RentalDate.Location = new System.Drawing.Point(332, 50);
            this.Date_RentalDate.Margin = new System.Windows.Forms.Padding(2);
            this.Date_RentalDate.Name = "Date_RentalDate";
            this.Date_RentalDate.Size = new System.Drawing.Size(165, 24);
            this.Date_RentalDate.TabIndex = 23;
            // 
            // Lb_LateFee
            // 
            this.Lb_LateFee.AutoSize = true;
            this.Lb_LateFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_LateFee.Location = new System.Drawing.Point(200, 53);
            this.Lb_LateFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_LateFee.Name = "Lb_LateFee";
            this.Lb_LateFee.Size = new System.Drawing.Size(64, 17);
            this.Lb_LateFee.TabIndex = 22;
            this.Lb_LateFee.Text = "00000원";
            // 
            // Lb_RentalFee
            // 
            this.Lb_RentalFee.AutoSize = true;
            this.Lb_RentalFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_RentalFee.Location = new System.Drawing.Point(76, 53);
            this.Lb_RentalFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_RentalFee.Name = "Lb_RentalFee";
            this.Lb_RentalFee.Size = new System.Drawing.Size(56, 17);
            this.Lb_RentalFee.TabIndex = 21;
            this.Lb_RentalFee.Text = "0000원";
            // 
            // textVideoTitle
            // 
            this.textVideoTitle.Location = new System.Drawing.Point(335, 19);
            this.textVideoTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textVideoTitle.Name = "textVideoTitle";
            this.textVideoTitle.Size = new System.Drawing.Size(262, 24);
            this.textVideoTitle.TabIndex = 20;
            // 
            // textVideoCode
            // 
            this.textVideoCode.Location = new System.Drawing.Point(113, 19);
            this.textVideoCode.Margin = new System.Windows.Forms.Padding(2);
            this.textVideoCode.Name = "textVideoCode";
            this.textVideoCode.Size = new System.Drawing.Size(116, 24);
            this.textVideoCode.TabIndex = 19;
            this.textVideoCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textVideoCode_KeyPress);
            // 
            // Lb_ReturnDate
            // 
            this.Lb_ReturnDate.AutoSize = true;
            this.Lb_ReturnDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_ReturnDate.Location = new System.Drawing.Point(602, 53);
            this.Lb_ReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_ReturnDate.Name = "Lb_ReturnDate";
            this.Lb_ReturnDate.Size = new System.Drawing.Size(89, 17);
            this.Lb_ReturnDate.TabIndex = 18;
            this.Lb_ReturnDate.Text = "2000-01-01";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(500, 53);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 15);
            this.label18.TabIndex = 17;
            this.label18.Text = "반납 예정일 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(265, 53);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "대여일 :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(134, 53);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 15);
            this.label16.TabIndex = 15;
            this.label16.Text = "연체료 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 53);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "대여료 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(232, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "비디오 제목 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "비디오 코드 :";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_VideoRentalCode,
            this.Col_VideoCode,
            this.Col_VideoTitle,
            this.Col_RentalFee,
            this.Col_LateFee});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(20, 353);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(704, 163);
            this.dataGridView1.TabIndex = 3;
            // 
            // Col_VideoRentalCode
            // 
            this.Col_VideoRentalCode.HeaderText = "비디오 대여 번호";
            this.Col_VideoRentalCode.Name = "Col_VideoRentalCode";
            // 
            // Col_VideoCode
            // 
            this.Col_VideoCode.HeaderText = "비디오 코드";
            this.Col_VideoCode.MinimumWidth = 8;
            this.Col_VideoCode.Name = "Col_VideoCode";
            this.Col_VideoCode.Width = 150;
            // 
            // Col_VideoTitle
            // 
            this.Col_VideoTitle.HeaderText = "비디오 제목";
            this.Col_VideoTitle.MinimumWidth = 8;
            this.Col_VideoTitle.Name = "Col_VideoTitle";
            this.Col_VideoTitle.Width = 150;
            // 
            // Col_RentalFee
            // 
            this.Col_RentalFee.HeaderText = "대여료";
            this.Col_RentalFee.MinimumWidth = 8;
            this.Col_RentalFee.Name = "Col_RentalFee";
            this.Col_RentalFee.Width = 150;
            // 
            // Col_LateFee
            // 
            this.Col_LateFee.HeaderText = "연체료";
            this.Col_LateFee.MinimumWidth = 8;
            this.Col_LateFee.Name = "Col_LateFee";
            this.Col_LateFee.Width = 150;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(26, 322);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 15);
            this.label20.TabIndex = 19;
            this.label20.Text = "총 대여 개수 :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(175, 322);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 15);
            this.label21.TabIndex = 20;
            this.label21.Text = "총 대여료 :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(327, 322);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 15);
            this.label22.TabIndex = 21;
            this.label22.Text = "총 연체료 :";
            // 
            // Lb_TotalRentalCount
            // 
            this.Lb_TotalRentalCount.AutoSize = true;
            this.Lb_TotalRentalCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_TotalRentalCount.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lb_TotalRentalCount.Location = new System.Drawing.Point(133, 322);
            this.Lb_TotalRentalCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_TotalRentalCount.Name = "Lb_TotalRentalCount";
            this.Lb_TotalRentalCount.Size = new System.Drawing.Size(40, 17);
            this.Lb_TotalRentalCount.TabIndex = 22;
            this.Lb_TotalRentalCount.Text = "00개";
            // 
            // Lb_TotalRentalFee
            // 
            this.Lb_TotalRentalFee.AutoSize = true;
            this.Lb_TotalRentalFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_TotalRentalFee.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lb_TotalRentalFee.Location = new System.Drawing.Point(262, 322);
            this.Lb_TotalRentalFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_TotalRentalFee.Name = "Lb_TotalRentalFee";
            this.Lb_TotalRentalFee.Size = new System.Drawing.Size(64, 17);
            this.Lb_TotalRentalFee.TabIndex = 23;
            this.Lb_TotalRentalFee.Text = "00000원";
            // 
            // Lb_TotalLateFee
            // 
            this.Lb_TotalLateFee.AutoSize = true;
            this.Lb_TotalLateFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_TotalLateFee.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lb_TotalLateFee.Location = new System.Drawing.Point(414, 322);
            this.Lb_TotalLateFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_TotalLateFee.Name = "Lb_TotalLateFee";
            this.Lb_TotalLateFee.Size = new System.Drawing.Size(64, 17);
            this.Lb_TotalLateFee.TabIndex = 24;
            this.Lb_TotalLateFee.Text = "00000원";
            // 
            // btnVideoReturn
            // 
            this.btnVideoReturn.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnVideoReturn.Location = new System.Drawing.Point(611, 318);
            this.btnVideoReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideoReturn.Name = "btnVideoReturn";
            this.btnVideoReturn.Size = new System.Drawing.Size(112, 25);
            this.btnVideoReturn.TabIndex = 25;
            this.btnVideoReturn.Text = "비디오 회수";
            this.btnVideoReturn.UseVisualStyleBackColor = true;
            this.btnVideoReturn.Click += new System.EventHandler(this.btnVideoReturn_Click);
            // 
            // formVideoRentalManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 545);
            this.Controls.Add(this.btnVideoReturn);
            this.Controls.Add(this.Lb_TotalLateFee);
            this.Controls.Add(this.Lb_TotalRentalFee);
            this.Controls.Add(this.Lb_TotalRentalCount);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbRentalVideoInput);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formVideoRentalManage";
            this.Text = "대여 관리";
            this.tabControl1.ResumeLayout(false);
            this.tbInputCustomer.ResumeLayout(false);
            this.tbInputCustomer.PerformLayout();
            this.tbSelectCustomer.ResumeLayout(false);
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            this.gbRentalVideoInput.ResumeLayout(false);
            this.gbRentalVideoInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbInputCustomer;
        private System.Windows.Forms.TabPage tbSelectCustomer;
        private System.Windows.Forms.TextBox textInputCustomerCell;
        private System.Windows.Forms.TextBox textInputCustomerPhone;
        private System.Windows.Forms.TextBox textInputCustomerCode;
        private System.Windows.Forms.TextBox textInputCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.TextBox textCustomerCell;
        private System.Windows.Forms.TextBox textCustomerType;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.TextBox textCustomerAddr;
        private System.Windows.Forms.TextBox textCustomerMail;
        private System.Windows.Forms.TextBox textCustomerPhone;
        private System.Windows.Forms.TextBox textCustomerResidentNum;
        private System.Windows.Forms.TextBox textCustomerCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbRentalVideoInput;
        private System.Windows.Forms.Label Lb_LateFee;
        private System.Windows.Forms.Label Lb_RentalFee;
        private System.Windows.Forms.TextBox textVideoTitle;
        private System.Windows.Forms.TextBox textVideoCode;
        private System.Windows.Forms.Label Lb_ReturnDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAttend;
        private System.Windows.Forms.DateTimePicker Date_RentalDate;
        private System.Windows.Forms.Label Lb_TotalRentalCount;
        private System.Windows.Forms.Label Lb_TotalRentalFee;
        private System.Windows.Forms.Label Lb_TotalLateFee;
        private System.Windows.Forms.Button btnVideoReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_VideoRentalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_VideoCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_VideoTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_RentalFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_LateFee;
        private System.Windows.Forms.ListBox Ls_CustomerChoice;
    }
}