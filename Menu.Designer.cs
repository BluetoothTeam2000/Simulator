namespace Simulator
{
    partial class Menu
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
            this.buttonSTART.Location = new System.Drawing.Point(215, 59);
            this.buttonSTART.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSTART.Name = "buttonSTART";
            this.buttonSTART.Size = new System.Drawing.Size(171, 46);
            this.buttonSTART.TabIndex = 0;
            this.buttonSTART.Text = "START";
            this.buttonSTART.UseVisualStyleBackColor = true;
            this.buttonSTART.Click += new System.EventHandler(this.buttonSTART_Click);
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEXIT.Location = new System.Drawing.Point(215, 158);
            this.buttonEXIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(171, 46);
            this.buttonEXIT.TabIndex = 2;
            this.buttonEXIT.Text = "EXIT";
            this.buttonEXIT.UseVisualStyleBackColor = true;
            this.buttonEXIT.Click += new System.EventHandler(this.buttonEXIT_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(555, 366);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(56, 17);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "ver. 0.2";
            // 
            // btnPairSSP
            // 
            this.btnPairSSP.Location = new System.Drawing.Point(16, 194);
            this.btnPairSSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnPairSSP.Name = "btnPairSSP";
            this.btnPairSSP.Size = new System.Drawing.Size(160, 31);
            this.btnPairSSP.TabIndex = 5;
            this.btnPairSSP.Text = "Choose device";
            this.btnPairSSP.UseVisualStyleBackColor = true;
            this.btnPairSSP.Click += new System.EventHandler(this.btnPairSSP_Click_1);
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.ItemHeight = 16;
            this.listBoxDevices.Location = new System.Drawing.Point(16, 231);
            this.listBoxDevices.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(159, 116);
            this.listBoxDevices.TabIndex = 4;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(15, 158);
            this.btnScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(160, 31);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(13, 362);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(78, 17);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "Information";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 393);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnPairSSP);
            this.Controls.Add(this.listBoxDevices);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonEXIT);
            this.Controls.Add(this.buttonSTART);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSTART;
        private System.Windows.Forms.Button buttonEXIT;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button btnPairSSP;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label labelInfo;
    }
}