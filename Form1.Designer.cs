namespace Simulator
{
    partial class Simulator
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkTemp = new System.Windows.Forms.CheckBox();
            this.checkCis = new System.Windows.Forms.CheckBox();
            this.checkWilg = new System.Windows.Forms.CheckBox();
            this.checkNATB = new System.Windows.Forms.CheckBox();
            this.checkNAPB = new System.Windows.Forms.CheckBox();
            this.checkNATSOL = new System.Windows.Forms.CheckBox();
            this.checkNAPSOL = new System.Windows.Forms.CheckBox();
            this.checkNAPW = new System.Windows.Forms.CheckBox();
            this.checkNATW = new System.Windows.Forms.CheckBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(42, 161);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(172, 47);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START SIMULATION";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(11, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 47);
            this.label6.TabIndex = 14;
            this.label6.Text = "Variable selection";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkTemp
            // 
            this.checkTemp.AutoSize = true;
            this.checkTemp.Location = new System.Drawing.Point(11, 67);
            this.checkTemp.Margin = new System.Windows.Forms.Padding(2);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(86, 17);
            this.checkTemp.TabIndex = 15;
            this.checkTemp.Text = "Temperature";
            this.checkTemp.UseVisualStyleBackColor = true;
            // 
            // checkCis
            // 
            this.checkCis.AutoSize = true;
            this.checkCis.Location = new System.Drawing.Point(335, 68);
            this.checkCis.Margin = new System.Windows.Forms.Padding(2);
            this.checkCis.Name = "checkCis";
            this.checkCis.Size = new System.Drawing.Size(67, 17);
            this.checkCis.TabIndex = 16;
            this.checkCis.Text = "Pressure";
            this.checkCis.UseVisualStyleBackColor = true;
            // 
            // checkWilg
            // 
            this.checkWilg.AutoSize = true;
            this.checkWilg.Location = new System.Drawing.Point(178, 68);
            this.checkWilg.Margin = new System.Windows.Forms.Padding(2);
            this.checkWilg.Name = "checkWilg";
            this.checkWilg.Size = new System.Drawing.Size(66, 17);
            this.checkWilg.TabIndex = 17;
            this.checkWilg.Text = "Humidity";
            this.checkWilg.UseVisualStyleBackColor = true;
            // 
            // checkNATB
            // 
            this.checkNATB.AutoSize = true;
            this.checkNATB.Location = new System.Drawing.Point(11, 127);
            this.checkNATB.Margin = new System.Windows.Forms.Padding(2);
            this.checkNATB.Name = "checkNATB";
            this.checkNATB.Size = new System.Drawing.Size(96, 17);
            this.checkNATB.TabIndex = 18;
            this.checkNATB.Text = "Battery Current";
            this.checkNATB.UseVisualStyleBackColor = true;
            // 
            // checkNAPB
            // 
            this.checkNAPB.AutoSize = true;
            this.checkNAPB.Location = new System.Drawing.Point(11, 98);
            this.checkNAPB.Margin = new System.Windows.Forms.Padding(2);
            this.checkNAPB.Name = "checkNAPB";
            this.checkNAPB.Size = new System.Drawing.Size(98, 17);
            this.checkNAPB.TabIndex = 19;
            this.checkNAPB.Text = "Battery Voltage";
            this.checkNAPB.UseVisualStyleBackColor = true;
            // 
            // checkNATSOL
            // 
            this.checkNATSOL.AutoSize = true;
            this.checkNATSOL.Location = new System.Drawing.Point(178, 127);
            this.checkNATSOL.Margin = new System.Windows.Forms.Padding(2);
            this.checkNATSOL.Name = "checkNATSOL";
            this.checkNATSOL.Size = new System.Drawing.Size(117, 17);
            this.checkNATSOL.TabIndex = 20;
            this.checkNATSOL.Text = "Solar Panel Current";
            this.checkNATSOL.UseVisualStyleBackColor = true;
            // 
            // checkNAPSOL
            // 
            this.checkNAPSOL.AutoSize = true;
            this.checkNAPSOL.Location = new System.Drawing.Point(178, 98);
            this.checkNAPSOL.Margin = new System.Windows.Forms.Padding(2);
            this.checkNAPSOL.Name = "checkNAPSOL";
            this.checkNAPSOL.Size = new System.Drawing.Size(119, 17);
            this.checkNAPSOL.TabIndex = 21;
            this.checkNAPSOL.Text = "Solar Panel Voltage";
            this.checkNAPSOL.UseVisualStyleBackColor = true;
            // 
            // checkNAPW
            // 
            this.checkNAPW.AutoSize = true;
            this.checkNAPW.Location = new System.Drawing.Point(335, 98);
            this.checkNAPW.Margin = new System.Windows.Forms.Padding(2);
            this.checkNAPW.Name = "checkNAPW";
            this.checkNAPW.Size = new System.Drawing.Size(91, 17);
            this.checkNAPW.TabIndex = 22;
            this.checkNAPW.Text = "Node Voltage";
            this.checkNAPW.UseVisualStyleBackColor = true;
            // 
            // checkNATW
            // 
            this.checkNATW.AutoSize = true;
            this.checkNATW.Location = new System.Drawing.Point(335, 127);
            this.checkNATW.Margin = new System.Windows.Forms.Padding(2);
            this.checkNATW.Name = "checkNATW";
            this.checkNATW.Size = new System.Drawing.Size(89, 17);
            this.checkNATW.TabIndex = 23;
            this.checkNATW.Text = "Node Current";
            this.checkNATW.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(11, 322);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(442, 37);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.Location = new System.Drawing.Point(231, 161);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(172, 47);
            this.buttonStop.TabIndex = 25;
            this.buttonStop.Text = "STOP SIMULATION";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(12, 220);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(442, 97);
            this.listViewResult.TabIndex = 26;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 368);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.checkNATW);
            this.Controls.Add(this.checkNAPW);
            this.Controls.Add(this.checkNAPSOL);
            this.Controls.Add(this.checkNATSOL);
            this.Controls.Add(this.checkNAPB);
            this.Controls.Add(this.checkNATB);
            this.Controls.Add(this.checkWilg);
            this.Controls.Add(this.checkCis);
            this.Controls.Add(this.checkTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Simulator";
            this.Text = "Simulator2000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkTemp;
        private System.Windows.Forms.CheckBox checkCis;
        private System.Windows.Forms.CheckBox checkWilg;
        private System.Windows.Forms.CheckBox checkNATB;
        private System.Windows.Forms.CheckBox checkNAPB;
        private System.Windows.Forms.CheckBox checkNATSOL;
        private System.Windows.Forms.CheckBox checkNAPSOL;
        private System.Windows.Forms.CheckBox checkNAPW;
        private System.Windows.Forms.CheckBox checkNATW;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ListView listViewResult;
    }
}

