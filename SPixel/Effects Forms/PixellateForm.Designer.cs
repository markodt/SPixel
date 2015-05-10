namespace SPixel
{
    partial class PixellateForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.syncCheck = new System.Windows.Forms.CheckBox();
            this.heightTrackBar = new System.Windows.Forms.TrackBar();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new SPixel.FilterPreview();
            this.widthTrackBar = new System.Windows.Forms.TrackBar();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(207, 196);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(126, 196);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 21;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // syncCheck
            // 
            this.syncCheck.Checked = true;
            this.syncCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.syncCheck.Location = new System.Drawing.Point(155, 13);
            this.syncCheck.Name = "syncCheck";
            this.syncCheck.Size = new System.Drawing.Size(55, 24);
            this.syncCheck.TabIndex = 30;
            this.syncCheck.Text = "Sync";
            // 
            // heightTrackBar
            // 
            this.heightTrackBar.Location = new System.Drawing.Point(10, 122);
            this.heightTrackBar.Maximum = 32;
            this.heightTrackBar.Minimum = 2;
            this.heightTrackBar.Name = "heightTrackBar";
            this.heightTrackBar.Size = new System.Drawing.Size(200, 45);
            this.heightTrackBar.TabIndex = 29;
            this.heightTrackBar.Value = 2;
            this.heightTrackBar.Scroll += new System.EventHandler(this.heightTrackBar_Scroll);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(80, 95);
            this.heightBox.Name = "heightBox";
            this.heightBox.ReadOnly = true;
            this.heightBox.Size = new System.Drawing.Size(50, 20);
            this.heightBox.TabIndex = 28;
            this.heightBox.TabStop = false;
            this.heightBox.TextChanged += new System.EventHandler(this.heightBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Pixel Height:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterPreview);
            this.groupBox1.Location = new System.Drawing.Point(230, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 175);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // filterPreview
            // 
            this.filterPreview.Image = null;
            this.filterPreview.Location = new System.Drawing.Point(10, 17);
            this.filterPreview.Name = "filterPreview";
            this.filterPreview.Size = new System.Drawing.Size(150, 150);
            this.filterPreview.TabIndex = 0;
            this.filterPreview.TabStop = false;
            // 
            // widthTrackBar
            // 
            this.widthTrackBar.Location = new System.Drawing.Point(10, 42);
            this.widthTrackBar.Maximum = 32;
            this.widthTrackBar.Minimum = 2;
            this.widthTrackBar.Name = "widthTrackBar";
            this.widthTrackBar.Size = new System.Drawing.Size(200, 45);
            this.widthTrackBar.TabIndex = 25;
            this.widthTrackBar.Value = 2;
            this.widthTrackBar.Scroll += new System.EventHandler(this.widthTrackBar_Scroll);
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(80, 15);
            this.widthBox.Name = "widthBox";
            this.widthBox.ReadOnly = true;
            this.widthBox.Size = new System.Drawing.Size(50, 20);
            this.widthBox.TabIndex = 24;
            this.widthBox.TabStop = false;
            this.widthBox.TextChanged += new System.EventHandler(this.widthBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pixel Width:";
            // 
            // PixellateForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(409, 231);
            this.Controls.Add(this.syncCheck);
            this.Controls.Add(this.heightTrackBar);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.widthTrackBar);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PixellateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixellate";
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox syncCheck;
        private System.Windows.Forms.TrackBar heightTrackBar;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private SPixel.FilterPreview filterPreview;
        private System.Windows.Forms.TrackBar widthTrackBar;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label1;
    }
}