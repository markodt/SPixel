namespace SPixel
{
    partial class ShrinkForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.redBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.Button();
            this.coverBox = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(139, 156);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(58, 156);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 23;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colorBox);
            this.groupBox1.Controls.Add(this.coverBox);
            this.groupBox1.Controls.Add(this.blueBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.greenBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.redBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 130);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color to remove";
            // 
            // blueBox
            // 
            this.blueBox.Location = new System.Drawing.Point(190, 20);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(50, 20);
            this.blueBox.TabIndex = 5;
            this.blueBox.TextChanged += new System.EventHandler(this.blueBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(170, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "B:";
            // 
            // greenBox
            // 
            this.greenBox.Location = new System.Drawing.Point(110, 20);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(50, 20);
            this.greenBox.TabIndex = 3;
            this.greenBox.TextChanged += new System.EventHandler(this.greenBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(90, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "G:";
            // 
            // redBox
            // 
            this.redBox.Location = new System.Drawing.Point(30, 20);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(50, 20);
            this.redBox.TabIndex = 1;
            this.redBox.TextChanged += new System.EventHandler(this.redBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "R:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "The image will be shrinked by removing pixels with specified color from it\'s bord" +
                "ers.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.colorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBox.Location = new System.Drawing.Point(90, 51);
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
            this.coverBox.Location = new System.Drawing.Point(90, 51);
            this.coverBox.Name = "coverBox";
            this.coverBox.Size = new System.Drawing.Size(70, 20);
            this.coverBox.TabIndex = 10;
            this.coverBox.UseVisualStyleBackColor = false;
            // 
            // ShrinkForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(272, 191);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShrinkForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shrink Image";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox blueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox greenBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox redBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button colorBox;
        private System.Windows.Forms.Button coverBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}