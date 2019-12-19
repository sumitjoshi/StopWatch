namespace ClockTimer
{
    partial class frmClock
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
            this.lblClock = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInterVal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(-13, -4);
            this.lblClock.Margin = new System.Windows.Forms.Padding(0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(353, 191);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAlert
            // 
            this.lblAlert.BackColor = System.Drawing.Color.YellowGreen;
            this.lblAlert.Location = new System.Drawing.Point(318, 19);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(56, 135);
            this.lblAlert.TabIndex = 1;
            this.lblAlert.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInterVal
            // 
            this.txtInterVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterVal.Location = new System.Drawing.Point(193, 105);
            this.txtInterVal.Multiline = true;
            this.txtInterVal.Name = "txtInterVal";
            this.txtInterVal.Size = new System.Drawing.Size(96, 46);
            this.txtInterVal.TabIndex = 3;
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 163);
            this.Controls.Add(this.txtInterVal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lblClock);
            this.Name = "frmClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInterVal;
    }
}

