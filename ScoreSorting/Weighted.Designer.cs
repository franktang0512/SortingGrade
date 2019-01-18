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
            this.Chinese = new System.Windows.Forms.Label();
            this.Math = new System.Windows.Forms.Label();
            this.English = new System.Windows.Forms.Label();
            this.ch = new System.Windows.Forms.TextBox();
            this.ma = new System.Windows.Forms.TextBox();
            this.en = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chinese
            // 
            this.Chinese.AutoSize = true;
            this.Chinese.Location = new System.Drawing.Point(44, 50);
            this.Chinese.Name = "Chinese";
            this.Chinese.Size = new System.Drawing.Size(42, 12);
            this.Chinese.TabIndex = 0;
            this.Chinese.Text = "Chinese";
            this.Chinese.Click += new System.EventHandler(this.label1_Click);
            // 
            // Math
            // 
            this.Math.AutoSize = true;
            this.Math.Location = new System.Drawing.Point(44, 101);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(29, 12);
            this.Math.TabIndex = 1;
            this.Math.Text = "Math";
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Location = new System.Drawing.Point(44, 147);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(40, 12);
            this.English.TabIndex = 2;
            this.English.Text = "English";
            // 
            // ch
            // 
            this.ch.Location = new System.Drawing.Point(119, 47);
            this.ch.Name = "ch";
            this.ch.Size = new System.Drawing.Size(100, 22);
            this.ch.TabIndex = 3;
            this.ch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ma
            // 
            this.ma.Location = new System.Drawing.Point(119, 98);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(100, 22);
            this.ma.TabIndex = 4;
            // 
            // en
            // 
            this.en.Location = new System.Drawing.Point(119, 144);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(100, 22);
            this.en.TabIndex = 5;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(46, 208);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(166, 208);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 7;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Weighted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.en);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.ch);
            this.Controls.Add(this.English);
            this.Controls.Add(this.Math);
            this.Controls.Add(this.Chinese);
            this.Name = "Weighted";
            this.Text = "Weighted";
            this.Load += new System.EventHandler(this.Weighted_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Chinese;
        private System.Windows.Forms.Label Math;
        private System.Windows.Forms.Label English;
        private System.Windows.Forms.TextBox ch;
        private System.Windows.Forms.TextBox ma;
        private System.Windows.Forms.TextBox en;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
    }
}