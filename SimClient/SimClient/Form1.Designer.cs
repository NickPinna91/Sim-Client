
namespace SimClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tyres_info_groupbox = new System.Windows.Forms.GroupBox();
            this.rear_tyres = new System.Windows.Forms.GroupBox();
            this.groupBoxRearRightInfo = new System.Windows.Forms.GroupBox();
            this.labelRearRightTemperature = new System.Windows.Forms.Label();
            this.labelRearRightPressure = new System.Windows.Forms.Label();
            this.groupBoxRearLeftInfo = new System.Windows.Forms.GroupBox();
            this.labelRearLeftTemperature = new System.Windows.Forms.Label();
            this.labelRearLeftPressure = new System.Windows.Forms.Label();
            this.front_tyres = new System.Windows.Forms.GroupBox();
            this.groupBoxFrontRightInfo = new System.Windows.Forms.GroupBox();
            this.labelFrontRightTemperature = new System.Windows.Forms.Label();
            this.labelFrontRightPressure = new System.Windows.Forms.Label();
            this.groupBoxFrontLeftInfo = new System.Windows.Forms.GroupBox();
            this.labelFrontLeftTemperature = new System.Windows.Forms.Label();
            this.labelFrontLeftPressure = new System.Windows.Forms.Label();
            this.groupBoxGear = new System.Windows.Forms.GroupBox();
            this.labelGear = new System.Windows.Forms.Label();
            this.groupboxTimings = new System.Windows.Forms.GroupBox();
            this.groupBoxLastLapTime = new System.Windows.Forms.GroupBox();
            this.labelLastLapTime = new System.Windows.Forms.Label();
            this.groupBoxBestLapTime = new System.Windows.Forms.GroupBox();
            this.labelBestLapTime = new System.Windows.Forms.Label();
            this.groupBoxRPM = new System.Windows.Forms.GroupBox();
            this.labelMaxRPM = new System.Windows.Forms.Label();
            this.labelRpm = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSpeedKmh = new System.Windows.Forms.Label();
            this.buttonAvvia = new System.Windows.Forms.Button();
            this.tyres_info_groupbox.SuspendLayout();
            this.rear_tyres.SuspendLayout();
            this.groupBoxRearRightInfo.SuspendLayout();
            this.groupBoxRearLeftInfo.SuspendLayout();
            this.front_tyres.SuspendLayout();
            this.groupBoxFrontRightInfo.SuspendLayout();
            this.groupBoxFrontLeftInfo.SuspendLayout();
            this.groupBoxGear.SuspendLayout();
            this.groupboxTimings.SuspendLayout();
            this.groupBoxLastLapTime.SuspendLayout();
            this.groupBoxBestLapTime.SuspendLayout();
            this.groupBoxRPM.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tyres_info_groupbox
            // 
            this.tyres_info_groupbox.Controls.Add(this.rear_tyres);
            this.tyres_info_groupbox.Controls.Add(this.front_tyres);
            this.tyres_info_groupbox.Location = new System.Drawing.Point(12, 185);
            this.tyres_info_groupbox.Name = "tyres_info_groupbox";
            this.tyres_info_groupbox.Size = new System.Drawing.Size(333, 238);
            this.tyres_info_groupbox.TabIndex = 0;
            this.tyres_info_groupbox.TabStop = false;
            this.tyres_info_groupbox.Text = "Tyres";
            // 
            // rear_tyres
            // 
            this.rear_tyres.Controls.Add(this.groupBoxRearRightInfo);
            this.rear_tyres.Controls.Add(this.groupBoxRearLeftInfo);
            this.rear_tyres.Location = new System.Drawing.Point(7, 129);
            this.rear_tyres.Name = "rear_tyres";
            this.rear_tyres.Size = new System.Drawing.Size(312, 102);
            this.rear_tyres.TabIndex = 1;
            this.rear_tyres.TabStop = false;
            this.rear_tyres.Text = "Rear";
            this.rear_tyres.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBoxRearRightInfo
            // 
            this.groupBoxRearRightInfo.Controls.Add(this.labelRearRightTemperature);
            this.groupBoxRearRightInfo.Controls.Add(this.labelRearRightPressure);
            this.groupBoxRearRightInfo.Location = new System.Drawing.Point(157, 25);
            this.groupBoxRearRightInfo.Name = "groupBoxRearRightInfo";
            this.groupBoxRearRightInfo.Size = new System.Drawing.Size(149, 70);
            this.groupBoxRearRightInfo.TabIndex = 3;
            this.groupBoxRearRightInfo.TabStop = false;
            this.groupBoxRearRightInfo.Text = "Right";
            // 
            // labelRearRightTemperature
            // 
            this.labelRearRightTemperature.AutoSize = true;
            this.labelRearRightTemperature.Location = new System.Drawing.Point(13, 50);
            this.labelRearRightTemperature.Name = "labelRearRightTemperature";
            this.labelRearRightTemperature.Size = new System.Drawing.Size(28, 17);
            this.labelRearRightTemperature.TabIndex = 3;
            this.labelRearRightTemperature.Text = "- °c";
            // 
            // labelRearRightPressure
            // 
            this.labelRearRightPressure.AutoSize = true;
            this.labelRearRightPressure.Location = new System.Drawing.Point(13, 22);
            this.labelRearRightPressure.Name = "labelRearRightPressure";
            this.labelRearRightPressure.Size = new System.Drawing.Size(36, 17);
            this.labelRearRightPressure.TabIndex = 2;
            this.labelRearRightPressure.Text = "- PSI";
            // 
            // groupBoxRearLeftInfo
            // 
            this.groupBoxRearLeftInfo.Controls.Add(this.labelRearLeftTemperature);
            this.groupBoxRearLeftInfo.Controls.Add(this.labelRearLeftPressure);
            this.groupBoxRearLeftInfo.Location = new System.Drawing.Point(7, 25);
            this.groupBoxRearLeftInfo.Name = "groupBoxRearLeftInfo";
            this.groupBoxRearLeftInfo.Size = new System.Drawing.Size(149, 70);
            this.groupBoxRearLeftInfo.TabIndex = 2;
            this.groupBoxRearLeftInfo.TabStop = false;
            this.groupBoxRearLeftInfo.Text = "Left";
            // 
            // labelRearLeftTemperature
            // 
            this.labelRearLeftTemperature.AutoSize = true;
            this.labelRearLeftTemperature.Location = new System.Drawing.Point(7, 50);
            this.labelRearLeftTemperature.Name = "labelRearLeftTemperature";
            this.labelRearLeftTemperature.Size = new System.Drawing.Size(28, 17);
            this.labelRearLeftTemperature.TabIndex = 3;
            this.labelRearLeftTemperature.Text = "- °c";
            // 
            // labelRearLeftPressure
            // 
            this.labelRearLeftPressure.AutoSize = true;
            this.labelRearLeftPressure.Location = new System.Drawing.Point(7, 22);
            this.labelRearLeftPressure.Name = "labelRearLeftPressure";
            this.labelRearLeftPressure.Size = new System.Drawing.Size(36, 17);
            this.labelRearLeftPressure.TabIndex = 2;
            this.labelRearLeftPressure.Text = "- PSI";
            // 
            // front_tyres
            // 
            this.front_tyres.Controls.Add(this.groupBoxFrontRightInfo);
            this.front_tyres.Controls.Add(this.groupBoxFrontLeftInfo);
            this.front_tyres.Location = new System.Drawing.Point(7, 25);
            this.front_tyres.Name = "front_tyres";
            this.front_tyres.Size = new System.Drawing.Size(312, 97);
            this.front_tyres.TabIndex = 0;
            this.front_tyres.TabStop = false;
            this.front_tyres.Text = "Front";
            // 
            // groupBoxFrontRightInfo
            // 
            this.groupBoxFrontRightInfo.Controls.Add(this.labelFrontRightTemperature);
            this.groupBoxFrontRightInfo.Controls.Add(this.labelFrontRightPressure);
            this.groupBoxFrontRightInfo.Location = new System.Drawing.Point(157, 20);
            this.groupBoxFrontRightInfo.Name = "groupBoxFrontRightInfo";
            this.groupBoxFrontRightInfo.Size = new System.Drawing.Size(149, 70);
            this.groupBoxFrontRightInfo.TabIndex = 1;
            this.groupBoxFrontRightInfo.TabStop = false;
            this.groupBoxFrontRightInfo.Text = "Right";
            // 
            // labelFrontRightTemperature
            // 
            this.labelFrontRightTemperature.AutoSize = true;
            this.labelFrontRightTemperature.Location = new System.Drawing.Point(13, 48);
            this.labelFrontRightTemperature.Name = "labelFrontRightTemperature";
            this.labelFrontRightTemperature.Size = new System.Drawing.Size(28, 17);
            this.labelFrontRightTemperature.TabIndex = 3;
            this.labelFrontRightTemperature.Text = "- °c";
            // 
            // labelFrontRightPressure
            // 
            this.labelFrontRightPressure.AutoSize = true;
            this.labelFrontRightPressure.Location = new System.Drawing.Point(13, 26);
            this.labelFrontRightPressure.Name = "labelFrontRightPressure";
            this.labelFrontRightPressure.Size = new System.Drawing.Size(36, 17);
            this.labelFrontRightPressure.TabIndex = 2;
            this.labelFrontRightPressure.Text = "- PSI";
            // 
            // groupBoxFrontLeftInfo
            // 
            this.groupBoxFrontLeftInfo.Controls.Add(this.labelFrontLeftTemperature);
            this.groupBoxFrontLeftInfo.Controls.Add(this.labelFrontLeftPressure);
            this.groupBoxFrontLeftInfo.Location = new System.Drawing.Point(7, 20);
            this.groupBoxFrontLeftInfo.Name = "groupBoxFrontLeftInfo";
            this.groupBoxFrontLeftInfo.Size = new System.Drawing.Size(149, 70);
            this.groupBoxFrontLeftInfo.TabIndex = 0;
            this.groupBoxFrontLeftInfo.TabStop = false;
            this.groupBoxFrontLeftInfo.Text = "Left";
            // 
            // labelFrontLeftTemperature
            // 
            this.labelFrontLeftTemperature.AutoSize = true;
            this.labelFrontLeftTemperature.Location = new System.Drawing.Point(7, 48);
            this.labelFrontLeftTemperature.Name = "labelFrontLeftTemperature";
            this.labelFrontLeftTemperature.Size = new System.Drawing.Size(28, 17);
            this.labelFrontLeftTemperature.TabIndex = 1;
            this.labelFrontLeftTemperature.Text = "- °c";
            // 
            // labelFrontLeftPressure
            // 
            this.labelFrontLeftPressure.AutoSize = true;
            this.labelFrontLeftPressure.Location = new System.Drawing.Point(7, 26);
            this.labelFrontLeftPressure.Name = "labelFrontLeftPressure";
            this.labelFrontLeftPressure.Size = new System.Drawing.Size(36, 17);
            this.labelFrontLeftPressure.TabIndex = 0;
            this.labelFrontLeftPressure.Text = "- PSI";
            // 
            // groupBoxGear
            // 
            this.groupBoxGear.Controls.Add(this.labelGear);
            this.groupBoxGear.Location = new System.Drawing.Point(366, 328);
            this.groupBoxGear.Name = "groupBoxGear";
            this.groupBoxGear.Size = new System.Drawing.Size(268, 167);
            this.groupBoxGear.TabIndex = 1;
            this.groupBoxGear.TabStop = false;
            this.groupBoxGear.Text = "Gear";
            // 
            // labelGear
            // 
            this.labelGear.AutoSize = true;
            this.labelGear.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGear.Location = new System.Drawing.Point(70, 30);
            this.labelGear.Name = "labelGear";
            this.labelGear.Size = new System.Drawing.Size(127, 120);
            this.labelGear.TabIndex = 0;
            this.labelGear.Text = "N";
            this.labelGear.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupboxTimings
            // 
            this.groupboxTimings.Controls.Add(this.groupBoxLastLapTime);
            this.groupboxTimings.Controls.Add(this.groupBoxBestLapTime);
            this.groupboxTimings.Location = new System.Drawing.Point(12, 12);
            this.groupboxTimings.Name = "groupboxTimings";
            this.groupboxTimings.Size = new System.Drawing.Size(330, 167);
            this.groupboxTimings.TabIndex = 2;
            this.groupboxTimings.TabStop = false;
            this.groupboxTimings.Text = "Timings";
            // 
            // groupBoxLastLapTime
            // 
            this.groupBoxLastLapTime.Controls.Add(this.labelLastLapTime);
            this.groupBoxLastLapTime.Location = new System.Drawing.Point(6, 24);
            this.groupBoxLastLapTime.Name = "groupBoxLastLapTime";
            this.groupBoxLastLapTime.Size = new System.Drawing.Size(318, 64);
            this.groupBoxLastLapTime.TabIndex = 1;
            this.groupBoxLastLapTime.TabStop = false;
            this.groupBoxLastLapTime.Text = "Last Lap";
            // 
            // labelLastLapTime
            // 
            this.labelLastLapTime.AutoSize = true;
            this.labelLastLapTime.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastLapTime.Location = new System.Drawing.Point(10, 21);
            this.labelLastLapTime.Name = "labelLastLapTime";
            this.labelLastLapTime.Size = new System.Drawing.Size(95, 30);
            this.labelLastLapTime.TabIndex = 0;
            this.labelLastLapTime.Text = "--:--.---";
            // 
            // groupBoxBestLapTime
            // 
            this.groupBoxBestLapTime.Controls.Add(this.labelBestLapTime);
            this.groupBoxBestLapTime.Location = new System.Drawing.Point(6, 94);
            this.groupBoxBestLapTime.Name = "groupBoxBestLapTime";
            this.groupBoxBestLapTime.Size = new System.Drawing.Size(318, 64);
            this.groupBoxBestLapTime.TabIndex = 0;
            this.groupBoxBestLapTime.TabStop = false;
            this.groupBoxBestLapTime.Text = "Best Lap";
            // 
            // labelBestLapTime
            // 
            this.labelBestLapTime.AutoSize = true;
            this.labelBestLapTime.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBestLapTime.Location = new System.Drawing.Point(10, 21);
            this.labelBestLapTime.Name = "labelBestLapTime";
            this.labelBestLapTime.Size = new System.Drawing.Size(95, 30);
            this.labelBestLapTime.TabIndex = 1;
            this.labelBestLapTime.Text = "--:--.---";
            // 
            // groupBoxRPM
            // 
            this.groupBoxRPM.Controls.Add(this.labelMaxRPM);
            this.groupBoxRPM.Controls.Add(this.labelRpm);
            this.groupBoxRPM.Location = new System.Drawing.Point(366, 130);
            this.groupBoxRPM.Name = "groupBoxRPM";
            this.groupBoxRPM.Size = new System.Drawing.Size(268, 165);
            this.groupBoxRPM.TabIndex = 3;
            this.groupBoxRPM.TabStop = false;
            this.groupBoxRPM.Text = "RPM";
            // 
            // labelMaxRPM
            // 
            this.labelMaxRPM.AutoSize = true;
            this.labelMaxRPM.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxRPM.Location = new System.Drawing.Point(6, 45);
            this.labelMaxRPM.Name = "labelMaxRPM";
            this.labelMaxRPM.Size = new System.Drawing.Size(67, 36);
            this.labelMaxRPM.TabIndex = 1;
            this.labelMaxRPM.Text = "----";
            // 
            // labelRpm
            // 
            this.labelRpm.AutoSize = true;
            this.labelRpm.Font = new System.Drawing.Font("Microsoft JhengHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRpm.Location = new System.Drawing.Point(6, 99);
            this.labelRpm.Name = "labelRpm";
            this.labelRpm.Size = new System.Drawing.Size(79, 44);
            this.labelRpm.TabIndex = 0;
            this.labelRpm.Text = "----";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSpeedKmh);
            this.groupBox2.Location = new System.Drawing.Point(366, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speed";
            // 
            // labelSpeedKmh
            // 
            this.labelSpeedKmh.AutoSize = true;
            this.labelSpeedKmh.Font = new System.Drawing.Font("Microsoft JhengHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpeedKmh.Location = new System.Drawing.Point(6, 33);
            this.labelSpeedKmh.Name = "labelSpeedKmh";
            this.labelSpeedKmh.Size = new System.Drawing.Size(79, 44);
            this.labelSpeedKmh.TabIndex = 0;
            this.labelSpeedKmh.Text = "----";
            // 
            // buttonAvvia
            // 
            this.buttonAvvia.Location = new System.Drawing.Point(227, 452);
            this.buttonAvvia.Name = "buttonAvvia";
            this.buttonAvvia.Size = new System.Drawing.Size(104, 43);
            this.buttonAvvia.TabIndex = 5;
            this.buttonAvvia.Text = "AVVIA";
            this.buttonAvvia.UseVisualStyleBackColor = true;
            this.buttonAvvia.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 507);
            this.Controls.Add(this.buttonAvvia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxRPM);
            this.Controls.Add(this.groupboxTimings);
            this.Controls.Add(this.groupBoxGear);
            this.Controls.Add(this.tyres_info_groupbox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tyres_info_groupbox.ResumeLayout(false);
            this.rear_tyres.ResumeLayout(false);
            this.groupBoxRearRightInfo.ResumeLayout(false);
            this.groupBoxRearRightInfo.PerformLayout();
            this.groupBoxRearLeftInfo.ResumeLayout(false);
            this.groupBoxRearLeftInfo.PerformLayout();
            this.front_tyres.ResumeLayout(false);
            this.groupBoxFrontRightInfo.ResumeLayout(false);
            this.groupBoxFrontRightInfo.PerformLayout();
            this.groupBoxFrontLeftInfo.ResumeLayout(false);
            this.groupBoxFrontLeftInfo.PerformLayout();
            this.groupBoxGear.ResumeLayout(false);
            this.groupBoxGear.PerformLayout();
            this.groupboxTimings.ResumeLayout(false);
            this.groupBoxLastLapTime.ResumeLayout(false);
            this.groupBoxLastLapTime.PerformLayout();
            this.groupBoxBestLapTime.ResumeLayout(false);
            this.groupBoxBestLapTime.PerformLayout();
            this.groupBoxRPM.ResumeLayout(false);
            this.groupBoxRPM.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tyres_info_groupbox;
        private System.Windows.Forms.GroupBox rear_tyres;
        private System.Windows.Forms.GroupBox front_tyres;
        private System.Windows.Forms.GroupBox groupBoxRearRightInfo;
        private System.Windows.Forms.Label labelRearRightTemperature;
        private System.Windows.Forms.Label labelRearRightPressure;
        private System.Windows.Forms.GroupBox groupBoxRearLeftInfo;
        private System.Windows.Forms.Label labelRearLeftTemperature;
        private System.Windows.Forms.Label labelRearLeftPressure;
        private System.Windows.Forms.GroupBox groupBoxFrontRightInfo;
        private System.Windows.Forms.Label labelFrontRightTemperature;
        private System.Windows.Forms.Label labelFrontRightPressure;
        private System.Windows.Forms.GroupBox groupBoxFrontLeftInfo;
        private System.Windows.Forms.Label labelFrontLeftTemperature;
        private System.Windows.Forms.Label labelFrontLeftPressure;
        private System.Windows.Forms.GroupBox groupBoxGear;
        private System.Windows.Forms.GroupBox groupboxTimings;
        private System.Windows.Forms.GroupBox groupBoxLastLapTime;
        private System.Windows.Forms.GroupBox groupBoxBestLapTime;
        private System.Windows.Forms.Label labelGear;
        private System.Windows.Forms.Label labelLastLapTime;
        private System.Windows.Forms.Label labelBestLapTime;
        private System.Windows.Forms.GroupBox groupBoxRPM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelRpm;
        private System.Windows.Forms.Label labelSpeedKmh;
        private System.Windows.Forms.Button buttonAvvia;
        private System.Windows.Forms.Label labelMaxRPM;
    }
}

