﻿namespace ODEditor
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_exporter = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.checkBox_genericwarning = new System.Windows.Forms.CheckBox();
            this.checkBox_renamewarning = new System.Windows.Forms.CheckBox();
            this.checkBox_buildwarning = new System.Windows.Forms.CheckBox();
            this.checkBox_stringwarning = new System.Windows.Forms.CheckBox();
            this.checkBox_structwarning = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected exporter";
            // 
            // comboBox_exporter
            // 
            this.comboBox_exporter.FormattingEnabled = true;
            this.comboBox_exporter.Location = new System.Drawing.Point(138, 25);
            this.comboBox_exporter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_exporter.Name = "comboBox_exporter";
            this.comboBox_exporter.Size = new System.Drawing.Size(200, 23);
            this.comboBox_exporter.TabIndex = 1;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(88, 335);
            this.button_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(107, 41);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save and close";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(449, 335);
            this.button_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(107, 41);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // checkBox_genericwarning
            // 
            this.checkBox_genericwarning.AutoSize = true;
            this.checkBox_genericwarning.Location = new System.Drawing.Point(86, 98);
            this.checkBox_genericwarning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_genericwarning.Name = "checkBox_genericwarning";
            this.checkBox_genericwarning.Size = new System.Drawing.Size(151, 19);
            this.checkBox_genericwarning.TabIndex = 4;
            this.checkBox_genericwarning.Text = "Show Generic Warnings";
            this.checkBox_genericwarning.UseVisualStyleBackColor = true;
            this.checkBox_genericwarning.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_renamewarning
            // 
            this.checkBox_renamewarning.AutoSize = true;
            this.checkBox_renamewarning.Location = new System.Drawing.Point(86, 122);
            this.checkBox_renamewarning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_renamewarning.Name = "checkBox_renamewarning";
            this.checkBox_renamewarning.Size = new System.Drawing.Size(154, 19);
            this.checkBox_renamewarning.TabIndex = 5;
            this.checkBox_renamewarning.Text = "Show Rename Warnings";
            this.checkBox_renamewarning.UseVisualStyleBackColor = true;
            // 
            // checkBox_buildwarning
            // 
            this.checkBox_buildwarning.AutoSize = true;
            this.checkBox_buildwarning.Location = new System.Drawing.Point(86, 148);
            this.checkBox_buildwarning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_buildwarning.Name = "checkBox_buildwarning";
            this.checkBox_buildwarning.Size = new System.Drawing.Size(138, 19);
            this.checkBox_buildwarning.TabIndex = 6;
            this.checkBox_buildwarning.Text = "Show Build Warnings";
            this.checkBox_buildwarning.UseVisualStyleBackColor = true;
            // 
            // checkBox_stringwarning
            // 
            this.checkBox_stringwarning.AutoSize = true;
            this.checkBox_stringwarning.Location = new System.Drawing.Point(86, 174);
            this.checkBox_stringwarning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_stringwarning.Name = "checkBox_stringwarning";
            this.checkBox_stringwarning.Size = new System.Drawing.Size(142, 19);
            this.checkBox_stringwarning.TabIndex = 7;
            this.checkBox_stringwarning.Text = "Show String Warnings";
            this.checkBox_stringwarning.UseVisualStyleBackColor = true;
            // 
            // checkBox_structwarning
            // 
            this.checkBox_structwarning.AutoSize = true;
            this.checkBox_structwarning.Location = new System.Drawing.Point(86, 199);
            this.checkBox_structwarning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_structwarning.Name = "checkBox_structwarning";
            this.checkBox_structwarning.Size = new System.Drawing.Size(142, 19);
            this.checkBox_structwarning.TabIndex = 8;
            this.checkBox_structwarning.Text = "Show Struct Warnings";
            this.checkBox_structwarning.UseVisualStyleBackColor = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.checkBox_structwarning);
            this.Controls.Add(this.checkBox_stringwarning);
            this.Controls.Add(this.checkBox_buildwarning);
            this.Controls.Add(this.checkBox_renamewarning);
            this.Controls.Add(this.checkBox_genericwarning);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_exporter);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_exporter;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.CheckBox checkBox_genericwarning;
        private System.Windows.Forms.CheckBox checkBox_renamewarning;
        private System.Windows.Forms.CheckBox checkBox_buildwarning;
        private System.Windows.Forms.CheckBox checkBox_stringwarning;
        private System.Windows.Forms.CheckBox checkBox_structwarning;
    }
}