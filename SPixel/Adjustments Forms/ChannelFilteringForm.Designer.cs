namespace SPixel
{
    partial class ChannelFilteringForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.redSlider = new AForge.Controls.ColorSlider();
            this.maxRBox = new System.Windows.Forms.TextBox();
            this.fillRBox = new System.Windows.Forms.TextBox();
            this.minRBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.greenSlider = new AForge.Controls.ColorSlider();
            this.fillGBox = new System.Windows.Forms.TextBox();
            this.maxGBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.minGBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fillBBox = new System.Windows.Forms.TextBox();
            this.blueSlider = new AForge.Controls.ColorSlider();
            this.label9 = new System.Windows.Forms.Label();
            this.maxBBox = new System.Windows.Forms.TextBox();
            this.minBBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.redFillTypeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.greenFillTypeCombo = new System.Windows.Forms.ComboBox();
            this.blueFillTypeCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.filterPreview = new SPixel.FilterPreview();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(162, 285);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(243, 285);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterPreview);
            this.groupBox1.Location = new System.Drawing.Point(298, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.redSlider);
            this.groupBox2.Controls.Add(this.maxRBox);
            this.groupBox2.Controls.Add(this.fillRBox);
            this.groupBox2.Controls.Add(this.minRBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Red";
            // 
            // redSlider
            // 
            this.redSlider.EndColor = System.Drawing.Color.Red;
            this.redSlider.Location = new System.Drawing.Point(9, 43);
            this.redSlider.Name = "redSlider";
            this.redSlider.Size = new System.Drawing.Size(262, 23);
            this.redSlider.TabIndex = 4;
            this.redSlider.TabStop = false;
            this.redSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.redSlider.ValuesChanged += new System.EventHandler(this.redSlider_ValuesChanged);
            // 
            // maxRBox
            // 
            this.maxRBox.Location = new System.Drawing.Point(132, 17);
            this.maxRBox.Name = "maxRBox";
            this.maxRBox.Size = new System.Drawing.Size(50, 20);
            this.maxRBox.TabIndex = 3;
            this.maxRBox.TextChanged += new System.EventHandler(this.maxRBox_TextChanged);
            // 
            // fillRBox
            // 
            this.fillRBox.Location = new System.Drawing.Point(219, 17);
            this.fillRBox.Name = "fillRBox";
            this.fillRBox.Size = new System.Drawing.Size(50, 20);
            this.fillRBox.TabIndex = 3;
            this.fillRBox.TextChanged += new System.EventHandler(this.fillRBox_TextChanged);
            // 
            // minRBox
            // 
            this.minRBox.Location = new System.Drawing.Point(39, 17);
            this.minRBox.Name = "minRBox";
            this.minRBox.Size = new System.Drawing.Size(50, 20);
            this.minRBox.TabIndex = 2;
            this.minRBox.TextChanged += new System.EventHandler(this.minRBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fill:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.greenSlider);
            this.groupBox3.Controls.Add(this.fillGBox);
            this.groupBox3.Controls.Add(this.maxGBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.minGBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 75);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Green";
            // 
            // greenSlider
            // 
            this.greenSlider.EndColor = System.Drawing.Color.Lime;
            this.greenSlider.Location = new System.Drawing.Point(9, 43);
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Size = new System.Drawing.Size(262, 23);
            this.greenSlider.TabIndex = 5;
            this.greenSlider.TabStop = false;
            this.greenSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.greenSlider.ValuesChanged += new System.EventHandler(this.greenSlider_ValuesChanged);
            // 
            // fillGBox
            // 
            this.fillGBox.Location = new System.Drawing.Point(219, 17);
            this.fillGBox.Name = "fillGBox";
            this.fillGBox.Size = new System.Drawing.Size(50, 20);
            this.fillGBox.TabIndex = 4;
            this.fillGBox.TextChanged += new System.EventHandler(this.fillGBox_TextChanged);
            // 
            // maxGBox
            // 
            this.maxGBox.Location = new System.Drawing.Point(132, 17);
            this.maxGBox.Name = "maxGBox";
            this.maxGBox.Size = new System.Drawing.Size(50, 20);
            this.maxGBox.TabIndex = 3;
            this.maxGBox.TextChanged += new System.EventHandler(this.maxGBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fill:";
            // 
            // minGBox
            // 
            this.minGBox.Location = new System.Drawing.Point(39, 17);
            this.minGBox.Name = "minGBox";
            this.minGBox.Size = new System.Drawing.Size(50, 20);
            this.minGBox.TabIndex = 2;
            this.minGBox.TextChanged += new System.EventHandler(this.minGBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Min:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fillBBox);
            this.groupBox4.Controls.Add(this.blueSlider);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.maxBBox);
            this.groupBox4.Controls.Add(this.minBBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 75);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Blue";
            // 
            // fillBBox
            // 
            this.fillBBox.Location = new System.Drawing.Point(219, 17);
            this.fillBBox.Name = "fillBBox";
            this.fillBBox.Size = new System.Drawing.Size(50, 20);
            this.fillBBox.TabIndex = 5;
            this.fillBBox.TextChanged += new System.EventHandler(this.fillBBox_TextChanged);
            // 
            // blueSlider
            // 
            this.blueSlider.EndColor = System.Drawing.Color.Blue;
            this.blueSlider.Location = new System.Drawing.Point(9, 43);
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Size = new System.Drawing.Size(262, 23);
            this.blueSlider.TabIndex = 6;
            this.blueSlider.TabStop = false;
            this.blueSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.blueSlider.ValuesChanged += new System.EventHandler(this.blueSlider_ValuesChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fill:";
            // 
            // maxBBox
            // 
            this.maxBBox.Location = new System.Drawing.Point(132, 17);
            this.maxBBox.Name = "maxBBox";
            this.maxBBox.Size = new System.Drawing.Size(50, 20);
            this.maxBBox.TabIndex = 3;
            this.maxBBox.TextChanged += new System.EventHandler(this.maxBBox_TextChanged);
            // 
            // minBBox
            // 
            this.minBBox.Location = new System.Drawing.Point(39, 17);
            this.minBBox.Name = "minBBox";
            this.minBBox.Size = new System.Drawing.Size(50, 20);
            this.minBBox.TabIndex = 2;
            this.minBBox.TextChanged += new System.EventHandler(this.minBBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Min:";
            // 
            // redFillTypeCombo
            // 
            this.redFillTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.redFillTypeCombo.FormattingEnabled = true;
            this.redFillTypeCombo.Items.AddRange(new object[] {
            "Outside",
            "Inside"});
            this.redFillTypeCombo.Location = new System.Drawing.Point(388, 193);
            this.redFillTypeCombo.Name = "redFillTypeCombo";
            this.redFillTypeCombo.Size = new System.Drawing.Size(80, 21);
            this.redFillTypeCombo.TabIndex = 7;
            this.redFillTypeCombo.SelectedIndexChanged += new System.EventHandler(this.redFillTypeCombo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Red Fill Type:";
            // 
            // greenFillTypeCombo
            // 
            this.greenFillTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.greenFillTypeCombo.FormattingEnabled = true;
            this.greenFillTypeCombo.Items.AddRange(new object[] {
            "Outside",
            "Inside"});
            this.greenFillTypeCombo.Location = new System.Drawing.Point(388, 220);
            this.greenFillTypeCombo.Name = "greenFillTypeCombo";
            this.greenFillTypeCombo.Size = new System.Drawing.Size(80, 21);
            this.greenFillTypeCombo.TabIndex = 9;
            this.greenFillTypeCombo.SelectedIndexChanged += new System.EventHandler(this.greenFillTypeCombo_SelectedIndexChanged);
            // 
            // blueFillTypeCombo
            // 
            this.blueFillTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blueFillTypeCombo.FormattingEnabled = true;
            this.blueFillTypeCombo.Items.AddRange(new object[] {
            "Outside",
            "Inside"});
            this.blueFillTypeCombo.Location = new System.Drawing.Point(388, 247);
            this.blueFillTypeCombo.Name = "blueFillTypeCombo";
            this.blueFillTypeCombo.Size = new System.Drawing.Size(80, 21);
            this.blueFillTypeCombo.TabIndex = 10;
            this.blueFillTypeCombo.SelectedIndexChanged += new System.EventHandler(this.blueFillTypeCombo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Blue Fill Type:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Green Fill Type:";
            // 
            // filterPreview
            // 
            this.filterPreview.Image = null;
            this.filterPreview.Location = new System.Drawing.Point(10, 17);
            this.filterPreview.Name = "filterPreview";
            this.filterPreview.Size = new System.Drawing.Size(150, 150);
            this.filterPreview.TabIndex = 0;
            this.filterPreview.Text = "filterPreview1";
            // 
            // ChannelFilteringForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.blueFillTypeCombo);
            this.Controls.Add(this.greenFillTypeCombo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.redFillTypeCombo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChannelFilteringForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Channels Filtering";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private SPixel.FilterPreview filterPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox maxRBox;
        private System.Windows.Forms.TextBox minRBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxGBox;
        private System.Windows.Forms.TextBox minGBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxBBox;
        private System.Windows.Forms.TextBox minBBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fillBBox;
        private System.Windows.Forms.TextBox fillGBox;
        private System.Windows.Forms.TextBox fillRBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private AForge.Controls.ColorSlider redSlider;
        private AForge.Controls.ColorSlider greenSlider;
        private AForge.Controls.ColorSlider blueSlider;
        private System.Windows.Forms.ComboBox redFillTypeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox greenFillTypeCombo;
        private System.Windows.Forms.ComboBox blueFillTypeCombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

    }
}