namespace ScoreSorting
{
    partial class Weighted
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.WeightGroupBox = new System.Windows.Forms.GroupBox();
            this.sort = new System.Windows.Forms.Button();
            this.en = new System.Windows.Forms.TextBox();
            this.ma = new System.Windows.Forms.TextBox();
            this.ch = new System.Windows.Forms.TextBox();
            this.English = new System.Windows.Forms.Label();
            this.Math = new System.Windows.Forms.Label();
            this.Chinese = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.WeightGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.WeightGroupBox);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 242);
            this.panel3.TabIndex = 16;
            // 
            // WeightGroupBox
            // 
            this.WeightGroupBox.Controls.Add(this.sort);
            this.WeightGroupBox.Controls.Add(this.en);
            this.WeightGroupBox.Controls.Add(this.ma);
            this.WeightGroupBox.Controls.Add(this.ch);
            this.WeightGroupBox.Controls.Add(this.English);
            this.WeightGroupBox.Controls.Add(this.Math);
            this.WeightGroupBox.Controls.Add(this.Chinese);
            this.WeightGroupBox.Location = new System.Drawing.Point(3, 3);
            this.WeightGroupBox.Name = "WeightGroupBox";
            this.WeightGroupBox.Size = new System.Drawing.Size(233, 236);
            this.WeightGroupBox.TabIndex = 4;
            this.WeightGroupBox.TabStop = false;
            this.WeightGroupBox.Text = "Weight";
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(66, 178);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 14;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // en
            // 
            this.en.Location = new System.Drawing.Point(91, 127);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(100, 22);
            this.en.TabIndex = 13;
            // 
            // ma
            // 
            this.ma.Location = new System.Drawing.Point(91, 81);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(100, 22);
            this.ma.TabIndex = 12;
            // 
            // ch
            // 
            this.ch.Location = new System.Drawing.Point(91, 30);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(100, 22);
            this.ch.TabIndex = 11;
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Location = new System.Drawing.Point(16, 130);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(40, 12);
            this.English.TabIndex = 10;
            this.English.Text = "English";
            // 
            // Math
            // 
            this.Math.AutoSize = true;
            this.Math.Location = new System.Drawing.Point(16, 84);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(29, 12);
            this.Math.TabIndex = 9;
            this.Math.Text = "Math";
            // 
            // Chinese
            // 
            this.Chinese.AutoSize = true;
            this.Chinese.Location = new System.Drawing.Point(16, 33);
            this.Chinese.Name = "Chinese";
            this.Chinese.Size = new System.Drawing.Size(42, 12);
            this.Chinese.TabIndex = 8;
            this.Chinese.Text = "Chinese";
            // 
            // Weighted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 266);
            this.Controls.Add(this.panel3);
            this.Name = "Weighted";
            this.Text = "Weighted";
            this.panel3.ResumeLayout(false);
            this.WeightGroupBox.ResumeLayout(false);
            this.WeightGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox WeightGroupBox;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.TextBox en;
        private System.Windows.Forms.TextBox ma;
        private System.Windows.Forms.TextBox ch;
        private System.Windows.Forms.Label English;
        private System.Windows.Forms.Label Math;
        private System.Windows.Forms.Label Chinese;
    }
}