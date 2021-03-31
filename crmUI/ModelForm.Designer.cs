
namespace crmUI
{
    partial class ModelForm
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
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.customerSpeedbar = new System.Windows.Forms.TrackBar();
            this.sellerSpeedbar = new System.Windows.Forms.TrackBar();
            this.customerLabel = new System.Windows.Forms.Label();
            this.sellerSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerSpeedbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerSpeedbar)).BeginInit();
            this.SuspendLayout();
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(713, 415);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 0;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(632, 415);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // customerSpeedbar
            // 
            this.customerSpeedbar.LargeChange = 100;
            this.customerSpeedbar.Location = new System.Drawing.Point(644, 12);
            this.customerSpeedbar.Maximum = 2000;
            this.customerSpeedbar.Minimum = 100;
            this.customerSpeedbar.Name = "customerSpeedbar";
            this.customerSpeedbar.Size = new System.Drawing.Size(144, 45);
            this.customerSpeedbar.TabIndex = 2;
            this.customerSpeedbar.TickFrequency = 200;
            this.customerSpeedbar.Value = 100;
            this.customerSpeedbar.ValueChanged += new System.EventHandler(this.customerSpeedbar_ValueChanged);
            // 
            // sellerSpeedbar
            // 
            this.sellerSpeedbar.LargeChange = 100;
            this.sellerSpeedbar.Location = new System.Drawing.Point(644, 75);
            this.sellerSpeedbar.Maximum = 2000;
            this.sellerSpeedbar.Minimum = 100;
            this.sellerSpeedbar.Name = "sellerSpeedbar";
            this.sellerSpeedbar.Size = new System.Drawing.Size(144, 45);
            this.sellerSpeedbar.TabIndex = 3;
            this.sellerSpeedbar.TickFrequency = 200;
            this.sellerSpeedbar.Value = 100;
            this.sellerSpeedbar.ValueChanged += new System.EventHandler(this.sellerSpeedbar_ValueChanged);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(552, 12);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(82, 13);
            this.customerLabel.TabIndex = 4;
            this.customerLabel.Text = "Customer delay:";
            // 
            // sellerSpeed
            // 
            this.sellerSpeed.AutoSize = true;
            this.sellerSpeed.Location = new System.Drawing.Point(570, 75);
            this.sellerSpeed.Name = "sellerSpeed";
            this.sellerSpeed.Size = new System.Drawing.Size(64, 13);
            this.sellerSpeed.TabIndex = 5;
            this.sellerSpeed.Text = "Seller delay:";
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sellerSpeed);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.sellerSpeedbar);
            this.Controls.Add(this.customerSpeedbar);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.StopBtn);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelForm_FormClosing);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerSpeedbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerSpeedbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TrackBar customerSpeedbar;
        private System.Windows.Forms.TrackBar sellerSpeedbar;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label sellerSpeed;
    }
}