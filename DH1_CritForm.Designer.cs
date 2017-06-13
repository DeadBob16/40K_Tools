namespace _40k_GM_Kit
{
    partial class DH1_CritForm
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
            this.hitLoc = new System.Windows.Forms.ComboBox();
            this.critDesc = new System.Windows.Forms.RichTextBox();
            this.critDmg = new System.Windows.Forms.ComboBox();
            this.critCalc = new System.Windows.Forms.Button();
            this.dmgType = new System.Windows.Forms.ComboBox();
            this.locHelp = new System.Windows.Forms.Label();
            this.dmgTypeLbl = new System.Windows.Forms.Label();
            this.hitLocLbl = new System.Windows.Forms.Label();
            this.critDmgLbl = new System.Windows.Forms.Label();
            this.initHitLbl = new System.Windows.Forms.Label();
            this.numOfHitsLbl = new System.Windows.Forms.Label();
            this.initHit = new System.Windows.Forms.ComboBox();
            this.numOfHits = new System.Windows.Forms.ComboBox();
            this.addHits = new System.Windows.Forms.RichTextBox();
            this.addHitsCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hitLoc
            // 
            this.hitLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hitLoc.FormattingEnabled = true;
            this.hitLoc.Items.AddRange(new object[] {
            "Head",
            "Arm",
            "Body",
            "Leg"});
            this.hitLoc.Location = new System.Drawing.Point(125, 105);
            this.hitLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hitLoc.Name = "hitLoc";
            this.hitLoc.Size = new System.Drawing.Size(98, 27);
            this.hitLoc.TabIndex = 0;
            // 
            // critDesc
            // 
            this.critDesc.Font = new System.Drawing.Font("Caslon Antique", 13.5F);
            this.critDesc.Location = new System.Drawing.Point(15, 313);
            this.critDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.critDesc.Name = "critDesc";
            this.critDesc.ReadOnly = true;
            this.critDesc.Size = new System.Drawing.Size(319, 279);
            this.critDesc.TabIndex = 1;
            this.critDesc.Text = "";
            // 
            // critDmg
            // 
            this.critDmg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.critDmg.FormattingEnabled = true;
            this.critDmg.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.critDmg.Location = new System.Drawing.Point(125, 273);
            this.critDmg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.critDmg.Name = "critDmg";
            this.critDmg.Size = new System.Drawing.Size(98, 27);
            this.critDmg.TabIndex = 2;
            // 
            // critCalc
            // 
            this.critCalc.Location = new System.Drawing.Point(15, 600);
            this.critCalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.critCalc.Name = "critCalc";
            this.critCalc.Size = new System.Drawing.Size(87, 34);
            this.critCalc.TabIndex = 3;
            this.critCalc.Text = "ouch";
            this.critCalc.UseVisualStyleBackColor = true;
            this.critCalc.Click += new System.EventHandler(this.critCalc_Click);
            // 
            // dmgType
            // 
            this.dmgType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dmgType.FormattingEnabled = true;
            this.dmgType.Items.AddRange(new object[] {
            "Energy",
            "Impact",
            "Explosive",
            "Rending"});
            this.dmgType.Location = new System.Drawing.Point(123, 42);
            this.dmgType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dmgType.Name = "dmgType";
            this.dmgType.Size = new System.Drawing.Size(96, 27);
            this.dmgType.TabIndex = 4;
            // 
            // locHelp
            // 
            this.locHelp.AutoSize = true;
            this.locHelp.Location = new System.Drawing.Point(123, 140);
            this.locHelp.Name = "locHelp";
            this.locHelp.Size = new System.Drawing.Size(99, 114);
            this.locHelp.TabIndex = 5;
            this.locHelp.Text = "01–10 Head\r\n11–20 Right Arm\r\n21–30 Left Arm\r\n31–70 Body\r\n71–85 Right Leg\r\n86–00 L" +
    "eft Leg";
            // 
            // dmgTypeLbl
            // 
            this.dmgTypeLbl.AutoSize = true;
            this.dmgTypeLbl.Location = new System.Drawing.Point(14, 54);
            this.dmgTypeLbl.Name = "dmgTypeLbl";
            this.dmgTypeLbl.Size = new System.Drawing.Size(78, 19);
            this.dmgTypeLbl.TabIndex = 6;
            this.dmgTypeLbl.Text = "Damage Type";
            // 
            // hitLocLbl
            // 
            this.hitLocLbl.AutoSize = true;
            this.hitLocLbl.Location = new System.Drawing.Point(15, 117);
            this.hitLocLbl.Name = "hitLocLbl";
            this.hitLocLbl.Size = new System.Drawing.Size(76, 19);
            this.hitLocLbl.TabIndex = 7;
            this.hitLocLbl.Text = "Hit Location";
            // 
            // critDmgLbl
            // 
            this.critDmgLbl.AutoSize = true;
            this.critDmgLbl.Location = new System.Drawing.Point(15, 285);
            this.critDmgLbl.Name = "critDmgLbl";
            this.critDmgLbl.Size = new System.Drawing.Size(92, 19);
            this.critDmgLbl.TabIndex = 8;
            this.critDmgLbl.Text = "Critical Damage";
            // 
            // initHitLbl
            // 
            this.initHitLbl.AutoSize = true;
            this.initHitLbl.Location = new System.Drawing.Point(378, 49);
            this.initHitLbl.Name = "initHitLbl";
            this.initHitLbl.Size = new System.Drawing.Size(109, 19);
            this.initHitLbl.TabIndex = 9;
            this.initHitLbl.Text = "Initial Hit Location";
            // 
            // numOfHitsLbl
            // 
            this.numOfHitsLbl.AutoSize = true;
            this.numOfHitsLbl.Location = new System.Drawing.Point(378, 108);
            this.numOfHitsLbl.Name = "numOfHitsLbl";
            this.numOfHitsLbl.Size = new System.Drawing.Size(96, 19);
            this.numOfHitsLbl.TabIndex = 10;
            this.numOfHitsLbl.Text = "Number of Hits";
            // 
            // initHit
            // 
            this.initHit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.initHit.FormattingEnabled = true;
            this.initHit.Items.AddRange(new object[] {
            "Head",
            "Arm",
            "Body",
            "Leg"});
            this.initHit.Location = new System.Drawing.Point(493, 51);
            this.initHit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.initHit.Name = "initHit";
            this.initHit.Size = new System.Drawing.Size(96, 27);
            this.initHit.TabIndex = 11;
            // 
            // numOfHits
            // 
            this.numOfHits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numOfHits.FormattingEnabled = true;
            this.numOfHits.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6+"});
            this.numOfHits.Location = new System.Drawing.Point(493, 100);
            this.numOfHits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOfHits.Name = "numOfHits";
            this.numOfHits.Size = new System.Drawing.Size(96, 27);
            this.numOfHits.TabIndex = 12;
            // 
            // addHits
            // 
            this.addHits.Location = new System.Drawing.Point(480, 140);
            this.addHits.Name = "addHits";
            this.addHits.ReadOnly = true;
            this.addHits.Size = new System.Drawing.Size(109, 128);
            this.addHits.TabIndex = 13;
            this.addHits.Text = "";
            // 
            // addHitsCalc
            // 
            this.addHitsCalc.Location = new System.Drawing.Point(514, 277);
            this.addHitsCalc.Name = "addHitsCalc";
            this.addHitsCalc.Size = new System.Drawing.Size(75, 23);
            this.addHitsCalc.TabIndex = 14;
            this.addHitsCalc.Text = "Swiss Cheese";
            this.addHitsCalc.UseVisualStyleBackColor = true;
            this.addHitsCalc.Click += new System.EventHandler(this.addHitsCalc_Click);
            // 
            // CritForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 647);
            this.Controls.Add(this.addHitsCalc);
            this.Controls.Add(this.addHits);
            this.Controls.Add(this.numOfHits);
            this.Controls.Add(this.initHit);
            this.Controls.Add(this.numOfHitsLbl);
            this.Controls.Add(this.initHitLbl);
            this.Controls.Add(this.critDmgLbl);
            this.Controls.Add(this.hitLocLbl);
            this.Controls.Add(this.dmgTypeLbl);
            this.Controls.Add(this.locHelp);
            this.Controls.Add(this.dmgType);
            this.Controls.Add(this.critCalc);
            this.Controls.Add(this.critDmg);
            this.Controls.Add(this.critDesc);
            this.Controls.Add(this.hitLoc);
            this.Font = new System.Drawing.Font("Caslon Antique", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CritForm";
            this.Text = "CritForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hitLoc;
        private System.Windows.Forms.RichTextBox critDesc;
        private System.Windows.Forms.ComboBox critDmg;
        private System.Windows.Forms.Button critCalc;
        private System.Windows.Forms.ComboBox dmgType;
        private System.Windows.Forms.Label locHelp;
        private System.Windows.Forms.Label dmgTypeLbl;
        private System.Windows.Forms.Label hitLocLbl;
        private System.Windows.Forms.Label critDmgLbl;
        private System.Windows.Forms.Label initHitLbl;
        private System.Windows.Forms.Label numOfHitsLbl;
        private System.Windows.Forms.ComboBox initHit;
        private System.Windows.Forms.ComboBox numOfHits;
        private System.Windows.Forms.RichTextBox addHits;
        private System.Windows.Forms.Button addHitsCalc;
    }
}