﻿namespace Simulator
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
            this.listViewTemp = new System.Windows.Forms.ListView();
            this.listViewHum = new System.Windows.Forms.ListView();
            this.listViewPress = new System.Windows.Forms.ListView();
            this.listViewEnergy = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTemp = new System.Windows.Forms.ComboBox();
            this.comboBoxHum = new System.Windows.Forms.ComboBox();
            this.comboBoxPress = new System.Windows.Forms.ComboBox();
            this.comboBoxEnergy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(9, 246);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(326, 47);
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
            this.label6.Size = new System.Drawing.Size(673, 35);
            this.label6.TabIndex = 14;
            this.label6.Text = "Variable selection";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkTemp
            // 
            this.checkTemp.AutoSize = true;
            this.checkTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkTemp.Location = new System.Drawing.Point(10, 56);
            this.checkTemp.Margin = new System.Windows.Forms.Padding(2);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(111, 22);
            this.checkTemp.TabIndex = 15;
            this.checkTemp.Text = "Temperature";
            this.checkTemp.UseVisualStyleBackColor = true;
            // 
            // checkCis
            // 
            this.checkCis.AutoSize = true;
            this.checkCis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.checkCis.Location = new System.Drawing.Point(534, 57);
            this.checkCis.Margin = new System.Windows.Forms.Padding(2);
            this.checkCis.Name = "checkCis";
            this.checkCis.Size = new System.Drawing.Size(87, 22);
            this.checkCis.TabIndex = 16;
            this.checkCis.Text = "Pressure";
            this.checkCis.UseVisualStyleBackColor = true;
            // 
            // checkWilg
            // 
            this.checkWilg.AutoSize = true;
            this.checkWilg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.checkWilg.Location = new System.Drawing.Point(268, 57);
            this.checkWilg.Margin = new System.Windows.Forms.Padding(2);
            this.checkWilg.Name = "checkWilg";
            this.checkWilg.Size = new System.Drawing.Size(84, 22);
            this.checkWilg.TabIndex = 17;
            this.checkWilg.Text = "Humidity";
            this.checkWilg.UseVisualStyleBackColor = true;
            // 
            // checkNATB
            // 
            this.checkNATB.AutoSize = true;
            this.checkNATB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.checkNATB.Location = new System.Drawing.Point(10, 116);
            this.checkNATB.Margin = new System.Windows.Forms.Padding(2);
            this.checkNATB.Name = "checkNATB";
            this.checkNATB.Size = new System.Drawing.Size(126, 22);
            this.checkNATB.TabIndex = 18;
            this.checkNATB.Text = "Battery Current";
            this.checkNATB.UseVisualStyleBackColor = true;
            // 
            // checkNAPB
            // 
            this.checkNAPB.AutoSize = true;
            this.checkNAPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkNAPB.Location = new System.Drawing.Point(10, 87);
            this.checkNAPB.Margin = new System.Windows.Forms.Padding(2);
            this.checkNAPB.Name = "checkNAPB";
            this.checkNAPB.Size = new System.Drawing.Size(126, 22);
            this.checkNAPB.TabIndex = 19;
            this.checkNAPB.Text = "Battery Voltage";
            this.checkNAPB.UseVisualStyleBackColor = true;
            // 
            // checkNATSOL
            // 
            this.checkNATSOL.AutoSize = true;
            this.checkNATSOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.checkNATSOL.Location = new System.Drawing.Point(268, 116);
            this.checkNATSOL.Margin = new System.Windows.Forms.Padding(2);
            this.checkNATSOL.Name = "checkNATSOL";
            this.checkNATSOL.Size = new System.Drawing.Size(156, 22);
            this.checkNATSOL.TabIndex = 20;
            this.checkNATSOL.Text = "Solar Panel Current";
            this.checkNATSOL.UseVisualStyleBackColor = true;
            // 
            // checkNAPSOL
            // 
            this.checkNAPSOL.AutoSize = true;
            this.checkNAPSOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.checkNAPSOL.Location = new System.Drawing.Point(268, 87);
            this.checkNAPSOL.Margin = new System.Windows.Forms.Padding(2);
            this.checkNAPSOL.Name = "checkNAPSOL";
            this.checkNAPSOL.Size = new System.Drawing.Size(156, 22);
            this.checkNAPSOL.TabIndex = 21;
            this.checkNAPSOL.Text = "Solar Panel Voltage";
            this.checkNAPSOL.UseVisualStyleBackColor = true;
            // 
            // checkNAPW
            // 
            this.checkNAPW.AutoSize = true;
            this.checkNAPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.checkNAPW.Location = new System.Drawing.Point(534, 87);
            this.checkNAPW.Margin = new System.Windows.Forms.Padding(2);
            this.checkNAPW.Name = "checkNAPW";
            this.checkNAPW.Size = new System.Drawing.Size(116, 22);
            this.checkNAPW.TabIndex = 22;
            this.checkNAPW.Text = "Node Voltage";
            this.checkNAPW.UseVisualStyleBackColor = true;
            // 
            // checkNATW
            // 
            this.checkNATW.AutoSize = true;
            this.checkNATW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.checkNATW.Location = new System.Drawing.Point(534, 116);
            this.checkNATW.Margin = new System.Windows.Forms.Padding(2);
            this.checkNATW.Name = "checkNATW";
            this.checkNATW.Size = new System.Drawing.Size(116, 22);
            this.checkNATW.TabIndex = 23;
            this.checkNATW.Text = "Node Current";
            this.checkNATW.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(11, 624);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(672, 37);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.Location = new System.Drawing.Point(358, 246);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(326, 47);
            this.buttonStop.TabIndex = 25;
            this.buttonStop.Text = "STOP SIMULATION";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // listViewTemp
            // 
            this.listViewTemp.HideSelection = false;
            this.listViewTemp.Location = new System.Drawing.Point(11, 392);
            this.listViewTemp.Name = "listViewTemp";
            this.listViewTemp.Size = new System.Drawing.Size(214, 90);
            this.listViewTemp.TabIndex = 26;
            this.listViewTemp.UseCompatibleStateImageBehavior = false;
            this.listViewTemp.View = System.Windows.Forms.View.Details;
            // 
            // listViewHum
            // 
            this.listViewHum.HideSelection = false;
            this.listViewHum.Location = new System.Drawing.Point(243, 392);
            this.listViewHum.Name = "listViewHum";
            this.listViewHum.Size = new System.Drawing.Size(214, 90);
            this.listViewHum.TabIndex = 27;
            this.listViewHum.UseCompatibleStateImageBehavior = false;
            this.listViewHum.View = System.Windows.Forms.View.Details;
            // 
            // listViewPress
            // 
            this.listViewPress.HideSelection = false;
            this.listViewPress.Location = new System.Drawing.Point(471, 392);
            this.listViewPress.Name = "listViewPress";
            this.listViewPress.Size = new System.Drawing.Size(213, 90);
            this.listViewPress.TabIndex = 28;
            this.listViewPress.UseCompatibleStateImageBehavior = false;
            this.listViewPress.View = System.Windows.Forms.View.Details;
            // 
            // listViewEnergy
            // 
            this.listViewEnergy.HideSelection = false;
            this.listViewEnergy.Location = new System.Drawing.Point(11, 516);
            this.listViewEnergy.Name = "listViewEnergy";
            this.listViewEnergy.Size = new System.Drawing.Size(674, 84);
            this.listViewEnergy.TabIndex = 29;
            this.listViewEnergy.UseCompatibleStateImageBehavior = false;
            this.listViewEnergy.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(9, 372);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label2.Location = new System.Drawing.Point(240, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Humidity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label3.Location = new System.Drawing.Point(468, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Pressure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label4.Location = new System.Drawing.Point(9, 496);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Energy:";
            // 
            // comboBoxTemp
            // 
            this.comboBoxTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemp.FormattingEnabled = true;
            this.comboBoxTemp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10"});
            this.comboBoxTemp.Location = new System.Drawing.Point(9, 221);
            this.comboBoxTemp.Name = "comboBoxTemp";
            this.comboBoxTemp.Size = new System.Drawing.Size(154, 21);
            this.comboBoxTemp.TabIndex = 34;
            // 
            // comboBoxHum
            // 
            this.comboBoxHum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHum.FormattingEnabled = true;
            this.comboBoxHum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10"});
            this.comboBoxHum.Location = new System.Drawing.Point(182, 222);
            this.comboBoxHum.Name = "comboBoxHum";
            this.comboBoxHum.Size = new System.Drawing.Size(154, 21);
            this.comboBoxHum.TabIndex = 35;
            // 
            // comboBoxPress
            // 
            this.comboBoxPress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPress.FormattingEnabled = true;
            this.comboBoxPress.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10"});
            this.comboBoxPress.Location = new System.Drawing.Point(358, 222);
            this.comboBoxPress.Name = "comboBoxPress";
            this.comboBoxPress.Size = new System.Drawing.Size(154, 21);
            this.comboBoxPress.TabIndex = 36;
            // 
            // comboBoxEnergy
            // 
            this.comboBoxEnergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnergy.FormattingEnabled = true;
            this.comboBoxEnergy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10"});
            this.comboBoxEnergy.Location = new System.Drawing.Point(530, 222);
            this.comboBoxEnergy.Name = "comboBoxEnergy";
            this.comboBoxEnergy.Size = new System.Drawing.Size(154, 21);
            this.comboBoxEnergy.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label5.Location = new System.Drawing.Point(7, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Temperature:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label7.Location = new System.Drawing.Point(178, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Humidity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label8.Location = new System.Drawing.Point(355, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Pressure:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label9.Location = new System.Drawing.Point(527, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Energy:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(9, 319);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(676, 35);
            this.label10.TabIndex = 43;
            this.label10.Text = "Results";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(10, 152);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(675, 35);
            this.label11.TabIndex = 44;
            this.label11.Text = "Interval [s]";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 676);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEnergy);
            this.Controls.Add(this.comboBoxPress);
            this.Controls.Add(this.comboBoxHum);
            this.Controls.Add(this.comboBoxTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewEnergy);
            this.Controls.Add(this.listViewPress);
            this.Controls.Add(this.listViewHum);
            this.Controls.Add(this.listViewTemp);
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
        private System.Windows.Forms.ListView listViewTemp;
        private System.Windows.Forms.ListView listViewHum;
        private System.Windows.Forms.ListView listViewPress;
        private System.Windows.Forms.ListView listViewEnergy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTemp;
        private System.Windows.Forms.ComboBox comboBoxHum;
        private System.Windows.Forms.ComboBox comboBoxPress;
        private System.Windows.Forms.ComboBox comboBoxEnergy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

