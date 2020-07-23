namespace ReadWriteIO
{
    partial class FrmReadWriteIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReadWriteIO));
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.LbxRows = new System.Windows.Forms.ListBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.TxtMI = new System.Windows.Forms.TextBox();
            this.LblMI = new System.Windows.Forms.Label();
            this.LblFilePath = new System.Windows.Forms.Label();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnReadRecord = new System.Windows.Forms.Button();
            this.TxtRecordNumber = new System.Windows.Forms.TextBox();
            this.LblRecordNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(55, 108);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(133, 61);
            this.BtnRead.TabIndex = 0;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(367, 108);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(133, 61);
            this.BtnWrite.TabIndex = 1;
            this.BtnWrite.Text = "Write";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // LbxRows
            // 
            this.LbxRows.FormattingEnabled = true;
            this.LbxRows.ItemHeight = 24;
            this.LbxRows.Location = new System.Drawing.Point(55, 193);
            this.LbxRows.Name = "LbxRows";
            this.LbxRows.Size = new System.Drawing.Size(445, 196);
            this.LbxRows.TabIndex = 2;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(23, 22);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(101, 24);
            this.LblFirstName.TabIndex = 3;
            this.LblFirstName.Text = "First Name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(23, 53);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(139, 29);
            this.TxtFirstName.TabIndex = 4;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(183, 53);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(187, 29);
            this.TxtLastName.TabIndex = 6;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(183, 22);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(99, 24);
            this.LblLastName.TabIndex = 5;
            this.LblLastName.Text = "Last Name";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(474, 53);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(56, 29);
            this.TxtAge.TabIndex = 10;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(474, 22);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(45, 24);
            this.LblAge.TabIndex = 7;
            this.LblAge.Text = "Age";
            // 
            // TxtMI
            // 
            this.TxtMI.Location = new System.Drawing.Point(396, 53);
            this.TxtMI.Name = "TxtMI";
            this.TxtMI.Size = new System.Drawing.Size(51, 29);
            this.TxtMI.TabIndex = 8;
            // 
            // LblMI
            // 
            this.LblMI.AutoSize = true;
            this.LblMI.Location = new System.Drawing.Point(396, 22);
            this.LblMI.Name = "LblMI";
            this.LblMI.Size = new System.Drawing.Size(40, 24);
            this.LblMI.TabIndex = 9;
            this.LblMI.Text = "M.I.";
            // 
            // LblFilePath
            // 
            this.LblFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilePath.Location = new System.Drawing.Point(23, 416);
            this.LblFilePath.Name = "LblFilePath";
            this.LblFilePath.Size = new System.Drawing.Size(507, 27);
            this.LblFilePath.TabIndex = 11;
            this.LblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(211, 108);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(133, 61);
            this.BtnSelectFile.TabIndex = 12;
            this.BtnSelectFile.Text = "Select File";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(397, 463);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(133, 37);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Exit Program";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnReadRecord
            // 
            this.BtnReadRecord.Location = new System.Drawing.Point(249, 463);
            this.BtnReadRecord.Name = "BtnReadRecord";
            this.BtnReadRecord.Size = new System.Drawing.Size(133, 37);
            this.BtnReadRecord.TabIndex = 15;
            this.BtnReadRecord.Text = "Read Record";
            this.BtnReadRecord.UseVisualStyleBackColor = true;
            this.BtnReadRecord.Click += new System.EventHandler(this.BtnReadRecord_Click);
            // 
            // TxtRecordNumber
            // 
            this.TxtRecordNumber.Location = new System.Drawing.Point(168, 467);
            this.TxtRecordNumber.Name = "TxtRecordNumber";
            this.TxtRecordNumber.Size = new System.Drawing.Size(50, 29);
            this.TxtRecordNumber.TabIndex = 16;
            this.TxtRecordNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRecordNumber.DoubleClick += new System.EventHandler(this.TxtRecordNumber_DoubleClick);
            // 
            // LblRecordNumber
            // 
            this.LblRecordNumber.AutoSize = true;
            this.LblRecordNumber.Location = new System.Drawing.Point(19, 469);
            this.LblRecordNumber.Name = "LblRecordNumber";
            this.LblRecordNumber.Size = new System.Drawing.Size(146, 24);
            this.LblRecordNumber.TabIndex = 17;
            this.LblRecordNumber.Text = "Record Number";
            // 
            // FrmReadWriteIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 583);
            this.Controls.Add(this.LblRecordNumber);
            this.Controls.Add(this.TxtRecordNumber);
            this.Controls.Add(this.BtnReadRecord);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.LblFilePath);
            this.Controls.Add(this.TxtMI);
            this.Controls.Add(this.LblMI);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LbxRows);
            this.Controls.Add(this.BtnWrite);
            this.Controls.Add(this.BtnRead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmReadWriteIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read / Write IO";
            this.Load += new System.EventHandler(this.FrmReadWriteIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.ListBox LbxRows;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.TextBox TxtMI;
        private System.Windows.Forms.Label LblMI;
        private System.Windows.Forms.Label LblFilePath;
        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnReadRecord;
        private System.Windows.Forms.TextBox TxtRecordNumber;
        private System.Windows.Forms.Label LblRecordNumber;
    }
}

