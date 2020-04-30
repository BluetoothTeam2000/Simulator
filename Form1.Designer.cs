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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(16, 198);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(269, 58);
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
            this.label6.Location = new System.Drawing.Point(15, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(590, 57);
            this.label6.TabIndex = 14;
            this.label6.Text = "Variable selection";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkTemp
            // 
            this.checkTemp.AutoSize = true;
            this.checkTemp.Location = new System.Drawing.Point(15, 82);
            this.checkTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(112, 21);
            this.checkTemp.TabIndex = 15;
            this.checkTemp.Text = "Temperature";
            this.checkTemp.UseVisualStyleBackColor = true;
            // 
            // checkCis
            // 
            this.checkCis.AutoSize = true;
            this.checkCis.Location = new System.Drawing.Point(447, 84);
            this.checkCis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkCis.Name = "checkCis";
            this.checkCis.Size = new System.Drawing.Size(87, 21);
            this.checkCis.TabIndex = 16;
            this.checkCis.Text = "Pressure";
            this.checkCis.UseVisualStyleBackColor = true;
            // 
            // checkWilg
            // 
            this.checkWilg.AutoSize = true;
            this.checkWilg.Location = new System.Drawing.Point(237, 84);
            this.checkWilg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkWilg.Name = "checkWilg";
            this.checkWilg.Size = new System.Drawing.Size(84, 21);
            this.checkWilg.TabIndex = 17;
            this.checkWilg.Text = "Humidity";
            this.checkWilg.UseVisualStyleBackColor = true;
            // 
            // checkNATB
            // 
            this.checkNATB.AutoSize = true;
            this.checkNATB.Location = new System.Drawing.Point(15, 156);
            this.checkNATB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkNATB.Name = "checkNATB";
            this.checkNATB.Size = new System.Drawing.Size(126, 21);
            this.checkNATB.TabIndex = 18;
            this.checkNATB.Text = "Battery Current";
            this.checkNATB.UseVisualStyleBackColor = true;
            // 
            // checkNAPB
            // 
            this.checkNAPB.AutoSize = true;
            this.checkNAPB.Location = new System.Drawing.Point(15, 121);
            this.checkNAPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkNAPB.Name = "checkNAPB";
            this.checkNAPB.Size = new System.Drawing.Size(127, 21);
            this.checkNAPB.TabIndex = 19;
            this.checkNAPB.Text = "Battery Voltage";
            this.checkNAPB.UseVisualStyleBackColor = true;
            // 
            // checkNATSOL
            // 
            this.checkNATSOL.AutoSize = true;
            this.checkNATSOL.Location = new System.Drawing.Point(237, 156);
            this.checkNATSOL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkNATSOL.Name = "checkNATSOL";
            this.checkNATSOL.Size = new System.Drawing.Size(154, 21);
            this.checkNATSOL.TabIndex = 20;
            this.checkNATSOL.Text = "Solar Panel Current";
            this.checkNATSOL.UseVisualStyleBackColor = true;
            // 
            // checkNAPSOL
            // 
            this.checkNAPSOL.AutoSize = true;
            this.checkNAPSOL.Location = new System.Drawing.Point(237, 121);
            this.checkNAPSOL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkNAPSOL.Name = "checkNAPSOL";
            this.checkNAPSOL.Size = new System.Drawing.Size(155, 21);
            this.checkNAPSOL.TabIndex = 21;
            this.checkNAPSOL.Text = "Solar Panel Voltage";
            this.checkNAPSOL.UseVisualStyleBackColor = true;
            // 
            // checkNAPW
            // 
            this.checkNAPW.AutoSize = true;
            this.checkNAPW.Location = new System.Drawing.Point(447, 121);
            this.checkNAPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkNAPW.Name = "checkNAPW";
            this.checkNAPW.Size = new System.Drawing.Size(116, 21);
            this.checkNAPW.TabIndex = 22;
            this.checkNAPW.Text = "Node Voltage";
            this.checkNAPW.UseVisualStyleBackColor = true;
            // 
            // checkNATW
            // 
            this.checkNATW.AutoSize = true;
            this.checkNATW.Location = new System.Drawing.Point(447, 156);
            this.checkNATW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkNATW.Name = "checkNATW";
            this.checkNATW.Size = new System.Drawing.Size(115, 21);
            this.checkNATW.TabIndex = 23;
            this.checkNATW.Text = "Node Current";
            this.checkNATW.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(15, 591);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(589, 46);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.Location = new System.Drawing.Point(308, 198);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(297, 58);
            this.buttonStop.TabIndex = 25;
            this.buttonStop.Text = "STOP SIMULATION";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(16, 305);
            this.listViewResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(157, 103);
            this.listViewResult.TabIndex = 26;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(234, 305);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(157, 103);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(448, 305);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(157, 103);
            this.listView2.TabIndex = 28;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(15, 458);
            this.listView3.Margin = new System.Windows.Forms.Padding(4);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(585, 103);
            this.listView3.TabIndex = 29;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Humidity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Pressure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Energy:";
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 653);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

