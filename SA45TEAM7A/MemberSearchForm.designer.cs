namespace SA45TEAM7A
{
    partial class MemberSearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MemberIdtext = new System.Windows.Forms.TextBox();
            this.dgvMemberGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInputError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter MemberID";
            // 
            // MemberIdtext
            // 
            this.MemberIdtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemberIdtext.Location = new System.Drawing.Point(258, 63);
            this.MemberIdtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberIdtext.MaxLength = 4;
            this.MemberIdtext.Name = "MemberIdtext";
            this.MemberIdtext.Size = new System.Drawing.Size(282, 26);
            this.MemberIdtext.TabIndex = 1;
            this.MemberIdtext.TextChanged += new System.EventHandler(this.MemberIdtext_TextChanged);
            // 
            // dgvMemberGrid
            // 
            this.dgvMemberGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMemberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberGrid.Location = new System.Drawing.Point(99, 172);
            this.dgvMemberGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMemberGrid.Name = "dgvMemberGrid";
            this.dgvMemberGrid.Size = new System.Drawing.Size(774, 311);
            this.dgvMemberGrid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(580, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInputError
            // 
            this.lblInputError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInputError.AutoSize = true;
            this.lblInputError.ForeColor = System.Drawing.Color.Red;
            this.lblInputError.Location = new System.Drawing.Point(263, 105);
            this.lblInputError.Name = "lblInputError";
            this.lblInputError.Size = new System.Drawing.Size(0, 20);
            this.lblInputError.TabIndex = 12;
            // 
            // MemberSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 572);
            this.Controls.Add(this.lblInputError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvMemberGrid);
            this.Controls.Add(this.MemberIdtext);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MemberSearchForm";
            this.Text = "Search Member";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MemberIdtext;
        private System.Windows.Forms.DataGridView dgvMemberGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInputError;
    }
}