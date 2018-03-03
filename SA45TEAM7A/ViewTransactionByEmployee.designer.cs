namespace SA45TEAM7A
{
    partial class ViewTransactionByEmployee
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
            this.TransactionIDTextBox = new System.Windows.Forms.TextBox();
            this.MemberIDTextBox = new System.Windows.Forms.TextBox();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowDetailButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInputError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionIDTextBox
            // 
            this.TransactionIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransactionIDTextBox.Location = new System.Drawing.Point(194, 87);
            this.TransactionIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransactionIDTextBox.MaxLength = 9;
            this.TransactionIDTextBox.Name = "TransactionIDTextBox";
            this.TransactionIDTextBox.Size = new System.Drawing.Size(112, 26);
            this.TransactionIDTextBox.TabIndex = 0;
            this.TransactionIDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MemberIDTextBox
            // 
            this.MemberIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemberIDTextBox.Location = new System.Drawing.Point(507, 87);
            this.MemberIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberIDTextBox.MaxLength = 4;
            this.MemberIDTextBox.Name = "MemberIDTextBox";
            this.MemberIDTextBox.Size = new System.Drawing.Size(112, 26);
            this.MemberIDTextBox.TabIndex = 1;
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookIDTextBox.Location = new System.Drawing.Point(802, 87);
            this.BookIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookIDTextBox.MaxLength = 10;
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.Size = new System.Drawing.Size(112, 26);
            this.BookIDTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 147);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(793, 228);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(121, 398);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(793, 228);
            this.dataGridView2.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchButton.Location = new System.Drawing.Point(223, 671);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(160, 31);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowDetailButton
            // 
            this.ShowDetailButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowDetailButton.Location = new System.Drawing.Point(669, 671);
            this.ShowDetailButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowDetailButton.Name = "ShowDetailButton";
            this.ShowDetailButton.Size = new System.Drawing.Size(150, 31);
            this.ShowDetailButton.TabIndex = 7;
            this.ShowDetailButton.Text = "Show detail";
            this.ShowDetailButton.UseVisualStyleBackColor = true;
            this.ShowDetailButton.Click += new System.EventHandler(this.ShowDitailButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Transaction ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Book ID";
            // 
            // lblInputError
            // 
            this.lblInputError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInputError.AutoSize = true;
            this.lblInputError.ForeColor = System.Drawing.Color.Red;
            this.lblInputError.Location = new System.Drawing.Point(228, 635);
            this.lblInputError.Name = "lblInputError";
            this.lblInputError.Size = new System.Drawing.Size(0, 20);
            this.lblInputError.TabIndex = 11;
            // 
            // ViewTransactionByEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 944);
            this.Controls.Add(this.lblInputError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowDetailButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BookIDTextBox);
            this.Controls.Add(this.MemberIDTextBox);
            this.Controls.Add(this.TransactionIDTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewTransactionByEmployee";
            this.Text = "ViewTransactionByEmployee";
            this.Load += new System.EventHandler(this.ViewTransactionByEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TransactionIDTextBox;
        private System.Windows.Forms.TextBox MemberIDTextBox;
        private System.Windows.Forms.TextBox BookIDTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ShowDetailButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInputError;
    }
}