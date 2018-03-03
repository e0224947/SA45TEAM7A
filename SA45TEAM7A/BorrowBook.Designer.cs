namespace SA45TEAM7A
{
    partial class BorrowBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBook));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcome2 = new System.Windows.Forms.Label();
            this.txtBorrowBookID = new System.Windows.Forms.TextBox();
            this.dGVBorrow = new System.Windows.Forms.DataGridView();
            this.dGVcolumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVcolumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVcolumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBorrowError = new System.Windows.Forms.Label();
            this.btnEndPrint = new System.Windows.Forms.Button();
            this.btnEndDontPrint = new System.Windows.Forms.Button();
            this.btnCancelTrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(859, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, MemberTitle MemberName, to Library 7A.";
            // 
            // lblWelcome2
            // 
            this.lblWelcome2.AutoSize = true;
            this.lblWelcome2.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome2.Location = new System.Drawing.Point(12, 74);
            this.lblWelcome2.Name = "lblWelcome2";
            this.lblWelcome2.Size = new System.Drawing.Size(519, 40);
            this.lblWelcome2.TabIndex = 1;
            this.lblWelcome2.Text = "Please scan one item at a time.";
            // 
            // txtBorrowBookID
            // 
            this.txtBorrowBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBorrowBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowBookID.Location = new System.Drawing.Point(418, 166);
            this.txtBorrowBookID.Name = "txtBorrowBookID";
            this.txtBorrowBookID.Size = new System.Drawing.Size(206, 48);
            this.txtBorrowBookID.TabIndex = 2;
            this.txtBorrowBookID.TextChanged += new System.EventHandler(this.txtBorrowBookID_TextChanged);
            // 
            // dGVBorrow
            // 
            this.dGVBorrow.AllowUserToAddRows = false;
            this.dGVBorrow.AllowUserToDeleteRows = false;
            this.dGVBorrow.AllowUserToResizeColumns = false;
            this.dGVBorrow.AllowUserToResizeRows = false;
            this.dGVBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVBorrow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGVBorrow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVBorrow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dGVcolumn1,
            this.dGVcolumn2,
            this.dGVcolumn3});
            this.dGVBorrow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGVBorrow.Location = new System.Drawing.Point(0, 229);
            this.dGVBorrow.Name = "dGVBorrow";
            this.dGVBorrow.RowHeadersVisible = false;
            this.dGVBorrow.RowTemplate.Height = 28;
            this.dGVBorrow.Size = new System.Drawing.Size(1023, 478);
            this.dGVBorrow.TabIndex = 3;
            // 
            // dGVcolumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGVcolumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVcolumn1.HeaderText = "No.";
            this.dGVcolumn1.Name = "dGVcolumn1";
            this.dGVcolumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVcolumn1.Width = 50;
            // 
            // dGVcolumn2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVcolumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVcolumn2.HeaderText = "Title";
            this.dGVcolumn2.Name = "dGVcolumn2";
            this.dGVcolumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVcolumn2.Width = 515;
            // 
            // dGVcolumn3
            // 
            this.dGVcolumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight;
            this.dGVcolumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVcolumn3.HeaderText = "Date Due";
            this.dGVcolumn3.Name = "dGVcolumn3";
            this.dGVcolumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtBorrowError
            // 
            this.txtBorrowError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBorrowError.AutoSize = true;
            this.txtBorrowError.BackColor = System.Drawing.Color.Transparent;
            this.txtBorrowError.ForeColor = System.Drawing.Color.Red;
            this.txtBorrowError.Location = new System.Drawing.Point(414, 132);
            this.txtBorrowError.Name = "txtBorrowError";
            this.txtBorrowError.Size = new System.Drawing.Size(0, 20);
            this.txtBorrowError.TabIndex = 4;
            // 
            // btnEndPrint
            // 
            this.btnEndPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEndPrint.Enabled = false;
            this.btnEndPrint.Location = new System.Drawing.Point(149, 715);
            this.btnEndPrint.Name = "btnEndPrint";
            this.btnEndPrint.Size = new System.Drawing.Size(244, 64);
            this.btnEndPrint.TabIndex = 5;
            this.btnEndPrint.Text = "End Transaction \r\nPrint Receipt";
            this.btnEndPrint.UseVisualStyleBackColor = true;
            this.btnEndPrint.Click += new System.EventHandler(this.btnEndPrint_Click);
            // 
            // btnEndDontPrint
            // 
            this.btnEndDontPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEndDontPrint.Enabled = false;
            this.btnEndDontPrint.Location = new System.Drawing.Point(399, 715);
            this.btnEndDontPrint.Name = "btnEndDontPrint";
            this.btnEndDontPrint.Size = new System.Drawing.Size(244, 64);
            this.btnEndDontPrint.TabIndex = 6;
            this.btnEndDontPrint.Text = "End Transaction\r\nDO NOT print receipt\r\n";
            this.btnEndDontPrint.UseVisualStyleBackColor = true;
            this.btnEndDontPrint.Click += new System.EventHandler(this.btnEndDontPrint_Click);
            // 
            // btnCancelTrans
            // 
            this.btnCancelTrans.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelTrans.Location = new System.Drawing.Point(649, 715);
            this.btnCancelTrans.Name = "btnCancelTrans";
            this.btnCancelTrans.Size = new System.Drawing.Size(244, 64);
            this.btnCancelTrans.TabIndex = 7;
            this.btnCancelTrans.Text = "Cancel Transaction";
            this.btnCancelTrans.UseVisualStyleBackColor = true;
            this.btnCancelTrans.Click += new System.EventHandler(this.btnCancelTrans_Click);
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnCancelTrans);
            this.Controls.Add(this.btnEndDontPrint);
            this.Controls.Add(this.btnEndPrint);
            this.Controls.Add(this.txtBorrowError);
            this.Controls.Add(this.dGVBorrow);
            this.Controls.Add(this.txtBorrowBookID);
            this.Controls.Add(this.lblWelcome2);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowBook";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcome2;
        private System.Windows.Forms.TextBox txtBorrowBookID;
        private System.Windows.Forms.DataGridView dGVBorrow;
        private System.Windows.Forms.Label txtBorrowError;
        private System.Windows.Forms.Button btnEndPrint;
        private System.Windows.Forms.Button btnEndDontPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVcolumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVcolumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVcolumn3;
        private System.Windows.Forms.Button btnCancelTrans;
    }
}

