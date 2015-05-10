namespace SPixel
{
    partial class HistogramWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.channelCombo = new System.Windows.Forms.ComboBox();
            this.logCheck = new System.Windows.Forms.CheckBox();
            this.histogram = new AForge.Controls.Histogram();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.stdDevLabel = new System.Windows.Forms.Label();
            this.medianLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.percentileLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel:";
            // 
            // channelCombo
            // 
            this.channelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelCombo.FormattingEnabled = true;
            this.channelCombo.Location = new System.Drawing.Point(68, 10);
            this.channelCombo.Name = "channelCombo";
            this.channelCombo.Size = new System.Drawing.Size(75, 21);
            this.channelCombo.TabIndex = 1;
            this.channelCombo.SelectedIndexChanged += new System.EventHandler(this.channelCombo_SelectedIndexChanged);
            // 
            // logCheck
            // 
            this.logCheck.AutoSize = true;
            this.logCheck.Location = new System.Drawing.Point(158, 14);
            this.logCheck.Name = "logCheck";
            this.logCheck.Size = new System.Drawing.Size(106, 17);
            this.logCheck.TabIndex = 2;
            this.logCheck.Text = "Logarithmic View";
            this.logCheck.UseVisualStyleBackColor = true;
            this.logCheck.CheckedChanged += new System.EventHandler(this.logCheck_CheckedChanged);
            // 
            // histogram
            // 
            this.histogram.AllowSelection = true;
            this.histogram.Location = new System.Drawing.Point(12, 37);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(260, 162);
            this.histogram.TabIndex = 3;
            this.histogram.Values = null;
            this.histogram.SelectionChanged += new AForge.Controls.HistogramEventHandler(this.histogram_SelectionChanged);
            this.histogram.PositionChanged += new AForge.Controls.HistogramEventHandler(this.histogram_PositionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mean:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Std Dev:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Median:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Percentile:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Max:";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Location = new System.Drawing.Point(68, 206);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(0, 13);
            this.meanLabel.TabIndex = 12;
            // 
            // stdDevLabel
            // 
            this.stdDevLabel.AutoSize = true;
            this.stdDevLabel.Location = new System.Drawing.Point(68, 227);
            this.stdDevLabel.Name = "stdDevLabel";
            this.stdDevLabel.Size = new System.Drawing.Size(0, 13);
            this.stdDevLabel.TabIndex = 13;
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.Location = new System.Drawing.Point(68, 249);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(0, 13);
            this.medianLabel.TabIndex = 14;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(68, 271);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(0, 13);
            this.minLabel.TabIndex = 15;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(68, 293);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(0, 13);
            this.maxLabel.TabIndex = 16;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(204, 206);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(0, 13);
            this.levelLabel.TabIndex = 17;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(204, 227);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 13);
            this.countLabel.TabIndex = 18;
            // 
            // percentileLabel
            // 
            this.percentileLabel.AutoSize = true;
            this.percentileLabel.Location = new System.Drawing.Point(204, 249);
            this.percentileLabel.Name = "percentileLabel";
            this.percentileLabel.Size = new System.Drawing.Size(0, 13);
            this.percentileLabel.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(105, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistogramWindow
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.percentileLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.medianLabel);
            this.Controls.Add(this.stdDevLabel);
            this.Controls.Add(this.meanLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.logCheck);
            this.Controls.Add(this.channelCombo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistogramWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox channelCombo;
        private System.Windows.Forms.CheckBox logCheck;
        private AForge.Controls.Histogram histogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label stdDevLabel;
        private System.Windows.Forms.Label medianLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label percentileLabel;
        private System.Windows.Forms.Button button1;
    }
}