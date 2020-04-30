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
            this.buttonHISTORY = new System.Windows.Forms.Button();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
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
            this.labelVersion.Location = new System.Drawing.Point(9, 298);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(35, 13);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 319);
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
    }
}