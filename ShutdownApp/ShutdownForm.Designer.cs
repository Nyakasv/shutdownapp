namespace ShutdownApp
{
    partial class ShutdownForm
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
            this.txbTime = new System.Windows.Forms.TextBox();
            this.lblForTimeUnit = new System.Windows.Forms.Label();
            this.lblForUser = new System.Windows.Forms.Label();
            this.lblForTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbTime
            // 
            this.txbTime.Location = new System.Drawing.Point(90, 52);
            this.txbTime.Name = "txbTime";
            this.txbTime.Size = new System.Drawing.Size(35, 22);
            this.txbTime.TabIndex = 0;
            this.txbTime.Text = "30";
            // 
            // lblForTimeUnit
            // 
            this.lblForTimeUnit.AutoSize = true;
            this.lblForTimeUnit.Location = new System.Drawing.Point(137, 55);
            this.lblForTimeUnit.Name = "lblForTimeUnit";
            this.lblForTimeUnit.Size = new System.Drawing.Size(37, 17);
            this.lblForTimeUnit.TabIndex = 1;
            this.lblForTimeUnit.Text = "mins";
            // 
            // lblForUser
            // 
            this.lblForUser.AutoSize = true;
            this.lblForUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblForUser.Location = new System.Drawing.Point(12, 23);
            this.lblForUser.Name = "lblForUser";
            this.lblForUser.Size = new System.Drawing.Size(195, 17);
            this.lblForUser.TabIndex = 2;
            this.lblForUser.Text = "Set Shutdown Parameters";
            // 
            // lblForTime
            // 
            this.lblForTime.AutoSize = true;
            this.lblForTime.Location = new System.Drawing.Point(25, 55);
            this.lblForTime.Name = "lblForTime";
            this.lblForTime.Size = new System.Drawing.Size(59, 17);
            this.lblForTime.TabIndex = 3;
            this.lblForTime.Text = "Set time";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(28, 90);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(119, 90);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 5;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // ShutdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 283);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblForTime);
            this.Controls.Add(this.lblForUser);
            this.Controls.Add(this.lblForTimeUnit);
            this.Controls.Add(this.txbTime);
            this.Name = "ShutdownForm";
            this.Text = "Shutdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.Label lblForTimeUnit;
        private System.Windows.Forms.Label lblForUser;
        private System.Windows.Forms.Label lblForTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAbort;
    }
}

