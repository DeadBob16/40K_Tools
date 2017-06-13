namespace _40k_GM_Kit
{
    partial class Shock
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
            this.button1 = new System.Windows.Forms.Button();
            this.shockDesc = new System.Windows.Forms.RichTextBox();
            this.degFail = new System.Windows.Forms.TextBox();
            this.failLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shockDesc
            // 
            this.shockDesc.Location = new System.Drawing.Point(70, 160);
            this.shockDesc.Name = "shockDesc";
            this.shockDesc.Size = new System.Drawing.Size(210, 265);
            this.shockDesc.TabIndex = 2;
            this.shockDesc.Text = "";
            // 
            // degFail
            // 
            this.degFail.Location = new System.Drawing.Point(70, 97);
            this.degFail.Name = "degFail";
            this.degFail.Size = new System.Drawing.Size(100, 20);
            this.degFail.TabIndex = 3;
            // 
            // failLabel
            // 
            this.failLabel.AutoSize = true;
            this.failLabel.Location = new System.Drawing.Point(70, 78);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(93, 13);
            this.failLabel.TabIndex = 4;
            this.failLabel.Text = "Degrees of Failure";
            // 
            // Shock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 545);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.degFail);
            this.Controls.Add(this.shockDesc);
            this.Controls.Add(this.button1);
            this.Name = "Shock";
            this.Text = "Shock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox shockDesc;
        private System.Windows.Forms.TextBox degFail;
        private System.Windows.Forms.Label failLabel;
    }
}