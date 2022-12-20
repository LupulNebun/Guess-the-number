namespace Test
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
            this.BTB_Numar = new System.Windows.Forms.Button();
            this.LBL_Text = new System.Windows.Forms.Label();
            this.TB_Numar = new System.Windows.Forms.TextBox();
            this.LBL_Numar = new System.Windows.Forms.Label();
            this.LBL_Reset = new System.Windows.Forms.Button();
            this.LBL_Test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTB_Numar
            // 
            this.BTB_Numar.Location = new System.Drawing.Point(294, 293);
            this.BTB_Numar.Name = "BTB_Numar";
            this.BTB_Numar.Size = new System.Drawing.Size(75, 47);
            this.BTB_Numar.TabIndex = 0;
            this.BTB_Numar.Text = "Chose";
            this.BTB_Numar.UseVisualStyleBackColor = true;
            this.BTB_Numar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBL_Text
            // 
            this.LBL_Text.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBL_Text.Location = new System.Drawing.Point(291, 40);
            this.LBL_Text.Name = "LBL_Text";
            this.LBL_Text.Size = new System.Drawing.Size(191, 35);
            this.LBL_Text.TabIndex = 1;
            this.LBL_Text.Text = "Chose a number betwen 0 and 100";
            this.LBL_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Text.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_Numar
            // 
            this.TB_Numar.Location = new System.Drawing.Point(332, 131);
            this.TB_Numar.Name = "TB_Numar";
            this.TB_Numar.Size = new System.Drawing.Size(100, 20);
            this.TB_Numar.TabIndex = 2;
            // 
            // LBL_Numar
            // 
            this.LBL_Numar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBL_Numar.Location = new System.Drawing.Point(294, 213);
            this.LBL_Numar.Name = "LBL_Numar";
            this.LBL_Numar.Size = new System.Drawing.Size(188, 41);
            this.LBL_Numar.TabIndex = 3;
            this.LBL_Numar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Reset
            // 
            this.LBL_Reset.Location = new System.Drawing.Point(407, 293);
            this.LBL_Reset.Name = "LBL_Reset";
            this.LBL_Reset.Size = new System.Drawing.Size(75, 47);
            this.LBL_Reset.TabIndex = 4;
            this.LBL_Reset.Text = "Reset";
            this.LBL_Reset.UseVisualStyleBackColor = true;
            this.LBL_Reset.Click += new System.EventHandler(this.LBL_Reset_Click);
            // 
            // LBL_Test
            // 
            this.LBL_Test.AutoSize = true;
            this.LBL_Test.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_Test.Location = new System.Drawing.Point(616, 138);
            this.LBL_Test.Name = "LBL_Test";
            this.LBL_Test.Size = new System.Drawing.Size(0, 13);
            this.LBL_Test.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL_Test);
            this.Controls.Add(this.LBL_Reset);
            this.Controls.Add(this.LBL_Numar);
            this.Controls.Add(this.TB_Numar);
            this.Controls.Add(this.LBL_Text);
            this.Controls.Add(this.BTB_Numar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTB_Numar;
        private System.Windows.Forms.Label LBL_Text;
        private System.Windows.Forms.TextBox TB_Numar;
        private System.Windows.Forms.Label LBL_Numar;
        private System.Windows.Forms.Button LBL_Reset;
        private System.Windows.Forms.Label LBL_Test;
    }
}

