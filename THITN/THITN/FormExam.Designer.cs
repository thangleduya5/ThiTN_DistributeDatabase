
namespace THITN
{
    partial class FormExam
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTHOIGIAN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbCAUHOI = new System.Windows.Forms.Label();
            this.btnSAU = new System.Windows.Forms.Button();
            this.btnNOPBAI = new System.Windows.Forms.Button();
            this.btnTRUOC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.lbB = new System.Windows.Forms.TextBox();
            this.lbD = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.TextBox();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.lbNOIDUNG = new System.Windows.Forms.TextBox();
            this.DSExam = new THITN.DSExam();
            this.BDSTranscript = new System.Windows.Forms.BindingSource(this.components);
            this.TATranscript = new THITN.DSExamTableAdapters.BANGDIEMTableAdapter();
            this.tableAdapterManager = new THITN.DSExamTableAdapters.TableAdapterManager();
            this.TAExamDetail = new THITN.DSExamTableAdapters.CTBAITHITableAdapter();
            this.BDSExamDetail = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTranscript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSExamDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTHOIGIAN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 45);
            this.panel2.TabIndex = 2;
            // 
            // lbTHOIGIAN
            // 
            this.lbTHOIGIAN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTHOIGIAN.AutoSize = true;
            this.lbTHOIGIAN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTHOIGIAN.Location = new System.Drawing.Point(496, 9);
            this.lbTHOIGIAN.Name = "lbTHOIGIAN";
            this.lbTHOIGIAN.Size = new System.Drawing.Size(56, 26);
            this.lbTHOIGIAN.TabIndex = 7;
            this.lbTHOIGIAN.Text = "1:30";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbInfo);
            this.panel1.Controls.Add(this.lbCAUHOI);
            this.panel1.Controls.Add(this.btnSAU);
            this.panel1.Controls.Add(this.btnNOPBAI);
            this.panel1.Controls.Add(this.btnTRUOC);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbNOIDUNG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 585);
            this.panel1.TabIndex = 3;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(12, 553);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(60, 23);
            this.lbInfo.TabIndex = 6;
            this.lbInfo.Text = "label1";
            // 
            // lbCAUHOI
            // 
            this.lbCAUHOI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCAUHOI.AutoSize = true;
            this.lbCAUHOI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCAUHOI.Location = new System.Drawing.Point(478, 15);
            this.lbCAUHOI.Name = "lbCAUHOI";
            this.lbCAUHOI.Size = new System.Drawing.Size(74, 23);
            this.lbCAUHOI.TabIndex = 5;
            this.lbCAUHOI.Text = "Câu hỏi";
            // 
            // btnSAU
            // 
            this.btnSAU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSAU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAU.Location = new System.Drawing.Point(618, 470);
            this.btnSAU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSAU.Name = "btnSAU";
            this.btnSAU.Size = new System.Drawing.Size(153, 81);
            this.btnSAU.TabIndex = 4;
            this.btnSAU.Text = "Câu tiếp";
            this.btnSAU.UseVisualStyleBackColor = true;
            this.btnSAU.Click += new System.EventHandler(this.btnSAU_Click);
            // 
            // btnNOPBAI
            // 
            this.btnNOPBAI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNOPBAI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOPBAI.Location = new System.Drawing.Point(452, 470);
            this.btnNOPBAI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNOPBAI.Name = "btnNOPBAI";
            this.btnNOPBAI.Size = new System.Drawing.Size(153, 81);
            this.btnNOPBAI.TabIndex = 3;
            this.btnNOPBAI.Text = "Nộp bài";
            this.btnNOPBAI.UseVisualStyleBackColor = true;
            this.btnNOPBAI.Click += new System.EventHandler(this.btnNOPBAI_Click);
            // 
            // btnTRUOC
            // 
            this.btnTRUOC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTRUOC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTRUOC.Location = new System.Drawing.Point(286, 470);
            this.btnTRUOC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTRUOC.Name = "btnTRUOC";
            this.btnTRUOC.Size = new System.Drawing.Size(153, 81);
            this.btnTRUOC.TabIndex = 2;
            this.btnTRUOC.Text = "Câu trước";
            this.btnTRUOC.UseVisualStyleBackColor = true;
            this.btnTRUOC.Click += new System.EventHandler(this.btnTRUOC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(51, 193);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(906, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.619385F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.75177F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.955083F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.191489F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.855792F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.39716F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Controls.Add(this.rbC, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.rbD, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.rbA, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbB, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbD, 6, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbC, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbA, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.rbB, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.790419F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.92814F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.790419F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.93413F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17964F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(900, 213);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rbC
            // 
            this.rbC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbC.AutoSize = true;
            this.rbC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbC.Location = new System.Drawing.Point(61, 123);
            this.rbC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(45, 62);
            this.rbC.TabIndex = 5;
            this.rbC.TabStop = true;
            this.rbC.Tag = "C";
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.Click += new System.EventHandler(this.rbAnswer_Click);
            // 
            // rbD
            // 
            this.rbD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbD.AutoSize = true;
            this.rbD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbD.Location = new System.Drawing.Point(489, 123);
            this.rbD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(45, 62);
            this.rbD.TabIndex = 6;
            this.rbD.TabStop = true;
            this.rbD.Tag = "D";
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.Click += new System.EventHandler(this.rbAnswer_Click);
            // 
            // rbA
            // 
            this.rbA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbA.AutoSize = true;
            this.rbA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbA.Location = new System.Drawing.Point(61, 14);
            this.rbA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(45, 68);
            this.rbA.TabIndex = 4;
            this.rbA.TabStop = true;
            this.rbA.Tag = "A";
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.Click += new System.EventHandler(this.rbAnswer_Click);
            // 
            // lbB
            // 
            this.lbB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(540, 14);
            this.lbB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbB.Multiline = true;
            this.lbB.Name = "lbB";
            this.lbB.ReadOnly = true;
            this.lbB.Size = new System.Drawing.Size(303, 68);
            this.lbB.TabIndex = 1;
            // 
            // lbD
            // 
            this.lbD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbD.Location = new System.Drawing.Point(540, 123);
            this.lbD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbD.Multiline = true;
            this.lbD.Name = "lbD";
            this.lbD.ReadOnly = true;
            this.lbD.Size = new System.Drawing.Size(303, 62);
            this.lbD.TabIndex = 3;
            // 
            // lbC
            // 
            this.lbC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.Location = new System.Drawing.Point(112, 123);
            this.lbC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbC.Multiline = true;
            this.lbC.Name = "lbC";
            this.lbC.ReadOnly = true;
            this.lbC.Size = new System.Drawing.Size(307, 62);
            this.lbC.TabIndex = 2;
            // 
            // lbA
            // 
            this.lbA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(112, 14);
            this.lbA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbA.Multiline = true;
            this.lbA.Name = "lbA";
            this.lbA.ReadOnly = true;
            this.lbA.Size = new System.Drawing.Size(307, 68);
            this.lbA.TabIndex = 0;
            // 
            // rbB
            // 
            this.rbB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbB.AutoSize = true;
            this.rbB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbB.Location = new System.Drawing.Point(490, 14);
            this.rbB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(44, 68);
            this.rbB.TabIndex = 5;
            this.rbB.TabStop = true;
            this.rbB.Tag = "B";
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.Click += new System.EventHandler(this.rbAnswer_Click);
            // 
            // lbNOIDUNG
            // 
            this.lbNOIDUNG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNOIDUNG.Enabled = false;
            this.lbNOIDUNG.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNOIDUNG.Location = new System.Drawing.Point(138, 58);
            this.lbNOIDUNG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbNOIDUNG.Multiline = true;
            this.lbNOIDUNG.Name = "lbNOIDUNG";
            this.lbNOIDUNG.ReadOnly = true;
            this.lbNOIDUNG.Size = new System.Drawing.Size(743, 112);
            this.lbNOIDUNG.TabIndex = 0;
            // 
            // DSExam
            // 
            this.DSExam.DataSetName = "DSExam";
            this.DSExam.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BDSTranscript
            // 
            this.BDSTranscript.DataMember = "BANGDIEM";
            this.BDSTranscript.DataSource = this.DSExam;
            // 
            // TATranscript
            // 
            this.TATranscript.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.TATranscript;
            this.tableAdapterManager.CTBAITHITableAdapter = this.TAExamDetail;
            this.tableAdapterManager.UpdateOrder = THITN.DSExamTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TAExamDetail
            // 
            this.TAExamDetail.ClearBeforeFill = true;
            // 
            // BDSExamDetail
            // 
            this.BDSExamDetail.DataMember = "FK_CTBAITHI_BANGDIEM";
            this.BDSExamDetail.DataSource = this.BDSTranscript;
            // 
            // FormExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormExam";
            this.Text = "FormExam";
            this.Load += new System.EventHandler(this.FormExam_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTranscript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSExamDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTHOIGIAN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCAUHOI;
        private System.Windows.Forms.Button btnSAU;
        private System.Windows.Forms.Button btnNOPBAI;
        private System.Windows.Forms.Button btnTRUOC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.TextBox lbB;
        private System.Windows.Forms.TextBox lbD;
        private System.Windows.Forms.TextBox lbC;
        private System.Windows.Forms.TextBox lbA;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbA;
        private DSExam DSExam;
        private System.Windows.Forms.BindingSource BDSTranscript;
        private DSExamTableAdapters.BANGDIEMTableAdapter TATranscript;
        private DSExamTableAdapters.TableAdapterManager tableAdapterManager;
        private DSExamTableAdapters.CTBAITHITableAdapter TAExamDetail;
        private System.Windows.Forms.BindingSource BDSExamDetail;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox lbNOIDUNG;
        private System.Windows.Forms.RadioButton rbB;
    }
}