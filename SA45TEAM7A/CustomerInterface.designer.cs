namespace SA45TEAM7A
{
    partial class CustomerInterfaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInterfaceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccountButton = new System.Windows.Forms.Button();
            this.btnBorrowButton = new System.Windows.Forms.Button();
            this.btnTransactionButton = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
            // 
            // btnAccountButton
            // 
            this.btnAccountButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountButton.Location = new System.Drawing.Point(53, 289);
            this.btnAccountButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccountButton.Name = "btnAccountButton";
            this.btnAccountButton.Size = new System.Drawing.Size(196, 128);
            this.btnAccountButton.TabIndex = 1;
            this.btnAccountButton.Text = "View/ Edit Account";
            this.btnAccountButton.UseVisualStyleBackColor = true;
            this.btnAccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // btnBorrowButton
            // 
            this.btnBorrowButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowButton.Location = new System.Drawing.Point(349, 289);
            this.btnBorrowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrowButton.Name = "btnBorrowButton";
            this.btnBorrowButton.Size = new System.Drawing.Size(196, 128);
            this.btnBorrowButton.TabIndex = 2;
            this.btnBorrowButton.Text = "Borrow Books";
            this.btnBorrowButton.UseVisualStyleBackColor = true;
            this.btnBorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // btnTransactionButton
            // 
            this.btnTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionButton.Location = new System.Drawing.Point(632, 289);
            this.btnTransactionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransactionButton.Name = "btnTransactionButton";
            this.btnTransactionButton.Size = new System.Drawing.Size(196, 128);
            this.btnTransactionButton.TabIndex = 3;
            this.btnTransactionButton.Text = "Extend";
            this.btnTransactionButton.UseVisualStyleBackColor = true;
            this.btnTransactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(349, 576);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CustomerInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 691);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTransactionButton);
            this.Controls.Add(this.btnBorrowButton);
            this.Controls.Add(this.btnAccountButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerInterfaceForm";
            this.Text = "CustomerInterface";
            this.Load += new System.EventHandler(this.CustomerInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccountButton;
        private System.Windows.Forms.Button btnBorrowButton;
        private System.Windows.Forms.Button btnTransactionButton;
        private System.Windows.Forms.Button btnExit;
    }
}