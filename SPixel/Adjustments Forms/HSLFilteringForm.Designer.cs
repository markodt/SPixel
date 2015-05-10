namespace SPixel
{
    partial class HSLFilteringForm
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
            this.fillTypeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.updateLCheck = new System.Windows.Forms.CheckBox();
            this.fillLBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateSCheck = new System.Windows.Forms.CheckBox();
            this.fillSBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateHCheck = new System.Windows.Forms.CheckBox();
            this.fillHBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new SPixel.FilterPreview();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxLBox = new System.Windows.Forms.TextBox();
            this.minLBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxSBox = new System.Windows.Forms.TextBox();
            this.minSBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxHBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minHBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.huePicker = new SPixel.HuePicker();
            this.saturationSlider = new AForge.Controls.ColorSlider();
            this.luminanceSlider = new AForge.Controls.ColorSlider();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillTypeCombo
            // 
            this.fillTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillTypeCombo.Items.AddRange(new object[] {
            "Outside",
            "Inside"});
            this.fillTypeCombo.Location = new System.Drawing.Point(370, 300);
            this.fillTypeCombo.Name = "fillTypeCombo";
            this.fillTypeCombo.Size = new System.Drawing.Size(100, 21);
            this.fillTypeCombo.TabIndex = 19;
            this.fillTypeCombo.SelectedIndexChanged += new System.EventHandler(this.fillTypeCombo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(314, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fill Type:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.updateLCheck);
            this.groupBox4.Controls.Add(this.fillLBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.updateSCheck);
            this.groupBox4.Controls.Add(this.fillSBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.updateHCheck);
            this.groupBox4.Controls.Add(this.fillHBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(300, 190);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 100);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fill Color";
            // 
            // updateLCheck
            // 
            this.updateLCheck.Checked = true;
            this.updateLCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updateLCheck.Location = new System.Drawing.Point(125, 68);
            this.updateLCheck.Name = "updateLCheck";
            this.updateLCheck.Size = new System.Drawing.Size(14, 24);
            this.updateLCheck.TabIndex = 8;
            this.updateLCheck.CheckedChanged += new System.EventHandler(this.updateLCheck_CheckedChanged);
            // 
            // fillLBox
            // 
            this.fillLBox.Location = new System.Drawing.Point(40, 70);
            this.fillLBox.Name = "fillLBox";
            this.fillLBox.Size = new System.Drawing.Size(50, 20);
            this.fillLBox.TabIndex = 7;
            this.fillLBox.TextChanged += new System.EventHandler(this.fillLBox_TextChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(14, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "L:";
            // 
            // updateSCheck
            // 
            this.updateSCheck.Checked = true;
            this.updateSCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updateSCheck.Location = new System.Drawing.Point(125, 43);
            this.updateSCheck.Name = "updateSCheck";
            this.updateSCheck.Size = new System.Drawing.Size(14, 24);
            this.updateSCheck.TabIndex = 5;
            this.updateSCheck.CheckedChanged += new System.EventHandler(this.updateSCheck_CheckedChanged);
            // 
            // fillSBox
            // 
            this.fillSBox.Location = new System.Drawing.Point(40, 45);
            this.fillSBox.Name = "fillSBox";
            this.fillSBox.Size = new System.Drawing.Size(50, 20);
            this.fillSBox.TabIndex = 4;
            this.fillSBox.TextChanged += new System.EventHandler(this.fillSBox_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "S:";
            // 
            // updateHCheck
            // 
            this.updateHCheck.Checked = true;
            this.updateHCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updateHCheck.Location = new System.Drawing.Point(125, 18);
            this.updateHCheck.Name = "updateHCheck";
            this.updateHCheck.Size = new System.Drawing.Size(14, 24);
            this.updateHCheck.TabIndex = 2;
            this.updateHCheck.CheckedChanged += new System.EventHandler(this.updateHCheck_CheckedChanged);
            // 
            // fillHBox
            // 
            this.fillHBox.Location = new System.Drawing.Point(40, 20);
            this.fillHBox.Name = "fillHBox";
            this.fillHBox.Size = new System.Drawing.Size(50, 20);
            this.fillHBox.TabIndex = 1;
            this.fillHBox.TextChanged += new System.EventHandler(this.fillHBox_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "H:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.filterPreview);
            this.groupBox5.Location = new System.Drawing.Point(300, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(170, 175);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Preview";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.luminanceSlider);
            this.groupBox3.Controls.Add(this.maxLBox);
            this.groupBox3.Controls.Add(this.minLBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(10, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 75);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Luminance";
            // 
            // maxLBox
            // 
            this.maxLBox.Location = new System.Drawing.Point(218, 20);
            this.maxLBox.Name = "maxLBox";
            this.maxLBox.Size = new System.Drawing.Size(50, 20);
            this.maxLBox.TabIndex = 8;
            this.maxLBox.TextChanged += new System.EventHandler(this.maxLBox_TextChanged);
            // 
            // minLBox
            // 
            this.minLBox.Location = new System.Drawing.Point(46, 20);
            this.minLBox.Name = "minLBox";
            this.minLBox.Size = new System.Drawing.Size(50, 20);
            this.minLBox.TabIndex = 7;
            this.minLBox.TextChanged += new System.EventHandler(this.minLBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(179, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Min:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saturationSlider);
            this.groupBox2.Controls.Add(this.maxSBox);
            this.groupBox2.Controls.Add(this.minSBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(10, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 75);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saturation";
            // 
            // maxSBox
            // 
            this.maxSBox.Location = new System.Drawing.Point(218, 20);
            this.maxSBox.Name = "maxSBox";
            this.maxSBox.Size = new System.Drawing.Size(50, 20);
            this.maxSBox.TabIndex = 3;
            this.maxSBox.TextChanged += new System.EventHandler(this.maxSBox_TextChanged);
            // 
            // minSBox
            // 
            this.minSBox.Location = new System.Drawing.Point(46, 20);
            this.minSBox.Name = "minSBox";
            this.minSBox.Size = new System.Drawing.Size(50, 20);
            this.minSBox.TabIndex = 2;
            this.minSBox.TextChanged += new System.EventHandler(this.minSBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(179, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Max:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Min:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxHBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.minHBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.huePicker);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 230);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hue";
            // 
            // maxHBox
            // 
            this.maxHBox.Location = new System.Drawing.Point(218, 19);
            this.maxHBox.Name = "maxHBox";
            this.maxHBox.Size = new System.Drawing.Size(50, 20);
            this.maxHBox.TabIndex = 4;
            this.maxHBox.TextChanged += new System.EventHandler(this.maxHBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(179, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max:";
            // 
            // minHBox
            // 
            this.minHBox.Location = new System.Drawing.Point(46, 20);
            this.minHBox.Name = "minHBox";
            this.minHBox.Size = new System.Drawing.Size(50, 20);
            this.minHBox.TabIndex = 2;
            this.minHBox.TextChanged += new System.EventHandler(this.minHBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min:";
            // 
            // huePicker
            // 
            this.huePicker.Location = new System.Drawing.Point(55, 50);
            this.huePicker.Name = "huePicker";
            this.huePicker.Size = new System.Drawing.Size(170, 170);
            this.huePicker.TabIndex = 0;
            this.huePicker.Type = SPixel.HuePickerType.Region;
            this.huePicker.ValuesChanged += new System.EventHandler(this.huePicker_ValuesChanged);
            // 
            // saturationSlider
            // 
            this.saturationSlider.Location = new System.Drawing.Point(9, 46);
            this.saturationSlider.Name = "saturationSlider";
            this.saturationSlider.Size = new System.Drawing.Size(262, 23);
            this.saturationSlider.TabIndex = 4;
            this.saturationSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.saturationSlider.ValuesChanged += new System.EventHandler(this.saturationSlider_ValuesChanged);
            // 
            // luminanceSlider
            // 
            this.luminanceSlider.Location = new System.Drawing.Point(9, 46);
            this.luminanceSlider.Name = "luminanceSlider";
            this.luminanceSlider.Size = new System.Drawing.Size(262, 23);
            this.luminanceSlider.TabIndex = 9;
            this.luminanceSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.luminanceSlider.ValuesChanged += new System.EventHandler(this.luminanceSlider_ValuesChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(391, 373);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(310, 373);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 21;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // HSLFilteringForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(479, 408);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fillTypeCombo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HSLFilteringForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSL Filtering";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox fillTypeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox updateLCheck;
        private System.Windows.Forms.TextBox fillLBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox updateSCheck;
        private System.Windows.Forms.TextBox fillSBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox updateHCheck;
        private System.Windows.Forms.TextBox fillHBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private SPixel.FilterPreview filterPreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox maxLBox;
        private System.Windows.Forms.TextBox minLBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox maxSBox;
        private System.Windows.Forms.TextBox minSBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maxHBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minHBox;
        private System.Windows.Forms.Label label1;
        private SPixel.HuePicker huePicker;
        private AForge.Controls.ColorSlider luminanceSlider;
        private AForge.Controls.ColorSlider saturationSlider;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}