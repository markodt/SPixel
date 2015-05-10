namespace SPixel
{
    partial class ResizeForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.methodCombo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.factorButton = new System.Windows.Forms.RadioButton();
            this.factorBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sizeButton = new System.Windows.Forms.RadioButton();
            this.ratioCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.resizeTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(35, 265);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(116, 265);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interpolation:";
            // 
            // methodCombo
            // 
            this.methodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodCombo.FormattingEnabled = true;
            this.methodCombo.Items.AddRange(new object[] {
            "Nearest neighbour",
            "Bilinear",
            "Bicubic"});
            this.methodCombo.Location = new System.Drawing.Point(94, 225);
            this.methodCombo.Name = "methodCombo";
            this.methodCombo.Size = new System.Drawing.Size(121, 21);
            this.methodCombo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 2);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // factorButton
            // 
            this.factorButton.AutoSize = true;
            this.factorButton.Checked = true;
            this.factorButton.Location = new System.Drawing.Point(11, 13);
            this.factorButton.Name = "factorButton";
            this.factorButton.Size = new System.Drawing.Size(90, 17);
            this.factorButton.TabIndex = 5;
            this.factorButton.TabStop = true;
            this.factorButton.Text = "Resize factor:";
            this.factorButton.UseVisualStyleBackColor = true;
            this.factorButton.CheckedChanged += new System.EventHandler(this.factorButton_CheckedChanged);
            // 
            // factorBox
            // 
            this.factorBox.Location = new System.Drawing.Point(112, 12);
            this.factorBox.Name = "factorBox";
            this.factorBox.Size = new System.Drawing.Size(100, 20);
            this.factorBox.TabIndex = 6;
            this.factorBox.TextChanged += new System.EventHandler(this.factorBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(11, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 2);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // sizeButton
            // 
            this.sizeButton.AutoSize = true;
            this.sizeButton.Location = new System.Drawing.Point(11, 90);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(163, 17);
            this.sizeButton.TabIndex = 8;
            this.sizeButton.TabStop = true;
            this.sizeButton.Text = "Resize to specific dimensions";
            this.sizeButton.UseVisualStyleBackColor = true;
            this.sizeButton.CheckedChanged += new System.EventHandler(this.sizeButton_CheckedChanged);
            // 
            // ratioCheck
            // 
            this.ratioCheck.AutoSize = true;
            this.ratioCheck.Checked = true;
            this.ratioCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ratioCheck.Enabled = false;
            this.ratioCheck.Location = new System.Drawing.Point(50, 182);
            this.ratioCheck.Name = "ratioCheck";
            this.ratioCheck.Size = new System.Drawing.Size(109, 17);
            this.ratioCheck.TabIndex = 9;
            this.ratioCheck.Text = "Keep aspect ratio";
            this.ratioCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Height:";
            // 
            // widthBox
            // 
            this.widthBox.Enabled = false;
            this.widthBox.Location = new System.Drawing.Point(112, 118);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 12;
            this.widthBox.TextChanged += new System.EventHandler(this.widthBox_TextChanged);
            // 
            // heightBox
            // 
            this.heightBox.Enabled = false;
            this.heightBox.Location = new System.Drawing.Point(112, 148);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 13;
            this.heightBox.TextChanged += new System.EventHandler(this.heightBox_TextChanged);
            // 
            // resizeTrackBar
            // 
            this.resizeTrackBar.Location = new System.Drawing.Point(11, 38);
            this.resizeTrackBar.Maximum = 500;
            this.resizeTrackBar.Minimum = 1;
            this.resizeTrackBar.Name = "resizeTrackBar";
            this.resizeTrackBar.Size = new System.Drawing.Size(204, 45);
            this.resizeTrackBar.TabIndex = 14;
            this.resizeTrackBar.TickFrequency = 25;
            this.resizeTrackBar.Value = 200;
            this.resizeTrackBar.ValueChanged += new System.EventHandler(this.resizeTrackBar_ValueChanged);
            // 
            // ResizeForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(227, 300);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ratioCheck);
            this.Controls.Add(this.sizeButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.factorBox);
            this.Controls.Add(this.factorButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.methodCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.resizeTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResizeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resize Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox methodCombo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton factorButton;
        private System.Windows.Forms.TextBox factorBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton sizeButton;
        private System.Windows.Forms.CheckBox ratioCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TrackBar resizeTrackBar;
    }
}