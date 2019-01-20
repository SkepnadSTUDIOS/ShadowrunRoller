﻿using System.Windows.Forms;

namespace ShadowRunRoller
{
    partial class DiceWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.EdgeRollCheckbox = new System.Windows.Forms.CheckBox();
            this.Verbose = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuccessResultBox = new System.Windows.Forms.TextBox();
            this.FailureResultBox = new System.Windows.Forms.TextBox();
            this.NumberOfDiceBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.successText = new System.Windows.Forms.Label();
            this.OnesResultBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultMultilineBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(331, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EdgeRollCheckbox
            // 
            this.EdgeRollCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EdgeRollCheckbox.AutoSize = true;
            this.EdgeRollCheckbox.Location = new System.Drawing.Point(237, 25);
            this.EdgeRollCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.EdgeRollCheckbox.Name = "EdgeRollCheckbox";
            this.EdgeRollCheckbox.Size = new System.Drawing.Size(67, 17);
            this.EdgeRollCheckbox.TabIndex = 1;
            this.EdgeRollCheckbox.Text = "Edge roll";
            this.EdgeRollCheckbox.UseVisualStyleBackColor = true;
            // 
            // Verbose
            // 
            this.Verbose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Verbose.AutoSize = true;
            this.Verbose.Checked = true;
            this.Verbose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Verbose.Location = new System.Drawing.Point(237, 47);
            this.Verbose.Margin = new System.Windows.Forms.Padding(2);
            this.Verbose.Name = "Verbose";
            this.Verbose.Size = new System.Drawing.Size(65, 17);
            this.Verbose.TabIndex = 2;
            this.Verbose.Text = "Verbose";
            this.Verbose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabStop = false;
            this.label1.Text = "Amount of successes";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabStop = false;
            this.label2.Text = "Amount of failures";
            // 
            // SuccessResultBox
            // 
            this.SuccessResultBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SuccessResultBox.Enabled = false;
            this.SuccessResultBox.Location = new System.Drawing.Point(78, 25);
            this.SuccessResultBox.Margin = new System.Windows.Forms.Padding(2);
            this.SuccessResultBox.Name = "SuccessResultBox";
            this.SuccessResultBox.Size = new System.Drawing.Size(36, 20);
            this.SuccessResultBox.TabStop = false;
            this.SuccessResultBox.Text = "0";
            this.SuccessResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FailureResultBox
            // 
            this.FailureResultBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FailureResultBox.Enabled = false;
            this.FailureResultBox.Location = new System.Drawing.Point(78, 44);
            this.FailureResultBox.Margin = new System.Windows.Forms.Padding(2);
            this.FailureResultBox.Name = "FailureResultBox";
            this.FailureResultBox.Size = new System.Drawing.Size(36, 20);
            this.FailureResultBox.TabStop = false;
            this.FailureResultBox.Text = "0";
            this.FailureResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumberOfDiceBox
            // 
            this.NumberOfDiceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDiceBox.Location = new System.Drawing.Point(24, 24);
            this.NumberOfDiceBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumberOfDiceBox.Name = "NumberOfDiceBox";
            this.NumberOfDiceBox.Size = new System.Drawing.Size(45, 37);
            this.NumberOfDiceBox.TabIndex = 0;
            this.NumberOfDiceBox.Text = "5";
            this.NumberOfDiceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfDiceBox.TextChanged += new System.EventHandler(this.NumberOfDiceBox_TextChanged);
            this.NumberOfDiceBox.KeyPress += new KeyPressEventHandler(this.NumberOfDiceBox_KeyPressed);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(331, 83);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add exploding d6";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(331, 140);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add normal d6";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.ForeColor = System.Drawing.Color.DarkRed;
            this.errorText.Location = new System.Drawing.Point(78, 93);
            this.errorText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 13);
            this.errorText.TabStop = false;
            // 
            // successText
            // 
            this.successText.AutoSize = true;
            this.successText.ForeColor = System.Drawing.Color.Black;
            this.successText.Location = new System.Drawing.Point(78, 93);
            this.successText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.successText.Name = "successText";
            this.successText.Size = new System.Drawing.Size(0, 13);
            this.successText.TabStop = false;
            // 
            // OnesResultBox
            // 
            this.OnesResultBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OnesResultBox.Enabled = false;
            this.OnesResultBox.Location = new System.Drawing.Point(78, 63);
            this.OnesResultBox.Margin = new System.Windows.Forms.Padding(2);
            this.OnesResultBox.Name = "OnesResultBox";
            this.OnesResultBox.Size = new System.Drawing.Size(36, 20);
            this.OnesResultBox.TabStop = false;
            this.OnesResultBox.Text = "0";
            this.OnesResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabStop = false;
            this.label3.Text = "Amount of 1:s";
            // 
            // ResultMultilineBox
            // 
            this.ResultMultilineBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultMultilineBox.Location = new System.Drawing.Point(24, 140);
            this.ResultMultilineBox.Name = "ResultMultilineBox";
            this.ResultMultilineBox.ReadOnly = true;
            this.ResultMultilineBox.Size = new System.Drawing.Size(284, 342);
            this.ResultMultilineBox.TabStop = false;
            this.ResultMultilineBox.Text = "";
            // 
            // DiceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultMultilineBox);
            this.Controls.Add(this.OnesResultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.successText);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NumberOfDiceBox);
            this.Controls.Add(this.FailureResultBox);
            this.Controls.Add(this.SuccessResultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Verbose);
            this.Controls.Add(this.EdgeRollCheckbox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(462, 500);
            this.Name = "DiceWindow";
            this.Size = new System.Drawing.Size(462, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox EdgeRollCheckbox;
        private System.Windows.Forms.CheckBox Verbose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SuccessResultBox;
        private System.Windows.Forms.TextBox FailureResultBox;
        private System.Windows.Forms.TextBox NumberOfDiceBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Label successText;
        private System.Windows.Forms.TextBox OnesResultBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ResultMultilineBox;
    }
}

