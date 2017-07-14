namespace BlenderBot
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FrameNumber = new System.Windows.Forms.NumericUpDown();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.CheckBox();
            this.BlenderSelector = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.FrameNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(108, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(206, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Cancel);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrameNumber
            // 
            this.FrameNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FrameNumber.Location = new System.Drawing.Point(58, 38);
            this.FrameNumber.Name = "FrameNumber";
            this.FrameNumber.Size = new System.Drawing.Size(39, 20);
            this.FrameNumber.TabIndex = 4;
            this.FrameNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FrameNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(43, 12);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(90, 20);
            this.FileName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1000;
            this.label2.Text = "Frame";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(9, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 25);
            this.button3.TabIndex = 1001;
            this.button3.Text = "Preferences";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Preferences);
            // 
            // Shutdown
            // 
            this.Shutdown.AutoSize = true;
            this.Shutdown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shutdown.Location = new System.Drawing.Point(12, 64);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(85, 19);
            this.Shutdown.TabIndex = 1003;
            this.Shutdown.Text = "Shutdown?";
            this.Shutdown.UseVisualStyleBackColor = true;
            // 
            // BlenderSelector
            // 
            this.BlenderSelector.FileName = "blender.exe";
            this.BlenderSelector.Filter = "Executables|*.exe";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 158);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FrameNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Render";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Help);
            this.Shown += new System.EventHandler(this.CheckConfig);
            ((System.ComponentModel.ISupportInitialize)(this.FrameNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FrameNumber;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox Shutdown;
        private System.Windows.Forms.OpenFileDialog BlenderSelector;
    }
}