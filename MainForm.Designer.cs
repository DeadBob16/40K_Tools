namespace _40k_GM_Kit
{
    partial class MainForm
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
            this.perilsOpen = new System.Windows.Forms.Button();
            this.critOpen = new System.Windows.Forms.Button();
            this.shockOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // perilsOpen
            // 
            this.perilsOpen.Location = new System.Drawing.Point(13, 13);
            this.perilsOpen.Name = "perilsOpen";
            this.perilsOpen.Size = new System.Drawing.Size(75, 23);
            this.perilsOpen.TabIndex = 0;
            this.perilsOpen.Text = "Perils of the Warp";
            this.perilsOpen.UseVisualStyleBackColor = true;
            this.perilsOpen.Click += new System.EventHandler(this.perilsOpen_Click);
            // 
            // critOpen
            // 
            this.critOpen.Location = new System.Drawing.Point(13, 56);
            this.critOpen.Name = "critOpen";
            this.critOpen.Size = new System.Drawing.Size(75, 23);
            this.critOpen.TabIndex = 1;
            this.critOpen.Text = "Critical Table";
            this.critOpen.UseVisualStyleBackColor = true;
            this.critOpen.Click += new System.EventHandler(this.critOpen_Click);
            // 
            // shockOpen
            // 
            this.shockOpen.Location = new System.Drawing.Point(13, 106);
            this.shockOpen.Name = "shockOpen";
            this.shockOpen.Size = new System.Drawing.Size(75, 23);
            this.shockOpen.TabIndex = 2;
            this.shockOpen.Text = "Shock Table";
            this.shockOpen.UseVisualStyleBackColor = true;
            this.shockOpen.Click += new System.EventHandler(this.shockOpen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.shockOpen);
            this.Controls.Add(this.critOpen);
            this.Controls.Add(this.perilsOpen);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button perilsOpen;
        private System.Windows.Forms.Button critOpen;
        private System.Windows.Forms.Button shockOpen;
    }
}

