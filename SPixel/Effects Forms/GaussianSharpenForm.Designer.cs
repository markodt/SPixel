namespace SPixel
{
    partial class GaussianSharpenForm
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
            this.filterPreview = new SPixel.FilterPreview();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.sigmaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sigmaTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filterPreview);
            this.groupBox3.Location = new System.Drawing.Point(282, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 175);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // filterPreview
            // 
            this.filterPreview.Image = null;
            this.filterPreview.Location = new System.Drawing.Point(10, 17);
            this.filterPreview.Name = "filterPreview";
            this.filterPreview.Size = new System.Drawing.Size(150, 150);
            this.filterPreview.TabIndex = 13;
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.LargeChange = 1;
            this.sizeTrackBar.Location = new System.Drawing.Point(12, 135);
            this.sizeTrackBar.Maximum = 9;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(260, 45);
            this.sizeTrackBar.TabIndex = 31;
            this.sizeTrackBar.Value = 1;
            this.sizeTrackBar.ValueChanged += new System.EventHandler(this.sizeTrackBar_ValueChanged);
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(55, 101);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(60, 20);
            this.sizeBox.TabIndex = 30;
            this.sizeBox.TextChanged += new System.EventHandler(this.sizeBox_TextChanged);
            // 
            // sigmaBox
            // 
            this.sigmaBox.Location = new System.Drawing.Point(55, 10);
            this.sigmaBox.Name = "sigmaBox";
            this.sigmaBox.Size = new System.Drawing.Size(60, 20);
            this.sigmaBox.TabIndex = 27;
            this.sigmaBox.TextChanged += new System.EventHandler(this.sigmaBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Size:";
            // 
            // sigmaTrackBar
            // 
            this.sigmaTrackBar.Location = new System.Drawing.Point(12, 44);
            this.sigmaTrackBar.Maximum = 50;
            this.sigmaTrackBar.Name = "sigmaTrackBar";
            this.sigmaTrackBar.Size = new System.Drawing.Size(260, 45);
            this.sigmaTrackBar.TabIndex = 28;
            this.sigmaTrackBar.TickFrequency = 2;
            this.sigmaTrackBar.ValueChanged += new System.EventHandler(this.sigmaTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sigma:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(233, 194);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(152, 194);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // GaussianSharpenForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(461, 229);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.sizeTrackBar);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.sigmaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sigmaTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GaussianSharpenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaussian Sharpen";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private SPixel.FilterPreview filterPreview;
        private System.Windows.Forms.TrackBar sizeTrackBar;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.TextBox sigmaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sigmaTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;

    }
}