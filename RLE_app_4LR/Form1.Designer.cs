namespace RLE_app_4LR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.destPath = new System.Windows.Forms.TextBox();
            this.sFilePath = new System.Windows.Forms.Button();
            this.dFilePath = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pack = new System.Windows.Forms.Button();
            this.unpack = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // sourcePath
            // 
            this.sourcePath.Location = new System.Drawing.Point(43, 11);
            this.sourcePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(313, 20);
            this.sourcePath.TabIndex = 0;
            this.sourcePath.TextChanged += new System.EventHandler(this.sFilePath_TextChanged);
            // 
            // destPath
            // 
            this.destPath.Location = new System.Drawing.Point(45, 44);
            this.destPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.destPath.Name = "destPath";
            this.destPath.Size = new System.Drawing.Size(311, 20);
            this.destPath.TabIndex = 1;
            this.destPath.TextChanged += new System.EventHandler(this.dFilePath_TextChanged);
            // 
            // sFilePath
            // 
            this.sFilePath.Location = new System.Drawing.Point(360, 8);
            this.sFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sFilePath.Name = "sFilePath";
            this.sFilePath.Size = new System.Drawing.Size(65, 25);
            this.sFilePath.TabIndex = 2;
            this.sFilePath.Text = "...";
            this.sFilePath.UseVisualStyleBackColor = true;
            this.sFilePath.Click += new System.EventHandler(this.sFilePath_Click);
            // 
            // dFilePath
            // 
            this.dFilePath.Location = new System.Drawing.Point(360, 40);
            this.dFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dFilePath.Name = "dFilePath";
            this.dFilePath.Size = new System.Drawing.Size(65, 27);
            this.dFilePath.TabIndex = 3;
            this.dFilePath.Text = "...";
            this.dFilePath.UseVisualStyleBackColor = true;
            this.dFilePath.Click += new System.EventHandler(this.dFilePath_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(360, 115);
            this.stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(65, 28);
            this.stop.TabIndex = 4;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pack
            // 
            this.pack.Location = new System.Drawing.Point(9, 80);
            this.pack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pack.Name = "pack";
            this.pack.Size = new System.Drawing.Size(221, 24);
            this.pack.TabIndex = 5;
            this.pack.Text = "Pack";
            this.pack.UseVisualStyleBackColor = true;
            this.pack.TextChanged += new System.EventHandler(this.sFilePath_TextChanged);
            this.pack.Click += new System.EventHandler(this.pack_Click);
            // 
            // unpack
            // 
            this.unpack.Location = new System.Drawing.Point(234, 80);
            this.unpack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unpack.Name = "unpack";
            this.unpack.Size = new System.Drawing.Size(191, 24);
            this.unpack.TabIndex = 6;
            this.unpack.Text = "Unpack";
            this.unpack.UseVisualStyleBackColor = true;
            this.unpack.TextChanged += new System.EventHandler(this.sFilePath_TextChanged);
            this.unpack.Click += new System.EventHandler(this.unpack_Click);
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(9, 124);
            this.PB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(326, 19);
            this.PB.Step = 1;
            this.PB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(431, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.unpack);
            this.Controls.Add(this.pack);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.dFilePath);
            this.Controls.Add(this.sFilePath);
            this.Controls.Add(this.destPath);
            this.Controls.Add(this.sourcePath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RLE-приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.TextBox destPath;
        private System.Windows.Forms.Button sFilePath;
        private System.Windows.Forms.Button dFilePath;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pack;
        private System.Windows.Forms.Button unpack;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

