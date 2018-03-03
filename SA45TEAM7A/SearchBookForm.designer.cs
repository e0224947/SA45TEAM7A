namespace SA45TEAM7A
{
    partial class SearchBookForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.BookIDtext = new System.Windows.Forms.TextBox();
            this.lblBookIDerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BookID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = ".....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(135, 195);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(639, 322);
            this.dgvSearch.TabIndex = 2;
            // 
            // BookIDtext
            // 
            this.BookIDtext.Location = new System.Drawing.Point(252, 68);
            this.BookIDtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookIDtext.MaxLength = 10;
            this.BookIDtext.Name = "BookIDtext";
            this.BookIDtext.Size = new System.Drawing.Size(256, 26);
            this.BookIDtext.TabIndex = 3;
            this.BookIDtext.TextChanged += new System.EventHandler(this.BookIDtext_TextChanged);
            // 
            // lblBookIDerror
            // 
            this.lblBookIDerror.AutoSize = true;
            this.lblBookIDerror.ForeColor = System.Drawing.Color.Red;
            this.lblBookIDerror.Location = new System.Drawing.Point(252, 103);
            this.lblBookIDerror.Name = "lblBookIDerror";
            this.lblBookIDerror.Size = new System.Drawing.Size(0, 20);
            this.lblBookIDerror.TabIndex = 4;
            // 
            // SearchBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 708);
            this.Controls.Add(this.lblBookIDerror);
            this.Controls.Add(this.BookIDtext);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchBookForm";
            this.Text = "Search Book";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.TextBox BookIDtext;
        private System.Windows.Forms.Label lblBookIDerror;
    }
}