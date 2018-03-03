namespace SA45TEAM7A
{
    partial class Libextendbook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtMemberType = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMemberIDError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 256);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(694, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(877, 311);
            this.btnExtend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(84, 31);
            this.btnExtend.TabIndex = 3;
            this.btnExtend.Text = "Extend";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.ExtendButton_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(201, 146);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 33);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(319, 107);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 20);
            this.lblPasswordError.TabIndex = 22;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(201, 101);
            this.txtPassWord.MaxLength = 30;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(100, 26);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // txtMemberType
            // 
            this.txtMemberType.BackColor = System.Drawing.SystemColors.Control;
            this.txtMemberType.Enabled = false;
            this.txtMemberType.Location = new System.Drawing.Point(685, 53);
            this.txtMemberType.Name = "txtMemberType";
            this.txtMemberType.ReadOnly = true;
            this.txtMemberType.Size = new System.Drawing.Size(100, 26);
            this.txtMemberType.TabIndex = 20;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(201, 49);
            this.txtMemberID.MaxLength = 4;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 26);
            this.txtMemberID.TabIndex = 0;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Member Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Member ID";
            // 
            // lblMemberIDError
            // 
            this.lblMemberIDError.AutoSize = true;
            this.lblMemberIDError.ForeColor = System.Drawing.Color.Red;
            this.lblMemberIDError.Location = new System.Drawing.Point(319, 52);
            this.lblMemberIDError.Name = "lblMemberIDError";
            this.lblMemberIDError.Size = new System.Drawing.Size(0, 20);
            this.lblMemberIDError.TabIndex = 23;
            // 
            // Libextendbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.lblMemberIDError);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtMemberType);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.dataGridView1);
            this.MinimizeBox = false;
            this.Name = "Libextendbook";
            this.Text = "Libextendbook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtMemberType;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMemberIDError;
    }
}