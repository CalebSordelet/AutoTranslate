﻿namespace AutoTranslate
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.domainUpDown1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hot Key:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(68, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanian",
            "Arabic",
            "Armenian",
            "Azerbaijani",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bulgarian",
            "Catalan",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Esperanto",
            "Estonian",
            "Filipino",
            "Finnish",
            "French",
            "Galician",
            "German",
            "Georgian",
            "Greek",
            "Haitian Creole",
            "Hebrew",
            "Hindi",
            "Hungarian",
            "Icelandic",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Korean",
            "Lao",
            "Latin",
            "Latvian",
            "Lithuanian",
            "Macedonian",
            "Malay",
            "Maltese",
            "Norwegian",
            "Persian",
            "Polish",
            "Portuguese",
            "Romanian",
            "Russian",
            "Serbian",
            "Slovak",
            "Slovenian",
            "Spanish",
            "Swahili",
            "Swedish",
            "Tamil",
            "Telugu",
            "Thai",
            "Turkish",
            "Ukrainian",
            "Urdu",
            "Vietnamese",
            "Welsh",
            "Yiddish"});
            this.comboBox1.Location = new System.Drawing.Point(73, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "English";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanian",
            "Arabic",
            "Armenian",
            "Azerbaijani",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bulgarian",
            "Catalan",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Esperanto",
            "Estonian",
            "Filipino",
            "Finnish",
            "French",
            "Galician",
            "German",
            "Georgian",
            "Greek",
            "Haitian Creole",
            "Hebrew",
            "Hindi",
            "Hungarian",
            "Icelandic",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Korean",
            "Lao",
            "Latin",
            "Latvian",
            "Lithuanian",
            "Macedonian",
            "Malay",
            "Maltese",
            "Norwegian",
            "Persian",
            "Polish",
            "Portuguese",
            "Romanian",
            "Russian",
            "Serbian",
            "Slovak",
            "Slovenian",
            "Spanish",
            "Swahili",
            "Swedish",
            "Tamil",
            "Telugu",
            "Thai",
            "Turkish",
            "Ukrainian",
            "Urdu",
            "Vietnamese",
            "Welsh",
            "Yiddish"});
            this.comboBox2.Location = new System.Drawing.Point(73, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Japanese";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.FormattingEnabled = true;
            this.domainUpDown1.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.domainUpDown1.Location = new System.Drawing.Point(73, 9);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(125, 21);
            this.domainUpDown1.TabIndex = 8;
            this.domainUpDown1.Text = "F5";
            this.domainUpDown1.SelectedIndexChanged += new System.EventHandler(this.DomainUpDown1_SelectedIndexChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 128);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox domainUpDown1;
    }
}