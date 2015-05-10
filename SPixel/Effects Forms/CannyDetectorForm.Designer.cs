namespace SPixel
{
    partial class CannyDetectorForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thresholdSlider = new AForge.Controls.ColorSlider();
            this.highThresholdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lowThresholdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sigmaTrackBar = new System.Windows.Forms.TrackBar();
            this.sigmaBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.filterPreview = new SPixel.FilterPreview();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filterPreview);
            this.groupBox3.Location = new System.Drawing.Point(302, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 185);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thresholdSlider);
            this.groupBox2.Controls.Add(this.highThresholdBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lowThresholdBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 80);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Threshold Values";
            // 
            // thresholdSlider
            // 
            this.thresholdSlider.Location = new System.Drawing.Point(9, 50);
            this.thresholdSlider.Name = "thresholdSlider";
            this.thresholdSlider.Size = new System.Drawing.Size(262, 23);
            this.thresholdSlider.TabIndex = 4;
            this.thresholdSlider.ValuesChanged += new System.EventHandler(this.thresholdSlider_ValuesChanged);
            // 
            // highThresholdBox
            // 
            this.highThresholdBox.Location = new System.Drawing.Point(155, 20);
            this.highThresholdBox.Name = "highThresholdBox";
            this.highThresholdBox.Size = new System.Drawing.Size(50, 20);
            this.highThresholdBox.TabIndex = 3;
            this.highThresholdBox.TextChanged += new System.EventHandler(this.highThresholdBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(120, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "High:";
            // 
            // lowThresholdBox
            // 
            this.lowThresholdBox.Location = new System.Drawing.Point(45, 20);
            this.lowThresholdBox.Name = "lowThresholdBox";
            this.lowThresholdBox.Size = new System.Drawing.Size(50, 20);
            this.lowThresholdBox.TabIndex = 1;
            this.lowThresholdBox.TextChanged += new System.EventHandler(this.lowThresholdBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sigmaTrackBar);
            this.groupBox1.Controls.Add(this.sigmaBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 95);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gaussian Sigma";
            // 
            // sigmaTrackBar
            // 
            this.sigmaTrackBar.Location = new System.Drawing.Point(10, 45);
            this.sigmaTrackBar.Maximum = 40;
            this.sigmaTrackBar.Name = "sigmaTrackBar";
            this.sigmaTrackBar.Size = new System.Drawing.Size(260, 45);
            this.sigmaTrackBar.TabIndex = 2;
            this.sigmaTrackBar.TickFrequency = 2;
            this.sigmaTrackBar.ValueChanged += new System.EventHandler(this.sigmaTrackBar_ValueChanged);
            // 
            // sigmaBox
            // 
            this.sigmaBox.Location = new System.Drawing.Point(10, 20);
            this.sigmaBox.Name = "sigmaBox";
            this.sigmaBox.Size = new System.Drawing.Size(60, 20);
            this.sigmaBox.TabIndex = 1;
            this.sigmaBox.TextChanged += new System.EventHandler(this.sigmaBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(245, 211);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(164, 211);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // filterPreview
            // 
            this.filterPreview.Image = null;
            this.filterPreview.Location = new System.Drawing.Point(10, 21);
            this.filterPreview.Name = "filterPreview";
            this.filterPreview.Size = new System.Drawing.Size(150, 150);
            this.filterPreview.TabIndex = 13;
            // 
            // CannyDetectorForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(484, 246);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CannyDetectorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Canny Edge Detector";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private SPixel.FilterPreview filterPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox highThresholdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lowThresholdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar sigmaTrackBar;
        private System.Windows.Forms.TextBox sigmaBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private AForge.Controls.ColorSlider thresholdSlider;
    }
}