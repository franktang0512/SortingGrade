namespace ScoreSorting
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.學號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.國文 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數學 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.英文 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.平均 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightGroupBox = new System.Windows.Forms.GroupBox();
            this.sort = new System.Windows.Forms.Button();
            this.en = new System.Windows.Forms.TextBox();
            this.ma = new System.Windows.Forms.TextBox();
            this.ch = new System.Windows.Forms.TextBox();
            this.English = new System.Windows.Forms.Label();
            this.Math = new System.Windows.Forms.Label();
            this.Chinese = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.WeightGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 319);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.學號,
            this.姓名,
            this.國文,
            this.數學,
            this.英文,
            this.平均,
            this.名次});
            this.dataGridView1.Location = new System.Drawing.Point(9, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 208);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // 學號
            // 
            this.學號.HeaderText = "學號";
            this.學號.Name = "學號";
            this.學號.ReadOnly = true;
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // 國文
            // 
            this.國文.HeaderText = "國文";
            this.國文.Name = "國文";
            this.國文.ReadOnly = true;
            // 
            // 數學
            // 
            this.數學.HeaderText = "數學";
            this.數學.Name = "數學";
            this.數學.ReadOnly = true;
            // 
            // 英文
            // 
            this.英文.HeaderText = "英文";
            this.英文.Name = "英文";
            this.英文.ReadOnly = true;
            // 
            // 平均
            // 
            this.平均.HeaderText = "平均";
            this.平均.Name = "平均";
            this.平均.ReadOnly = true;
            // 
            // 名次
            // 
            this.名次.HeaderText = "名次";
            this.名次.Name = "名次";
            this.名次.ReadOnly = true;
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
            this.WeightGroupBox.Location = new System.Drawing.Point(3, 4);
            this.WeightGroupBox.Name = "WeightGroupBox";
            this.WeightGroupBox.Size = new System.Drawing.Size(205, 246);
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
            this.sort.Click += new System.EventHandler(this.Sort_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortingWeightsToolStripMenuItem,
            this.reloadToolStripMenuItem1,
            this.addStudentToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // sortingWeightsToolStripMenuItem
            // 
            this.sortingWeightsToolStripMenuItem.Name = "sortingWeightsToolStripMenuItem";
            this.sortingWeightsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.sortingWeightsToolStripMenuItem.Text = "Sorting Weights";
            this.sortingWeightsToolStripMenuItem.Click += new System.EventHandler(this.sortingWeightsToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem1
            // 
            this.reloadToolStripMenuItem1.Name = "reloadToolStripMenuItem1";
            this.reloadToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.reloadToolStripMenuItem1.Text = "Reload";
            this.reloadToolStripMenuItem1.Click += new System.EventHandler(this.reloadToolStripMenuItem1_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 346);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.WeightGroupBox);
            this.panel3.Location = new System.Drawing.Point(468, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 336);
            this.panel3.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "ScoreSorting";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.WeightGroupBox.ResumeLayout(false);
            this.WeightGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 學號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 國文;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數學;
        private System.Windows.Forms.DataGridViewTextBoxColumn 英文;
        private System.Windows.Forms.DataGridViewTextBoxColumn 平均;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名次;
        private System.Windows.Forms.GroupBox WeightGroupBox;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.TextBox en;
        private System.Windows.Forms.TextBox ma;
        private System.Windows.Forms.TextBox ch;
        private System.Windows.Forms.Label English;
        private System.Windows.Forms.Label Math;
        private System.Windows.Forms.Label Chinese;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingWeightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;


    }
}

