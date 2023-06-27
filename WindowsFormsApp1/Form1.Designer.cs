using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        ETrackBar tbg = new ETrackBar(new TrackBar1(0,5), new TrackBar1(0,10), new TrackBar1(10,25));

        private void logETrackBarOnValueChanged(int channel, int value)
        {
            Console.WriteLine($"Channel {channel} value changed to: {value}");
        }

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
            tbg.OnValueChanged += logETrackBarOnValueChanged; // Handle OnValueChanged

            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(66, 33);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(198, 45);
            this.trackBar1.TabIndex = 0;

            this.trackBar1.Minimum = this.tbg.GetMinValue(0);
            this.trackBar1.Maximum = this.tbg.GetMaxValue(0);
            this.trackBar1.Scroll += (sender, e) => { tbg.SetChanelValue(0, this.trackBar1.Value); };
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(66, 84);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(198, 45);
            this.trackBar2.TabIndex = 1;

            this.trackBar2.Minimum = this.tbg.GetMinValue(1);
            this.trackBar2.Maximum = this.tbg.GetMaxValue(1);
            this.trackBar2.Scroll += (sender, e) => { tbg.SetChanelValue(1, this.trackBar2.Value); };
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(66, 135);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(198, 45);
            this.trackBar3.TabIndex = 2;

            this.trackBar3.Minimum = this.tbg.GetMinValue(2);
            this.trackBar3.Maximum = this.tbg.GetMaxValue(2);
            this.trackBar3.Scroll += (sender, e) => { tbg.SetChanelValue(2, this.trackBar3.Value); };
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
    }
}

