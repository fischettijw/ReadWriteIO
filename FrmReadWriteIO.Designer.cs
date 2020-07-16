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
            this.SuspendLayout();
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(55, 125);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(185, 61);
            this.BtnRead.TabIndex = 0;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(315, 125);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(185, 61);
            this.BtnWrite.TabIndex = 1;
            this.BtnWrite.Text = "Write";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // LbxRows
            // 
            this.LbxRows.FormattingEnabled = true;
            this.LbxRows.ItemHeight = 24;
            this.LbxRows.Location = new System.Drawing.Point(55, 210);
            this.LbxRows.Name = "LbxRows";
            this.LbxRows.Size = new System.Drawing.Size(445, 196);
            this.LbxRows.TabIndex = 2;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(23, 39);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(101, 24);
            this.LblFirstName.TabIndex = 3;
            this.LblFirstName.Text = "First Name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(23, 70);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(139, 29);
            this.TxtFirstName.TabIndex = 4;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(183, 70);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(187, 29);
            this.TxtLastName.TabIndex = 6;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(183, 39);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(99, 24);
            this.LblLastName.TabIndex = 5;
            this.LblLastName.Text = "Last Name";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(474, 70);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(56, 29);
            this.TxtAge.TabIndex = 10;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(474, 39);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(45, 24);
            this.LblAge.TabIndex = 7;
            this.LblAge.Text = "Age";
            // 
            // TxtMI
            // 
            this.TxtMI.Location = new System.Drawing.Point(396, 70);
            this.TxtMI.Name = "TxtMI";
            this.TxtMI.Size = new System.Drawing.Size(51, 29);
            this.TxtMI.TabIndex = 8;
            // 
            // LblMI
            // 
            this.LblMI.AutoSize = true;
            this.LblMI.Location = new System.Drawing.Point(396, 39);
            this.LblMI.Name = "LblMI";
            this.LblMI.Size = new System.Drawing.Size(40, 24);
            this.LblMI.TabIndex = 9;
            this.LblMI.Text = "M.I.";
            // 
            // FrmReadWriteIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 438);
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
    }
}

