namespace SA45TEAM7A
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.txtReturnBookID = new System.Windows.Forms.TextBox();
            this.lblWelcome2 = new System.Windows.Forms.Label();
            this.txtReturnError = new System.Windows.Forms.Label();
            this.txtReturnSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReturnBookID
            // 
            this.txtReturnBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReturnBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnBookID.Location = new System.Drawing.Point(418, 300);
            this.txtReturnBookID.Name = "txtReturnBookID";
            this.txtReturnBookID.Size = new System.Drawing.Size(206, 48);
            this.txtReturnBookID.TabIndex = 3;
            this.txtReturnBookID.TextChanged += new System.EventHandler(this.txtReturnBookID_TextChanged);
            // 
            // lblWelcome2
            // 
            this.lblWelcome2.AutoSize = true;
            this.lblWelcome2.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome2.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome2.Name = "lblWelcome2";
            this.lblWelcome2.Size = new System.Drawing.Size(675, 80);
            this.lblWelcome2.TabIndex = 4;
            this.lblWelcome2.Text = "Welcome to Library 7a.\r\nPlease scan one item at a time for return.";
            // 
            // txtReturnError
            // 
            this.txtReturnError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReturnError.AutoSize = true;
            this.txtReturnError.ForeColor = System.Drawing.Color.Red;
            this.txtReturnError.Location = new System.Drawing.Point(425, 260);
            this.txtReturnError.Name = "txtReturnError";
            this.txtReturnError.Size = new System.Drawing.Size(0, 20);
            this.txtReturnError.TabIndex = 5;
            // 
            // txtReturnSuccess
            // 
            this.txtReturnSuccess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReturnSuccess.AutoSize = true;
            this.txtReturnSuccess.ForeColor = System.Drawing.Color.Black;
            this.txtReturnSuccess.Location = new System.Drawing.Point(425, 380);
            this.txtReturnSuccess.Name = "txtReturnSuccess";
            this.txtReturnSuccess.Size = new System.Drawing.Size(0, 20);
            this.txtReturnSuccess.TabIndex = 6;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.txtReturnSuccess);
            this.Controls.Add(this.txtReturnError);
            this.Controls.Add(this.lblWelcome2);
            this.Controls.Add(this.txtReturnBookID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReturnBookID;
        private System.Windows.Forms.Label lblWelcome2;
        private System.Windows.Forms.Label txtReturnError;
        private System.Windows.Forms.Label txtReturnSuccess;
    }
}