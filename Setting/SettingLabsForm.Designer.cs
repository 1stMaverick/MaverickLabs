namespace MaverickLabs
{
    partial class SettingLabsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.checkBoxStartInTray = new System.Windows.Forms.CheckBox();
            this.checkBoxDebugMode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.AutoSize = true;
            this.checkBoxAutoStart.Location = new System.Drawing.Point(13, 48);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Size = new System.Drawing.Size(86, 17);
            this.checkBoxAutoStart.TabIndex = 1;
            this.checkBoxAutoStart.Text = "Auto start";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            this.checkBoxAutoStart.CheckedChanged += new System.EventHandler(this.checkBoxAutoStart_CheckedChanged);
            // 
            // checkBoxStartInTray
            // 
            this.checkBoxStartInTray.AutoSize = true;
            this.checkBoxStartInTray.Location = new System.Drawing.Point(13, 71);
            this.checkBoxStartInTray.Name = "checkBoxStartInTray";
            this.checkBoxStartInTray.Size = new System.Drawing.Size(104, 17);
            this.checkBoxStartInTray.TabIndex = 2;
            this.checkBoxStartInTray.Text = "Start in tray";
            this.checkBoxStartInTray.UseVisualStyleBackColor = true;
            this.checkBoxStartInTray.CheckedChanged += new System.EventHandler(this.checkBoxStartInTray_CheckedChanged);
            // 
            // checkBoxDebugMode
            // 
            this.checkBoxDebugMode.AutoSize = true;
            this.checkBoxDebugMode.Location = new System.Drawing.Point(13, 95);
            this.checkBoxDebugMode.Name = "checkBoxDebugMode";
            this.checkBoxDebugMode.Size = new System.Drawing.Size(98, 17);
            this.checkBoxDebugMode.TabIndex = 3;
            this.checkBoxDebugMode.Text = "Debug Mode**";
            this.checkBoxDebugMode.UseVisualStyleBackColor = true;
            this.checkBoxDebugMode.CheckedChanged += new System.EventHandler(this.checkBoxDebugMode_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "If * function not work\r\nIf ** need restart program";
            // 
            // SettingLabsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxDebugMode);
            this.Controls.Add(this.checkBoxStartInTray);
            this.Controls.Add(this.checkBoxAutoStart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "SettingLabsForm";
            this.ShowInTaskbar = false;
            this.Text = "Setting | Maverick Lab\'s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.CheckBox checkBoxStartInTray;
        private System.Windows.Forms.CheckBox checkBoxDebugMode;
        private System.Windows.Forms.Label label2;
    }
}