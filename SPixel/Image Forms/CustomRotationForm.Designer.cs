namespace SPixel
{
    partial class CustomRotationForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.methodCombo = new System.Windows.Forms.ComboBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.redBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.Button();
            this.coverBox = new System.Windows.Forms.Button();
            this.keepSizeCheck = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interpolation:";
            // 
            // methodCombo
            // 
            this.methodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodCombo.FormattingEnabled = true;
            this.methodCombo.Items.AddRange(new object[] {
            "Nearest neighbour",
            "Bilinear",
            "Bicubic"});
            this.methodCombo.Location = new System.Drawing.Point(91, 33);
            this.methodCombo.Name = "methodCombo";
            this.methodCombo.Size = new System.Drawing.Size(118, 21);
            this.methodCombo.TabIndex = 2;
            // 
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(91, 6);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(70, 20);
            this.angleBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blueBox);
            this.groupBox1.Controls.Add(this.greenBox);
            this.groupBox1.Controls.Add(this.redBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.colorBox);
            this.groupBox1.Controls.Add(this.coverBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill Color";
            // 
            // blueBox
            // 
            this.blueBox.Location = new System.Drawing.Point(157, 17);
            this.blueBox.MaxLength = 3;
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(35, 20);
            this.blueBox.TabIndex = 5;
            this.blueBox.TextChanged += new System.EventHandler(this.blueBox_TextChanged);
            // 
            // greenBox
            // 
            this.greenBox.Location = new System.Drawing.Point(93, 17);
            this.greenBox.MaxLength = 3;
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(35, 20);
            this.greenBox.TabIndex = 4;
            this.greenBox.TextChanged += new System.EventHandler(this.greenBox_TextChanged);
            // 
            // redBox
            // 
            this.redBox.Location = new System.Drawing.Point(27, 17);
            this.redBox.MaxLength = 3;
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(35, 20);
            this.redBox.TabIndex = 3;
            this.redBox.TextChanged += new System.EventHandler(this.redBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "R:";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.colorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBox.Location = new System.Drawing.Point(66, 43);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(70, 20);
            this.colorBox.TabIndex = 7;
            this.toolTip.SetToolTip(this.colorBox, "Pick Color");
            this.colorBox.UseVisualStyleBackColor = false;
            this.colorBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseMove);
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
            this.colorBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseClick);
            this.colorBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseDown);
            this.colorBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorBox_MouseUp);
            // 
            // coverBox
            // 
            this.coverBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.coverBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coverBox.Location = new System.Drawing.Point(66, 43);
            this.coverBox.Name = "coverBox";
            this.coverBox.Size = new System.Drawing.Size(70, 20);
            this.coverBox.TabIndex = 8;
            this.coverBox.UseVisualStyleBackColor = false;
            // 
            // keepSizeCheck
            // 
            this.keepSizeCheck.AutoSize = true;
            this.keepSizeCheck.Location = new System.Drawing.Point(91, 68);
            this.keepSizeCheck.Name = "keepSizeCheck";
            this.keepSizeCheck.Size = new System.Drawing.Size(72, 17);
            this.keepSizeCheck.TabIndex = 5;
            this.keepSizeCheck.Text = "Keep size";
            this.keepSizeCheck.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(38, 175);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(119, 175);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // CustomRotationForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(233, 210);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.keepSizeCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.angleBox);
            this.Controls.Add(this.methodCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomRotationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Rotation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox methodCombo;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox keepSizeCheck;
        private System.Windows.Forms.TextBox blueBox;
        private System.Windows.Forms.TextBox greenBox;
        private System.Windows.Forms.TextBox redBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button colorBox;
        private System.Windows.Forms.Button coverBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}