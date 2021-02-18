
namespace WinLossStreamLabel
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.WinIncrement = new System.Windows.Forms.Button();
            this.WinDecrement = new System.Windows.Forms.Button();
            this.WinFormatTextBox = new System.Windows.Forms.TextBox();
            this.WinCurrentCount = new System.Windows.Forms.Label();
            this.WinPreviewLabel = new System.Windows.Forms.Label();
            this.WinPreviewText = new System.Windows.Forms.Label();
            this.WinsTitle = new System.Windows.Forms.Label();
            this.LossesTitle = new System.Windows.Forms.Label();
            this.LossPreviewText = new System.Windows.Forms.Label();
            this.LossPreviewLabel = new System.Windows.Forms.Label();
            this.LossCurrentCount = new System.Windows.Forms.Label();
            this.LossFormatTextBox = new System.Windows.Forms.TextBox();
            this.LossDecrement = new System.Windows.Forms.Button();
            this.LossIncrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WinIncrement
            // 
            this.WinIncrement.Location = new System.Drawing.Point(12, 113);
            this.WinIncrement.Name = "WinIncrement";
            this.WinIncrement.Size = new System.Drawing.Size(75, 23);
            this.WinIncrement.TabIndex = 0;
            this.WinIncrement.Text = "Increment";
            this.WinIncrement.UseVisualStyleBackColor = true;
            this.WinIncrement.Click += new System.EventHandler(this.WinIncrement_Click);
            // 
            // WinDecrement
            // 
            this.WinDecrement.Location = new System.Drawing.Point(93, 113);
            this.WinDecrement.Name = "WinDecrement";
            this.WinDecrement.Size = new System.Drawing.Size(75, 23);
            this.WinDecrement.TabIndex = 1;
            this.WinDecrement.Text = "Decrement";
            this.WinDecrement.UseVisualStyleBackColor = true;
            this.WinDecrement.Click += new System.EventHandler(this.WinDecrement_Click);
            // 
            // WinFormatTextBox
            // 
            this.WinFormatTextBox.Location = new System.Drawing.Point(12, 46);
            this.WinFormatTextBox.Name = "WinFormatTextBox";
            this.WinFormatTextBox.Size = new System.Drawing.Size(156, 20);
            this.WinFormatTextBox.TabIndex = 2;
            this.WinFormatTextBox.TextChanged += new System.EventHandler(this.WinFormatTextBox_TextChanged);
            // 
            // WinCurrentCount
            // 
            this.WinCurrentCount.AutoSize = true;
            this.WinCurrentCount.Location = new System.Drawing.Point(12, 73);
            this.WinCurrentCount.Name = "WinCurrentCount";
            this.WinCurrentCount.Size = new System.Drawing.Size(128, 13);
            this.WinCurrentCount.TabIndex = 3;
            this.WinCurrentCount.Text = "Current Count: Loading....";
            // 
            // WinPreviewLabel
            // 
            this.WinPreviewLabel.AutoSize = true;
            this.WinPreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinPreviewLabel.Location = new System.Drawing.Point(12, 93);
            this.WinPreviewLabel.Name = "WinPreviewLabel";
            this.WinPreviewLabel.Size = new System.Drawing.Size(56, 13);
            this.WinPreviewLabel.TabIndex = 4;
            this.WinPreviewLabel.Text = "Preview:";
            // 
            // WinPreviewText
            // 
            this.WinPreviewText.AutoSize = true;
            this.WinPreviewText.Location = new System.Drawing.Point(65, 93);
            this.WinPreviewText.Name = "WinPreviewText";
            this.WinPreviewText.Size = new System.Drawing.Size(54, 13);
            this.WinPreviewText.TabIndex = 5;
            this.WinPreviewText.Text = "Loading...";
            // 
            // WinsTitle
            // 
            this.WinsTitle.AutoSize = true;
            this.WinsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinsTitle.Location = new System.Drawing.Point(7, 9);
            this.WinsTitle.Name = "WinsTitle";
            this.WinsTitle.Size = new System.Drawing.Size(60, 25);
            this.WinsTitle.TabIndex = 6;
            this.WinsTitle.Text = "Wins";
            // 
            // LossesTitle
            // 
            this.LossesTitle.AutoSize = true;
            this.LossesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LossesTitle.Location = new System.Drawing.Point(199, 9);
            this.LossesTitle.Name = "LossesTitle";
            this.LossesTitle.Size = new System.Drawing.Size(81, 25);
            this.LossesTitle.TabIndex = 13;
            this.LossesTitle.Text = "Losses";
            // 
            // LossPreviewText
            // 
            this.LossPreviewText.AutoSize = true;
            this.LossPreviewText.Location = new System.Drawing.Point(257, 93);
            this.LossPreviewText.Name = "LossPreviewText";
            this.LossPreviewText.Size = new System.Drawing.Size(54, 13);
            this.LossPreviewText.TabIndex = 12;
            this.LossPreviewText.Text = "Loading...";
            // 
            // LossPreviewLabel
            // 
            this.LossPreviewLabel.AutoSize = true;
            this.LossPreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LossPreviewLabel.Location = new System.Drawing.Point(204, 93);
            this.LossPreviewLabel.Name = "LossPreviewLabel";
            this.LossPreviewLabel.Size = new System.Drawing.Size(56, 13);
            this.LossPreviewLabel.TabIndex = 11;
            this.LossPreviewLabel.Text = "Preview:";
            // 
            // LossCurrentCount
            // 
            this.LossCurrentCount.AutoSize = true;
            this.LossCurrentCount.Location = new System.Drawing.Point(204, 73);
            this.LossCurrentCount.Name = "LossCurrentCount";
            this.LossCurrentCount.Size = new System.Drawing.Size(128, 13);
            this.LossCurrentCount.TabIndex = 10;
            this.LossCurrentCount.Text = "Current Count: Loading....";
            // 
            // LossFormatTextBox
            // 
            this.LossFormatTextBox.Location = new System.Drawing.Point(204, 46);
            this.LossFormatTextBox.Name = "LossFormatTextBox";
            this.LossFormatTextBox.Size = new System.Drawing.Size(156, 20);
            this.LossFormatTextBox.TabIndex = 9;
            this.LossFormatTextBox.TextChanged += new System.EventHandler(this.LossFormatTextBox_TextChanged);
            // 
            // LossDecrement
            // 
            this.LossDecrement.Location = new System.Drawing.Point(285, 113);
            this.LossDecrement.Name = "LossDecrement";
            this.LossDecrement.Size = new System.Drawing.Size(75, 23);
            this.LossDecrement.TabIndex = 8;
            this.LossDecrement.Text = "Decrement";
            this.LossDecrement.UseVisualStyleBackColor = true;
            this.LossDecrement.Click += new System.EventHandler(this.LossDecrement_Click);
            // 
            // LossIncrement
            // 
            this.LossIncrement.Location = new System.Drawing.Point(204, 113);
            this.LossIncrement.Name = "LossIncrement";
            this.LossIncrement.Size = new System.Drawing.Size(75, 23);
            this.LossIncrement.TabIndex = 7;
            this.LossIncrement.Text = "Increment";
            this.LossIncrement.UseVisualStyleBackColor = true;
            this.LossIncrement.Click += new System.EventHandler(this.LossIncrement_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.LossesTitle);
            this.Controls.Add(this.LossPreviewText);
            this.Controls.Add(this.LossPreviewLabel);
            this.Controls.Add(this.LossCurrentCount);
            this.Controls.Add(this.LossFormatTextBox);
            this.Controls.Add(this.LossDecrement);
            this.Controls.Add(this.LossIncrement);
            this.Controls.Add(this.WinsTitle);
            this.Controls.Add(this.WinPreviewText);
            this.Controls.Add(this.WinPreviewLabel);
            this.Controls.Add(this.WinCurrentCount);
            this.Controls.Add(this.WinFormatTextBox);
            this.Controls.Add(this.WinDecrement);
            this.Controls.Add(this.WinIncrement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Win-Loss Stream Label";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WinIncrement;
        private System.Windows.Forms.Button WinDecrement;
        private System.Windows.Forms.TextBox WinFormatTextBox;
        private System.Windows.Forms.Label WinCurrentCount;
        private System.Windows.Forms.Label WinPreviewLabel;
        private System.Windows.Forms.Label WinPreviewText;
        private System.Windows.Forms.Label WinsTitle;
        private System.Windows.Forms.Label LossesTitle;
        private System.Windows.Forms.Label LossPreviewText;
        private System.Windows.Forms.Label LossPreviewLabel;
        private System.Windows.Forms.Label LossCurrentCount;
        private System.Windows.Forms.TextBox LossFormatTextBox;
        private System.Windows.Forms.Button LossDecrement;
        private System.Windows.Forms.Button LossIncrement;
    }
}

