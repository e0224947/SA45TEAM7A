namespace SA45TEAM7A
{
    partial class LibBorrowBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVBorrow = new System.Windows.Forms.DataGridView();
            this.dGVcolumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVcolumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVcolumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberType = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtBorrowBookID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBorrowError = new System.Windows.Forms.Label();
            this.btnlibEndPrint = new System.Windows.Forms.Button();
            this.btnlibEndDontPrint = new System.Windows.Forms.Button();
            this.btnCancelTrans = new System.Windows.Forms.Button();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblMemberIDError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Member Type";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dGVcolumn1,
            this.dGVcolumn2,
            this.dGVcolumn3,
            this.deleteColumn});
            this.dGVBorrow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGVBorrow.Location = new System.Drawing.Point(92, 276);
            this.dGVBorrow.Name = "dGVBorrow";
            this.dGVBorrow.RowHeadersVisible = false;
            this.dGVBorrow.RowTemplate.Height = 28;
            this.dGVBorrow.Size = new System.Drawing.Size(716, 324);
            this.dGVBorrow.TabIndex = 4;
            this.dGVBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBorrow_CellContentClick);
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
            this.dGVcolumn2.Width = 220;
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
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Text = "Delete";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(226, 38);
            this.txtMemberID.MaxLength = 4;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 26);
            this.txtMemberID.TabIndex = 0;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // txtMemberType
            // 
            this.txtMemberType.BackColor = System.Drawing.SystemColors.Control;
            this.txtMemberType.Enabled = false;
            this.txtMemberType.Location = new System.Drawing.Point(710, 42);
            this.txtMemberType.Name = "txtMemberType";
            this.txtMemberType.Size = new System.Drawing.Size(100, 26);
            this.txtMemberType.TabIndex = 6;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(226, 90);
            this.txtPassWord.MaxLength = 30;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(100, 26);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // txtBorrowBookID
            // 
            this.txtBorrowBookID.BackColor = System.Drawing.SystemColors.Control;
            this.txtBorrowBookID.Enabled = false;
            this.txtBorrowBookID.Location = new System.Drawing.Point(226, 219);
            this.txtBorrowBookID.MaxLength = 10;
            this.txtBorrowBookID.Name = "txtBorrowBookID";
            this.txtBorrowBookID.ReadOnly = true;
            this.txtBorrowBookID.Size = new System.Drawing.Size(100, 26);
            this.txtBorrowBookID.TabIndex = 3;
            this.txtBorrowBookID.TextChanged += new System.EventHandler(this.txtBorrowBookID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Book ID";
            // 
            // txtBorrowError
            // 
            this.txtBorrowError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBorrowError.AutoSize = true;
            this.txtBorrowError.ForeColor = System.Drawing.Color.Red;
            this.txtBorrowError.Location = new System.Drawing.Point(231, 253);
            this.txtBorrowError.Name = "txtBorrowError";
            this.txtBorrowError.Size = new System.Drawing.Size(0, 20);
            this.txtBorrowError.TabIndex = 10;
            // 
            // btnlibEndPrint
            // 
            this.btnlibEndPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlibEndPrint.Enabled = false;
            this.btnlibEndPrint.Location = new System.Drawing.Point(92, 627);
            this.btnlibEndPrint.Name = "btnlibEndPrint";
            this.btnlibEndPrint.Size = new System.Drawing.Size(203, 64);
            this.btnlibEndPrint.TabIndex = 11;
            this.btnlibEndPrint.Text = "End Transaction \r\nPrint Receipt";
            this.btnlibEndPrint.UseVisualStyleBackColor = true;
            this.btnlibEndPrint.Click += new System.EventHandler(this.btnlibEndPrint_Click);
            // 
            // btnlibEndDontPrint
            // 
            this.btnlibEndDontPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlibEndDontPrint.Enabled = false;
            this.btnlibEndDontPrint.Location = new System.Drawing.Point(348, 630);
            this.btnlibEndDontPrint.Name = "btnlibEndDontPrint";
            this.btnlibEndDontPrint.Size = new System.Drawing.Size(203, 64);
            this.btnlibEndDontPrint.TabIndex = 12;
            this.btnlibEndDontPrint.Text = "End Transaction\r\nDO NOT print receipt\r\n";
            this.btnlibEndDontPrint.UseVisualStyleBackColor = true;
            this.btnlibEndDontPrint.Click += new System.EventHandler(this.btnlibEndDontPrint_Click);
            // 
            // btnCancelTrans
            // 
            this.btnCancelTrans.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelTrans.Location = new System.Drawing.Point(605, 628);
            this.btnCancelTrans.Name = "btnCancelTrans";
            this.btnCancelTrans.Size = new System.Drawing.Size(203, 64);
            this.btnCancelTrans.TabIndex = 13;
            this.btnCancelTrans.Text = "Cancel Transaction";
            this.btnCancelTrans.UseVisualStyleBackColor = true;
            this.btnCancelTrans.Click += new System.EventHandler(this.btnCancelTrans_Click);
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(344, 96);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 20);
            this.lblPasswordError.TabIndex = 14;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(226, 135);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 33);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblMemberIDError
            // 
            this.lblMemberIDError.AutoSize = true;
            this.lblMemberIDError.ForeColor = System.Drawing.Color.Red;
            this.lblMemberIDError.Location = new System.Drawing.Point(344, 45);
            this.lblMemberIDError.Name = "lblMemberIDError";
            this.lblMemberIDError.Size = new System.Drawing.Size(0, 20);
            this.lblMemberIDError.TabIndex = 15;
            // 
            // LibBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.lblMemberIDError);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.btnCancelTrans);
            this.Controls.Add(this.btnlibEndDontPrint);
            this.Controls.Add(this.btnlibEndPrint);
            this.Controls.Add(this.txtBorrowError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBorrowBookID);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtMemberType);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.dGVBorrow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibBorrowBook";
            this.Load += new System.EventHandler(this.LibBorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVBorrow;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberType;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtBorrowBookID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtBorrowError;
        private System.Windows.Forms.Button btnlibEndPrint;
        private System.Windows.Forms.Button btnlibEndDontPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVcolumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVcolumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGVcolumn3;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.Button btnCancelTrans;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblMemberIDError;
    }
}