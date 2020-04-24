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
<<<<<<< HEAD
            this.buttonSYM = new System.Windows.Forms.Button();
=======
            this.buttonStart = new System.Windows.Forms.Button();
>>>>>>> origin/Pablo
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
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
=======
            this.buttonStop = new System.Windows.Forms.Button();
>>>>>>> origin/Pablo
            this.listViewResult = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
<<<<<<< HEAD
            this.buttonSYM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSYM.Location = new System.Drawing.Point(56, 198);
            this.buttonSYM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSYM.Name = "buttonSYM";
            this.buttonSYM.Size = new System.Drawing.Size(229, 58);
            this.buttonSYM.TabIndex = 0;
            this.buttonSYM.Text = "START SIMULATION";
            this.buttonSYM.UseVisualStyleBackColor = true;
=======
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(42, 161);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(172, 47);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START SIMULATION";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
>>>>>>> origin/Pablo
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
<<<<<<< HEAD
            this.checkTemp.Location = new System.Drawing.Point(15, 82);
            this.checkTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.checkTemp.Location = new System.Drawing.Point(11, 67);
            this.checkTemp.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/Pablo
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(112, 21);
            this.checkTemp.TabIndex = 15;
            this.checkTemp.Text = "Temperature";
            this.checkTemp.UseVisualStyleBackColor = true;
            // 
            // checkCis
            // 
            this.checkCis.AutoSize = true;
<<<<<<< HEAD
            this.checkCis.Location = new System.Drawing.Point(447, 84);
            this.checkCis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.checkCis.Location = new System.Drawing.Point(335, 68);
            this.checkCis.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/Pablo
            this.checkCis.Name = "checkCis";
            this.checkCis.Size = new System.Drawing.Size(87, 21);
            this.checkCis.TabIndex = 16;
            this.checkCis.Text = "Pressure";
            this.checkCis.UseVisualStyleBackColor = true;
            // 
            // checkWilg
            // 
            this.checkWilg.AutoSize = true;
<<<<<<< HEAD
            this.checkWilg.Location = new System.Drawing.Point(237, 84);
            this.checkWilg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.checkWilg.Location = new System.Drawing.Point(178, 68);
            this.checkWilg.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/Pablo
            this.checkWilg.Name = "checkWilg";
            this.checkWilg.Size = new System.Drawing.Size(84, 21);
            this.checkWilg.TabIndex = 17;
            this.checkWilg.Text = "Humidity";
            this.checkWilg.UseVisualStyleBackColor = true;
            // 
            // checkNATB
            // 
            this.checkNATB.AutoSize = true;
<<<<<<< HEAD
            this.checkNATB.Location = new System.Drawing.Point(15, 156);
            this.checkNATB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.checkNATB.Location = new System.Drawing.Point(11, 127);
            this.checkNATB.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/Pablo
            this.checkNATB.Name = "checkNATB";
            this.checkNATB.Size = new System.Drawing.Size(126, 21);
            this.checkNATB.TabIndex = 18;
            this.checkNATB.Text = "Battery Current";
            this.checkNATB.UseVisualStyleBackColor = true;
            // 
            // checkNAPB
            // 
            this.checkNAPB.AutoSize = true;
<<<<<<< HEAD
            this.checkNAPB.Location = new System.Drawing.Point(15, 121);
            this.checkNAPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.checkNAPB.Location = new System.Drawing.Point(11, 98);
            this.checkNAPB.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/Pablo
            this.checkNAPB.Name = "checkNAPB";
            this.checkNAPB.Size = new System.Drawing.Size(127, 21);
            this.checkNAPB.TabIndex = 19;
            this.checkNAPB.Text = "Battery Voltage";
            this.checkNAPB.UseVisualStyleBackColor = true;
            // 
            // checkNATSOL
            // 
            this.checkNATSOL.AutoSize = true;
