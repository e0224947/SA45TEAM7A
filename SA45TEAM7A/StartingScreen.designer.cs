namespace SA45TEAM7A
{
    partial class MemberLoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLoginForm));
            this.MemberIDTextBox = new System.Windows.Forms.TextBox();
            this.MemberPasswordTextBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MemberIDTextBox
            // 
            this.MemberIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemberIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDTextBox.Location = new System.Drawing.Point(335, 221);
            this.MemberIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberIDTextBox.Name = "MemberIDTextBox";
            this.MemberIDTextBox.Size = new System.Drawing.Size(342, 39);
            this.MemberIDTextBox.TabIndex = 0;
            this.MemberIDTextBox.TextChanged += new System.EventHandler(this.MemberIDTextBox_TextChanged);
            // 
            // MemberPasswordTextBox
            // 
            this.MemberPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemberPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberPasswordTextBox.Location = new System.Drawing.Point(330, 379);
            this.MemberPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemberPasswordTextBox.Name = "MemberPasswordTextBox";
            this.MemberPasswordTextBox.PasswordChar = '*';
            this.MemberPasswordTextBox.Size = new System.Drawing.Size(342, 39);
            this.MemberPasswordTextBox.TabIndex = 1;
            this.MemberPasswordTextBox.TextChanged += new System.EventHandler(this.MemberPasswordTextBox_TextChanged);
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(399, 545);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(168, 76);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password：";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(335, 268);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 5;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(335, 430);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 20);
            this.lblPasswordError.TabIndex = 6;
            // 
            // MemberLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1002, 791);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.MemberPasswordTextBox);
            this.Controls.Add(this.MemberIDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MemberLoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MemberLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MemberIDTextBox;
        private System.Windows.Forms.TextBox MemberPasswordTextBox;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblPasswordError;
    }
}

