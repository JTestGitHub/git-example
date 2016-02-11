namespace SampleClone
{
    partial class Form1
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
            this.btnComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(108, 94);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(100, 23);
            this.btnComment.TabIndex = 0;
            this.btnComment.Text = "Get A Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 237);
            this.Controls.Add(this.btnComment);
            this.Name = "Form1";
            this.Text = "Random Programming Comments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComment;
    }
}

