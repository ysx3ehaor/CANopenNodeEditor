namespace ODEditor
{
    partial class ModuleInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nrsupportedmodules = new System.Windows.Forms.TextBox();
            this.listView_modules = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_extends = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_modulecomments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr Supported Modules";
            // 
            // textBox_nrsupportedmodules
            // 
            this.textBox_nrsupportedmodules.Location = new System.Drawing.Point(159, 10);
            this.textBox_nrsupportedmodules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_nrsupportedmodules.Name = "textBox_nrsupportedmodules";
            this.textBox_nrsupportedmodules.ReadOnly = true;
            this.textBox_nrsupportedmodules.Size = new System.Drawing.Size(108, 23);
            this.textBox_nrsupportedmodules.TabIndex = 1;
            // 
            // listView_modules
            // 
            this.listView_modules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_modules.FullRowSelect = true;
            this.listView_modules.HideSelection = false;
            this.listView_modules.Location = new System.Drawing.Point(23, 56);
            this.listView_modules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_modules.Name = "listView_modules";
            this.listView_modules.Size = new System.Drawing.Size(908, 240);
            this.listView_modules.TabIndex = 2;
            this.listView_modules.UseCompatibleStateImageBehavior = false;
            this.listView_modules.View = System.Windows.Forms.View.Details;
            this.listView_modules.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_modules_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 356;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Version";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Revision";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "OrderCode";
            this.columnHeader5.Width = 238;
            // 
            // listView_extends
            // 
            this.listView_extends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listView_extends.HideSelection = false;
            this.listView_extends.Location = new System.Drawing.Point(23, 461);
            this.listView_extends.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_extends.Name = "listView_extends";
            this.listView_extends.Size = new System.Drawing.Size(704, 162);
            this.listView_extends.TabIndex = 3;
            this.listView_extends.UseCompatibleStateImageBehavior = false;
            this.listView_extends.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Index";
            this.columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Description";
            this.columnHeader7.Width = 514;
            // 
            // textBox_modulecomments
            // 
            this.textBox_modulecomments.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.textBox_modulecomments.Location = new System.Drawing.Point(23, 325);
            this.textBox_modulecomments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_modulecomments.Multiline = true;
            this.textBox_modulecomments.Name = "textBox_modulecomments";
            this.textBox_modulecomments.ReadOnly = true;
            this.textBox_modulecomments.Size = new System.Drawing.Size(908, 113);
            this.textBox_modulecomments.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "List of modules";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Module comments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Module objects";
            // 
            // ModuleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_modulecomments);
            this.Controls.Add(this.listView_extends);
            this.Controls.Add(this.listView_modules);
            this.Controls.Add(this.textBox_nrsupportedmodules);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModuleInfo";
            this.Size = new System.Drawing.Size(1074, 644);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nrsupportedmodules;
        private System.Windows.Forms.ListView listView_modules;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listView_extends;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox textBox_modulecomments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
