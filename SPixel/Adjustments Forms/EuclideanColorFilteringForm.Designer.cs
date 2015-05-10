namespace SPixel
{
    partial class EuclideanColorFilteringForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterPreview = new SPixel.FilterPreview();
            this.redSlider = new AForge.Controls.ColorSlider();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.radiusTrackBar = new System.Windows.Forms.TrackBar();
            this.greenSlider = new AForge.Controls.ColorSlider();
            this.blueSlider = new AForge.Controls.ColorSlider();
            this.fillTypeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.redBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fillBBox = new System.Windows.Forms.TextBox();
            this.fillGBox = new System.Windows.Forms.TextBox();
            this.fillRBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.Button();
            this.coverBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(308, 306);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(389, 306);
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
            // filterPreview
            // 
            this.filterPreview.Image = null;
            this.filterPreview.Location = new System.Drawing.Point(10, 17);
            this.filterPreview.Name = "filterPreview";
            this.filterPreview.Size = new System.Drawing.Size(150, 150);
            this.filterPreview.TabIndex = 0;
            this.filterPreview.Text = "filterPreview1";
            // 
            // redSlider
            // 
            this.redSlider.DoubleArrow = false;
            this.redSlider.EndColor = System.Drawing.Color.Red;
            this.redSlider.Location = new System.Drawing.Point(9, 49);
            this.redSlider.Name = "redSlider";
            this.redSlider.Size = new System.Drawing.Size(262, 23);
            this.redSlider.TabIndex = 4;
            this.redSlider.TabStop = false;
            this.redSlider.ValuesChanged += new System.EventHandler(this.redSlider_ValuesChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radiusBox);
            this.groupBox3.Controls.Add(this.radiusTrackBar);
            this.groupBox3.Location = new System.Drawing.Point(12, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 108);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Radius";
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(13, 26);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(50, 20);
            this.radiusBox.TabIndex = 1;
            this.radiusBox.TextChanged += new System.EventHandler(this.radiusBox_TextChanged);
            // 
            // radiusTrackBar
            // 
            this.radiusTrackBar.Location = new System.Drawing.Point(6, 59);
            this.radiusTrackBar.Maximum = 450;
            this.radiusTrackBar.Minimum = 1;
            this.radiusTrackBar.Name = "radiusTrackBar";
            this.radiusTrackBar.Size = new System.Drawing.Size(268, 45);
            this.radiusTrackBar.TabIndex = 0;
            this.radiusTrackBar.TickFrequency = 10;
            this.radiusTrackBar.Value = 100;
            this.radiusTrackBar.Scroll += new System.EventHandler(this.radiusTrackBar_Scroll);
            // 
            // greenSlider
            // 
            this.greenSlider.DoubleArrow = false;
            this.greenSlider.EndColor = System.Drawing.Color.Lime;
            this.greenSlider.Location = new System.Drawing.Point(9, 71);
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Size = new System.Drawing.Size(262, 23);
            this.greenSlider.TabIndex = 5;
            this.greenSlider.TabStop = false;
            this.greenSlider.ValuesChanged += new System.EventHandler(this.greenSlider_ValuesChanged);
            // 
            // blueSlider
            // 
            this.blueSlider.DoubleArrow = false;
            this.blueSlider.EndColor = System.Drawing.Color.Blue;
            this.blueSlider.Location = new System.Drawing.Point(9, 92);
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Size = new System.Drawing.Size(262, 23);
            this.blueSlider.TabIndex = 6;
            this.blueSlider.TabStop = false;
            this.blueSlider.ValuesChanged += new System.EventHandler(this.blueSlider_ValuesChanged);
            // 
            // fillTypeCombo
            // 
            this.fillTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillTypeCombo.FormattingEnabled = true;
            this.fillTypeCombo.Items.AddRange(new object[] {
            "Outside",
            "Inside"});
            this.fillTypeCombo.Location = new System.Drawing.Point(360, 214);
            this.fillTypeCombo.Name = "fillTypeCombo";
            this.fillTypeCombo.Size = new System.Drawing.Size(112, 21);
            this.fillTypeCombo.TabIndex = 7;
            this.fillTypeCombo.SelectedIndexChanged += new System.EventHandler(this.fillTypeCombo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Fill Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.blueBox);
            this.groupBox2.Controls.Add(this.blueSlider);
            this.groupBox2.Controls.Add(this.redSlider);
            this.groupBox2.Controls.Add(this.greenBox);
            this.groupBox2.Controls.Add(this.greenSlider);
            this.groupBox2.Controls.Add(this.redBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 123);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Center Color";
            // 
            // blueBox
            // 
            this.blueBox.Location = new System.Drawing.Point(219, 20);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(50, 20);
            this.blueBox.TabIndex = 5;
            this.blueBox.TextChanged += new System.EventHandler(this.blueBox_TextChanged);
            // 
            // greenBox
            // 
            this.greenBox.Location = new System.Drawing.Point(128, 20);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(50, 20);
            this.greenBox.TabIndex = 4;
            this.greenBox.TextChanged += new System.EventHandler(this.greenBox_TextChanged);
            // 
            // redBox
            // 
            this.redBox.Location = new System.Drawing.Point(34, 20);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(50, 20);
            this.redBox.TabIndex = 3;
            this.redBox.TextChanged += new System.EventHandler(this.redBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "R:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fillBBox);
            this.groupBox5.Controls.Add(this.fillGBox);
            this.groupBox5.Controls.Add(this.fillRBox);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.colorBox);
            this.groupBox5.Controls.Add(this.coverBox);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(12, 255);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(280, 79);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fill Color";
            // 
            // fillBBox
            // 
            this.fillBBox.Location = new System.Drawing.Point(219, 20);
            this.fillBBox.Name = "fillBBox";
            this.fillBBox.Size = new System.Drawing.Size(50, 20);
            this.fillBBox.TabIndex = 5;
            this.fillBBox.TextChanged += new System.EventHandler(this.fillBox_TextChanged);
            // 
            // fillGBox
            // 
            this.fillGBox.Location = new System.Drawing.Point(127, 20);
            this.fillGBox.Name = "fillGBox";
            this.fillGBox.Size = new System.Drawing.Size(50, 20);
            this.fillGBox.TabIndex = 4;
            this.fillGBox.TextChanged += new System.EventHandler(this.fillBox_TextChanged);
            // 
            // fillRBox
            // 
            this.fillRBox.Location = new System.Drawing.Point(34, 20);
            this.fillRBox.Name = "fillRBox";
            this.fillRBox.Size = new System.Drawing.Size(50, 20);
            this.fillRBox.TabIndex = 3;
            this.fillRBox.TextChanged += new System.EventHandler(this.fillBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "B:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "G:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "R:";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.colorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBox.Location = new System.Drawing.Point(105, 49);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(70, 20);
            this.colorBox.TabIndex = 9;
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
            this.coverBox.Location = new System.Drawing.Point(105, 49);
            this.coverBox.Name = "coverBox";
            this.coverBox.Size = new System.Drawing.Size(70, 20);
            this.coverBox.TabIndex = 10;
            this.coverBox.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(105, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EuclideanColorFilteringForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(480, 341);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fillTypeCombo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EuclideanColorFilteringForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Euclidean Color Filtering";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private SPixel.FilterPreview filterPreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private AForge.Controls.ColorSlider redSlider;
        private AForge.Controls.ColorSlider greenSlider;
        private AForge.Controls.ColorSlider blueSlider;
        private System.Windows.Forms.ComboBox fillTypeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox blueBox;
        private System.Windows.Forms.TextBox greenBox;
        private System.Windows.Forms.TextBox redBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar radiusTrackBar;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox fillBBox;
        private System.Windows.Forms.TextBox fillGBox;
        private System.Windows.Forms.TextBox fillRBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button colorBox;
        private System.Windows.Forms.Button coverBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip;

    }
}