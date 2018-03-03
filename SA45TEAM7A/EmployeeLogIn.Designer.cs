namespace SA45TEAM7A
{
    partial class EmployeeLogIn
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
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberPasswordTextBox = new System.Windows.Forms.TextBox();
            this.MemberIDTextBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(413, 462);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 20);
            this.lblPasswordError.TabIndex = 12;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(413, 300);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID：";
            // 
            // MemberPasswordTextBox
            // 
            this.MemberPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemberPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberPasswordTextBox.Location = new System.Drawing.Point(408, 411);
            this.MemberPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberPasswordTextBox.Name = "MemberPasswordTextBox";
            this.MemberPasswordTextBox.PasswordChar = '*';
            this.MemberPasswordTextBox.Size = new System.Drawing.Size(342, 39);
            this.MemberPasswordTextBox.TabIndex = 8;
            this.MemberPasswordTextBox.TextChanged += new System.EventHandler(this.MemberPasswordTextBox_TextChanged);
            // 
            // MemberIDTextBox
            // 
            this.MemberIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemberIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDTextBox.Location = new System.Drawing.Point(413, 253);
            this.MemberIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberIDTextBox.Name = "MemberIDTextBox";
            this.MemberIDTextBox.Size = new System.Drawing.Size(342, 39);
            this.MemberIDTextBox.TabIndex = 7;
            this.MemberIDTextBox.TextChanged += new System.EventHandler(this.MemberIDTextBox_TextChanged);
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(408, 584);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(168, 76);
            this.Login.TabIndex = 13;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // EmployeeLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 735);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemberPasswordTextBox);
            this.Controls.Add(this.MemberIDTextBox);
            this.Name = "EmployeeLogIn";
            this.Text = "Please Log In";
            this.Load += new System.EventHandler(this.EmployeeLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MemberPasswordTextBox;
        private System.Windows.Forms.TextBox MemberIDTextBox;
        private System.Windows.Forms.Button Login;
    }
}