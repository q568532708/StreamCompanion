﻿namespace LiveVisualizer
{
    partial class LiveVisualizerSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_enable = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_enableWindowRezising = new System.Windows.Forms.CheckBox();
            this.numericUpDown_windowHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_windowWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_UICredit2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel_UICredit1 = new System.Windows.Forms.LinkLabel();
            this.color_horizontalLegend = new LiveVisualizer.ColorPickerWithPreview();
            this.checkBox_showAxisYSeparator = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_font = new System.Windows.Forms.ComboBox();
            this.panel_manualChart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_chartCutoffs = new System.Windows.Forms.TextBox();
            this.checkBox_autosizeChart = new System.Windows.Forms.CheckBox();
            this.color_chartProgress = new LiveVisualizer.ColorPickerWithPreview();
            this.color_chartPrimary = new LiveVisualizer.ColorPickerWithPreview();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_windowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_windowWidth)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_manualChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_enable
            // 
            this.checkBox_enable.AutoSize = true;
            this.checkBox_enable.Location = new System.Drawing.Point(4, 4);
            this.checkBox_enable.Name = "checkBox_enable";
            this.checkBox_enable.Size = new System.Drawing.Size(129, 17);
            this.checkBox_enable.TabIndex = 0;
            this.checkBox_enable.Text = "Enable Live Visualizer";
            this.checkBox_enable.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox_enableWindowRezising);
            this.panel1.Controls.Add(this.numericUpDown_windowHeight);
            this.panel1.Controls.Add(this.numericUpDown_windowWidth);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.color_horizontalLegend);
            this.panel1.Controls.Add(this.checkBox_showAxisYSeparator);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_font);
            this.panel1.Controls.Add(this.panel_manualChart);
            this.panel1.Controls.Add(this.checkBox_autosizeChart);
            this.panel1.Controls.Add(this.color_chartProgress);
            this.panel1.Controls.Add(this.color_chartPrimary);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 394);
            this.panel1.TabIndex = 1;
            // 
            // checkBox_enableWindowRezising
            // 
            this.checkBox_enableWindowRezising.AutoSize = true;
            this.checkBox_enableWindowRezising.Location = new System.Drawing.Point(288, 194);
            this.checkBox_enableWindowRezising.Name = "checkBox_enableWindowRezising";
            this.checkBox_enableWindowRezising.Size = new System.Drawing.Size(173, 17);
            this.checkBox_enableWindowRezising.TabIndex = 38;
            this.checkBox_enableWindowRezising.Text = "Enable manual window resizing";
            this.checkBox_enableWindowRezising.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_windowHeight
            // 
            this.numericUpDown_windowHeight.Location = new System.Drawing.Point(216, 192);
            this.numericUpDown_windowHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_windowHeight.Minimum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.numericUpDown_windowHeight.Name = "numericUpDown_windowHeight";
            this.numericUpDown_windowHeight.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_windowHeight.TabIndex = 37;
            this.numericUpDown_windowHeight.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // numericUpDown_windowWidth
            // 
            this.numericUpDown_windowWidth.Location = new System.Drawing.Point(144, 192);
            this.numericUpDown_windowWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_windowWidth.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_windowWidth.Name = "numericUpDown_windowWidth";
            this.numericUpDown_windowWidth.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_windowWidth.TabIndex = 36;
            this.numericUpDown_windowWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Window width and height:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.linkLabel_UICredit2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.linkLabel_UICredit1);
            this.panel2.Location = new System.Drawing.Point(4, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 18);
            this.panel2.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Initial UI design made by";
            // 
            // linkLabel_UICredit2
            // 
            this.linkLabel_UICredit2.AutoSize = true;
            this.linkLabel_UICredit2.Location = new System.Drawing.Point(215, 0);
            this.linkLabel_UICredit2.Name = "linkLabel_UICredit2";
            this.linkLabel_UICredit2.Size = new System.Drawing.Size(48, 13);
            this.linkLabel_UICredit2.TabIndex = 31;
            this.linkLabel_UICredit2.TabStop = true;
            this.linkLabel_UICredit2.Text = "Dartandr";
            this.linkLabel_UICredit2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_UICredit2_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "and";
            // 
            // linkLabel_UICredit1
            // 
            this.linkLabel_UICredit1.AutoSize = true;
            this.linkLabel_UICredit1.Location = new System.Drawing.Point(126, 0);
            this.linkLabel_UICredit1.Name = "linkLabel_UICredit1";
            this.linkLabel_UICredit1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel_UICredit1.TabIndex = 29;
            this.linkLabel_UICredit1.TabStop = true;
            this.linkLabel_UICredit1.Text = "BlackShark";
            this.linkLabel_UICredit1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_UICredit1_LinkClicked);
            // 
            // color_horizontalLegend
            // 
            this.color_horizontalLegend.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            // 
            // 
            // 
            this.color_horizontalLegend.LabelDesigner.AutoSize = true;
            this.color_horizontalLegend.LabelDesigner.Location = new System.Drawing.Point(3, 6);
            this.color_horizontalLegend.LabelDesigner.Name = "Label";
            this.color_horizontalLegend.LabelDesigner.Size = new System.Drawing.Size(115, 13);
            this.color_horizontalLegend.LabelDesigner.TabIndex = 1;
            this.color_horizontalLegend.LabelDesigner.Text = "Horizontal legend color";
            this.color_horizontalLegend.Location = new System.Drawing.Point(4, 68);
            this.color_horizontalLegend.Name = "color_horizontalLegend";
            this.color_horizontalLegend.Size = new System.Drawing.Size(328, 26);
            this.color_horizontalLegend.TabIndex = 33;
            // 
            // checkBox_showAxisYSeparator
            // 
            this.checkBox_showAxisYSeparator.AutoSize = true;
            this.checkBox_showAxisYSeparator.Location = new System.Drawing.Point(8, 123);
            this.checkBox_showAxisYSeparator.Name = "checkBox_showAxisYSeparator";
            this.checkBox_showAxisYSeparator.Size = new System.Drawing.Size(136, 17);
            this.checkBox_showAxisYSeparator.TabIndex = 32;
            this.checkBox_showAxisYSeparator.Text = "Show horizontal legend";
            this.checkBox_showAxisYSeparator.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Font used:";
            // 
            // comboBox_font
            // 
            this.comboBox_font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_font.FormattingEnabled = true;
            this.comboBox_font.Location = new System.Drawing.Point(71, 99);
            this.comboBox_font.Name = "comboBox_font";
            this.comboBox_font.Size = new System.Drawing.Size(139, 21);
            this.comboBox_font.TabIndex = 25;
            // 
            // panel_manualChart
            // 
            this.panel_manualChart.Controls.Add(this.label1);
            this.panel_manualChart.Controls.Add(this.textBox_chartCutoffs);
            this.panel_manualChart.Location = new System.Drawing.Point(0, 169);
            this.panel_manualChart.Name = "panel_manualChart";
            this.panel_manualChart.Size = new System.Drawing.Size(439, 22);
            this.panel_manualChart.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manual chart height cutoff points, separated by \";\":";
            // 
            // textBox_chartCutoffs
            // 
            this.textBox_chartCutoffs.Location = new System.Drawing.Point(262, 0);
            this.textBox_chartCutoffs.Name = "textBox_chartCutoffs";
            this.textBox_chartCutoffs.Size = new System.Drawing.Size(171, 20);
            this.textBox_chartCutoffs.TabIndex = 3;
            // 
            // checkBox_autosizeChart
            // 
            this.checkBox_autosizeChart.AutoSize = true;
            this.checkBox_autosizeChart.Location = new System.Drawing.Point(8, 146);
            this.checkBox_autosizeChart.Name = "checkBox_autosizeChart";
            this.checkBox_autosizeChart.Size = new System.Drawing.Size(252, 17);
            this.checkBox_autosizeChart.TabIndex = 2;
            this.checkBox_autosizeChart.Text = "Autosize chart value height based on max value";
            this.checkBox_autosizeChart.UseVisualStyleBackColor = true;
            // 
            // color_chartProgress
            // 
            this.color_chartProgress.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            // 
            // 
            // 
            this.color_chartProgress.LabelDesigner.AutoSize = true;
            this.color_chartProgress.LabelDesigner.Location = new System.Drawing.Point(3, 6);
            this.color_chartProgress.LabelDesigner.Name = "Label";
            this.color_chartProgress.LabelDesigner.Size = new System.Drawing.Size(101, 13);
            this.color_chartProgress.LabelDesigner.TabIndex = 1;
            this.color_chartProgress.LabelDesigner.Text = "Chart progress color";
            this.color_chartProgress.Location = new System.Drawing.Point(4, 36);
            this.color_chartProgress.Name = "color_chartProgress";
            this.color_chartProgress.Size = new System.Drawing.Size(328, 26);
            this.color_chartProgress.TabIndex = 1;
            // 
            // color_chartPrimary
            // 
            this.color_chartPrimary.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            // 
            // 
            // 
            this.color_chartPrimary.LabelDesigner.AutoSize = true;
            this.color_chartPrimary.LabelDesigner.Location = new System.Drawing.Point(3, 6);
            this.color_chartPrimary.LabelDesigner.Name = "Label";
            this.color_chartPrimary.LabelDesigner.Size = new System.Drawing.Size(94, 13);
            this.color_chartPrimary.LabelDesigner.TabIndex = 1;
            this.color_chartPrimary.LabelDesigner.Text = "Primary chart color";
            this.color_chartPrimary.Location = new System.Drawing.Point(4, 4);
            this.color_chartPrimary.Name = "color_chartPrimary";
            this.color_chartPrimary.Size = new System.Drawing.Size(328, 26);
            this.color_chartPrimary.TabIndex = 0;
            // 
            // LiveVisualizerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox_enable);
            this.Name = "LiveVisualizerSettings";
            this.Size = new System.Drawing.Size(650, 425);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_windowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_windowWidth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_manualChart.ResumeLayout(false);
            this.panel_manualChart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_enable;
        private System.Windows.Forms.Panel panel1;
        private ColorPickerWithPreview color_chartPrimary;
        private ColorPickerWithPreview color_chartProgress;
        private System.Windows.Forms.CheckBox checkBox_autosizeChart;
        private System.Windows.Forms.Panel panel_manualChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_chartCutoffs;
        private System.Windows.Forms.ComboBox comboBox_font;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel_UICredit1;
        private System.Windows.Forms.LinkLabel linkLabel_UICredit2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_showAxisYSeparator;
        private ColorPickerWithPreview color_horizontalLegend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown_windowWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_windowHeight;
        private System.Windows.Forms.CheckBox checkBox_enableWindowRezising;
    }
}
