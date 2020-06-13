namespace Simulator
{
    partial class Menuu
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
            this.buttonSTART = new System.Windows.Forms.Button();
            this.buttonHISTORY = new System.Windows.Forms.Button();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.btnPairSSP = new System.Windows.Forms.Button();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSTART
            // 
            this.buttonSTART.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.buttonSTART.Location = new System.Drawing.Point(161, 48);
            this.buttonSTART.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSTART.Name = "buttonSTART";
            this.buttonSTART.Size = new System.Drawing.Size(128, 37);
            this.buttonSTART.TabIndex = 0;
            this.buttonSTART.Text = "START";
            this.buttonSTART.UseVisualStyleBackColor = true;
            this.buttonSTART.Click += new System.EventHandler(this.buttonSTART_Click);
            // 
            // buttonHISTORY
            // 
            this.buttonHISTORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.buttonHISTORY.Location = new System.Drawing.Point(161, 115);
            this.buttonHISTORY.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHISTORY.Name = "buttonHISTORY";
            this.buttonHISTORY.Size = new System.Drawing.Size(128, 37);
            this.buttonHISTORY.TabIndex = 1;
            this.buttonHISTORY.Text = "HISTORY";
            this.buttonHISTORY.UseVisualStyleBackColor = true;
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEXIT.Location = new System.Drawing.Point(161, 187);
            this.buttonEXIT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(128, 37);
            this.buttonEXIT.TabIndex = 2;
            this.buttonEXIT.Text = "EXIT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(416, 297);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(43, 13);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "ver. 0.2";
            // 
            // btnPairSSP
            // 
            this.btnPairSSP.Location = new System.Drawing.Point(12, 158);
            this.btnPairSSP.Name = "btnPairSSP";
            this.btnPairSSP.Size = new System.Drawing.Size(120, 25);
            this.btnPairSSP.TabIndex = 5;
            this.btnPairSSP.Text = "Choose device";
            this.btnPairSSP.UseVisualStyleBackColor = true;
            this.btnPairSSP.Click += new System.EventHandler(this.btnPairSSP_Click_1);
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.Location = new System.Drawing.Point(12, 188);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(120, 95);
            this.listBoxDevices.TabIndex = 4;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(11, 128);
            this.btnScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(120, 25);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(10, 294);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(59, 13);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "Information";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 319);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnPairSSP);
            this.Controls.Add(this.listBoxDevices);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.buttonHISTORY);
            this.Controls.Add(this.buttonSTART);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSTART;
        private System.Windows.Forms.Button buttonHISTORY;
        private System.Windows.Forms.Button buttonEXIT;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button btnPairSSP;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label labelInfo;
    }
}