<<<<<<< HEAD
            this.checkNATSOL.Location = new System.Drawing.Point(237, 156);
            this.checkNATSOL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.checkNATSOL.Location = new System.Drawing.Point(178, 127);
            this.checkNATSOL.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/Pablo
            this.checkNATSOL.Name = "checkNATSOL";
            this.checkNATSOL.Size = new System.Drawing.Size(154, 21);
            this.checkNATSOL.TabIndex = 20;
            this.checkNATSOL.Text = "Solar Panel Current";
            this.checkNATSOL.UseVisualStyleBackColor = true;
            // 
            // checkNAPSOL
            // 
            this.checkNAPSOL.AutoSize = true;
<<<<<<< HEAD
            this.checkNAPSOL.Location = new System.Drawing.Point(237, 121);
            this.checkNAPSOL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.checkNAPSOL.Location = new System.Drawing.Point(178, 98);
            this.checkNAPSOL.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/Pablo
            this.checkNAPSOL.Name = "checkNAPSOL";
            this.checkNAPSOL.Size = new System.Drawing.Size(155, 21);
            this.checkNAPSOL.TabIndex = 21;
            this.checkNAPSOL.Text = "Solar Panel Voltage";
            this.checkNAPSOL.UseVisualStyleBackColor = true;
            // 
            // checkNAPW
            // 
            this.checkNAPW.AutoSize = true;
<<<<<<< HEAD
            this.checkNAPW.Location = new System.Drawing.Point(447, 121);
            this.checkNAPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.checkNAPW.Location = new System.Drawing.Point(335, 98);
            this.checkNAPW.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/Pablo
            this.checkNAPW.Name = "checkNAPW";
            this.checkNAPW.Size = new System.Drawing.Size(116, 21);
            this.checkNAPW.TabIndex = 22;
            this.checkNAPW.Text = "Node Voltage";
            this.checkNAPW.UseVisualStyleBackColor = true;
            // 
            // checkNATW
            // 
            this.checkNATW.AutoSize = true;
<<<<<<< HEAD
            this.checkNATW.Location = new System.Drawing.Point(447, 156);
            this.checkNATW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.checkNATW.Location = new System.Drawing.Point(335, 127);
            this.checkNATW.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/Pablo
            this.checkNATW.Name = "checkNATW";
            this.checkNATW.Size = new System.Drawing.Size(115, 21);
            this.checkNATW.TabIndex = 23;
            this.checkNATW.Text = "Node Current";
            this.checkNATW.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
<<<<<<< HEAD
            this.buttonBack.Location = new System.Drawing.Point(15, 396);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.buttonBack.Location = new System.Drawing.Point(11, 322);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> origin/Pablo
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
<<<<<<< HEAD
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(308, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 58);
            this.button1.TabIndex = 25;
            this.button1.Text = "STOP SIMULATION";
            this.button1.UseVisualStyleBackColor = true;
=======
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(12, 220);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(442, 97);
            this.listViewResult.TabIndex = 26;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
>>>>>>> origin/Pablo
            // 
            // listViewResult
            // 
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(16, 272);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(589, 119);
            this.listViewResult.TabIndex = 26;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // Sim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(627, 453);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.button1);
=======
            this.ClientSize = new System.Drawing.Size(470, 368);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.buttonStop);
>>>>>>> origin/Pablo
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
<<<<<<< HEAD
            this.Controls.Add(this.buttonSYM);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sim";
=======
            this.Controls.Add(this.buttonStart);
            this.Name = "Simulator";
>>>>>>> origin/Pablo
            this.Text = "Simulator2000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button buttonSYM;
=======
        private System.Windows.Forms.Button buttonStart;
>>>>>>> origin/Pablo
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
<<<<<<< HEAD
        private System.Windows.Forms.Button button1;
=======
        private System.Windows.Forms.Button buttonStop;
>>>>>>> origin/Pablo
        private System.Windows.Forms.ListView listViewResult;
    }
}

