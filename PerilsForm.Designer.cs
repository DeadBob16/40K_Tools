namespace _40k_GM_Kit
{
    partial class PerilsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerilsForm));
            this.button1 = new System.Windows.Forms.Button();
            this.phenomenaRoll = new System.Windows.Forms.Label();
            this.phenomenaDesc = new System.Windows.Forms.RichTextBox();
            this.phenomenaTitle = new System.Windows.Forms.Label();
            this.modErr = new System.Windows.Forms.Label();
            this.phenomenaMod = new System.Windows.Forms.ComboBox();
            this.perilNotice = new System.Windows.Forms.Label();
            this.perilNotice2 = new System.Windows.Forms.Label();
            this.phenomenaMod2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phenomenaTitle2 = new System.Windows.Forms.Label();
            this.phenomenaDesc2 = new System.Windows.Forms.RichTextBox();
            this.phenomenaRoll2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(36, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Perils";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phenomenaRoll
            // 
            this.phenomenaRoll.AutoSize = true;
            this.phenomenaRoll.Location = new System.Drawing.Point(286, 54);
            this.phenomenaRoll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phenomenaRoll.Name = "phenomenaRoll";
            this.phenomenaRoll.Size = new System.Drawing.Size(0, 19);
            this.phenomenaRoll.TabIndex = 1;
            // 
            // phenomenaDesc
            // 
            this.phenomenaDesc.Font = new System.Drawing.Font("Caslon Antique", 13F);
            this.phenomenaDesc.Location = new System.Drawing.Point(36, 157);
            this.phenomenaDesc.Margin = new System.Windows.Forms.Padding(4);
            this.phenomenaDesc.Name = "phenomenaDesc";
            this.phenomenaDesc.ReadOnly = true;
            this.phenomenaDesc.Size = new System.Drawing.Size(311, 265);
            this.phenomenaDesc.TabIndex = 2;
            this.phenomenaDesc.Text = "";
            // 
            // phenomenaTitle
            // 
            this.phenomenaTitle.AutoSize = true;
            this.phenomenaTitle.Font = new System.Drawing.Font("Caslon Antique", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phenomenaTitle.Location = new System.Drawing.Point(30, 117);
            this.phenomenaTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phenomenaTitle.Name = "phenomenaTitle";
            this.phenomenaTitle.Size = new System.Drawing.Size(79, 38);
            this.phenomenaTitle.TabIndex = 3;
            this.phenomenaTitle.Text = "Title1";
            // 
            // modErr
            // 
            this.modErr.AutoSize = true;
            this.modErr.Location = new System.Drawing.Point(200, 493);
            this.modErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modErr.Name = "modErr";
            this.modErr.Size = new System.Drawing.Size(0, 19);
            this.modErr.TabIndex = 5;
            // 
            // phenomenaMod
            // 
            this.phenomenaMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phenomenaMod.FormattingEnabled = true;
            this.phenomenaMod.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.phenomenaMod.Location = new System.Drawing.Point(171, 39);
            this.phenomenaMod.Margin = new System.Windows.Forms.Padding(4);
            this.phenomenaMod.Name = "phenomenaMod";
            this.phenomenaMod.Size = new System.Drawing.Size(88, 27);
            this.phenomenaMod.TabIndex = 6;
            // 
            // perilNotice
            // 
            this.perilNotice.AutoSize = true;
            this.perilNotice.Location = new System.Drawing.Point(123, 83);
            this.perilNotice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.perilNotice.Name = "perilNotice";
            this.perilNotice.Size = new System.Drawing.Size(0, 19);
            this.perilNotice.TabIndex = 7;
            // 
            // perilNotice2
            // 
            this.perilNotice2.AutoSize = true;
            this.perilNotice2.Location = new System.Drawing.Point(562, 83);
            this.perilNotice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.perilNotice2.Name = "perilNotice2";
            this.perilNotice2.Size = new System.Drawing.Size(0, 19);
            this.perilNotice2.TabIndex = 14;
            // 
            // phenomenaMod2
            // 
            this.phenomenaMod2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phenomenaMod2.FormattingEnabled = true;
            this.phenomenaMod2.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.phenomenaMod2.Location = new System.Drawing.Point(609, 39);
            this.phenomenaMod2.Margin = new System.Windows.Forms.Padding(4);
            this.phenomenaMod2.Name = "phenomenaMod2";
            this.phenomenaMod2.Size = new System.Drawing.Size(88, 27);
            this.phenomenaMod2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 493);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 12;
            // 
            // phenomenaTitle2
            // 
            this.phenomenaTitle2.AutoSize = true;
            this.phenomenaTitle2.BackColor = System.Drawing.SystemColors.Control;
            this.phenomenaTitle2.Font = new System.Drawing.Font("Caslon Antique", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phenomenaTitle2.Location = new System.Drawing.Point(469, 117);
            this.phenomenaTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phenomenaTitle2.Name = "phenomenaTitle2";
            this.phenomenaTitle2.Size = new System.Drawing.Size(83, 38);
            this.phenomenaTitle2.TabIndex = 11;
            this.phenomenaTitle2.Text = "Title2";
            // 
            // phenomenaDesc2
            // 
            this.phenomenaDesc2.Font = new System.Drawing.Font("Caslon Antique", 13F);
            this.phenomenaDesc2.Location = new System.Drawing.Point(475, 157);
            this.phenomenaDesc2.Margin = new System.Windows.Forms.Padding(4);
            this.phenomenaDesc2.Name = "phenomenaDesc2";
            this.phenomenaDesc2.ReadOnly = true;
            this.phenomenaDesc2.Size = new System.Drawing.Size(311, 265);
            this.phenomenaDesc2.TabIndex = 10;
            this.phenomenaDesc2.Text = "";
            // 
            // phenomenaRoll2
            // 
            this.phenomenaRoll2.AutoSize = true;
            this.phenomenaRoll2.Location = new System.Drawing.Point(724, 54);
            this.phenomenaRoll2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phenomenaRoll2.Name = "phenomenaRoll2";
            this.phenomenaRoll2.Size = new System.Drawing.Size(0, 19);
            this.phenomenaRoll2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(475, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Perils";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PerilsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 487);
            this.Controls.Add(this.perilNotice2);
            this.Controls.Add(this.phenomenaMod2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phenomenaTitle2);
            this.Controls.Add(this.phenomenaDesc2);
            this.Controls.Add(this.phenomenaRoll2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.perilNotice);
            this.Controls.Add(this.phenomenaMod);
            this.Controls.Add(this.modErr);
            this.Controls.Add(this.phenomenaTitle);
            this.Controls.Add(this.phenomenaDesc);
            this.Controls.Add(this.phenomenaRoll);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Caslon Antique", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PerilsForm";
            this.Text = "Perils of the Warp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label phenomenaRoll;
        private System.Windows.Forms.RichTextBox phenomenaDesc;
        private System.Windows.Forms.Label phenomenaTitle;
        private System.Windows.Forms.Label modErr;
        private System.Windows.Forms.ComboBox phenomenaMod;
        private System.Windows.Forms.Label perilNotice;
        private System.Windows.Forms.Label perilNotice2;
        private System.Windows.Forms.ComboBox phenomenaMod2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label phenomenaTitle2;
        private System.Windows.Forms.RichTextBox phenomenaDesc2;
        private System.Windows.Forms.Label phenomenaRoll2;
        private System.Windows.Forms.Button button2;
    }
}

