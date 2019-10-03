namespace BigBadBolts_Assign3
{
    partial class RedditQueries
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
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subbredditAwardComboBox = new System.Windows.Forms.ComboBox();
            this.silverCheckBox = new System.Windows.Forms.CheckBox();
            this.platinumCheckBox = new System.Windows.Forms.CheckBox();
            this.goldCheckBox = new System.Windows.Forms.CheckBox();
            this.subAwardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OutputBox.Location = new System.Drawing.Point(349, 28);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(424, 591);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Posts from a specific date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Posts per subbreddit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Posts per User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total awards within a subbreddit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "List of subbreddits posted by a user:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(12, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Points threshold for Posts/Comments:";
            // 
            // subbredditAwardComboBox
            // 
            this.subbredditAwardComboBox.FormattingEnabled = true;
            this.subbredditAwardComboBox.Location = new System.Drawing.Point(101, 359);
            this.subbredditAwardComboBox.Name = "subbredditAwardComboBox";
            this.subbredditAwardComboBox.Size = new System.Drawing.Size(179, 21);
            this.subbredditAwardComboBox.TabIndex = 8;
            // 
            // silverCheckBox
            // 
            this.silverCheckBox.AutoSize = true;
            this.silverCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.silverCheckBox.Location = new System.Drawing.Point(16, 336);
            this.silverCheckBox.Name = "silverCheckBox";
            this.silverCheckBox.Size = new System.Drawing.Size(52, 17);
            this.silverCheckBox.TabIndex = 9;
            this.silverCheckBox.Text = "Silver";
            this.silverCheckBox.UseVisualStyleBackColor = true;
            // 
            // platinumCheckBox
            // 
            this.platinumCheckBox.AutoSize = true;
            this.platinumCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.platinumCheckBox.Location = new System.Drawing.Point(16, 382);
            this.platinumCheckBox.Name = "platinumCheckBox";
            this.platinumCheckBox.Size = new System.Drawing.Size(66, 17);
            this.platinumCheckBox.TabIndex = 10;
            this.platinumCheckBox.Text = "Platinum";
            this.platinumCheckBox.UseVisualStyleBackColor = true;
            // 
            // goldCheckBox
            // 
            this.goldCheckBox.AutoSize = true;
            this.goldCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.goldCheckBox.Location = new System.Drawing.Point(16, 359);
            this.goldCheckBox.Name = "goldCheckBox";
            this.goldCheckBox.Size = new System.Drawing.Size(48, 17);
            this.goldCheckBox.TabIndex = 11;
            this.goldCheckBox.Text = "Gold";
            this.goldCheckBox.UseVisualStyleBackColor = true;
            // 
            // subAwardBtn
            // 
            this.subAwardBtn.Location = new System.Drawing.Point(161, 325);
            this.subAwardBtn.Name = "subAwardBtn";
            this.subAwardBtn.Size = new System.Drawing.Size(75, 23);
            this.subAwardBtn.TabIndex = 12;
            this.subAwardBtn.Text = "Query";
            this.subAwardBtn.UseVisualStyleBackColor = true;
            this.subAwardBtn.Click += new System.EventHandler(this.SubAwardBtn_Click);
            // 
            // RedditQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(786, 631);
            this.Controls.Add(this.subAwardBtn);
            this.Controls.Add(this.goldCheckBox);
            this.Controls.Add(this.platinumCheckBox);
            this.Controls.Add(this.silverCheckBox);
            this.Controls.Add(this.subbredditAwardComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputBox);
            this.Name = "RedditQueries";
            this.Text = "Reddit Queries";
            this.Load += new System.EventHandler(this.RedditQueries_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox subbredditAwardComboBox;
        private System.Windows.Forms.CheckBox silverCheckBox;
        private System.Windows.Forms.CheckBox platinumCheckBox;
        private System.Windows.Forms.CheckBox goldCheckBox;
        private System.Windows.Forms.Button subAwardBtn;
    }
}

