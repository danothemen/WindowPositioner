﻿namespace WindowPositioner
{
    partial class AddProcessForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.programNameTextBox = new System.Windows.Forms.TextBox();
            this.windowX = new System.Windows.Forms.TextBox();
            this.windowY = new System.Windows.Forms.TextBox();
            this.windowWidth = new System.Windows.Forms.TextBox();
            this.windowHeight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Location = new System.Drawing.Point(150, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(12, 70);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(214, 20);
            this.urlTextBox.TabIndex = 2;
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programNameTextBox.Location = new System.Drawing.Point(13, 13);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.programNameTextBox.TabIndex = 3;
            // 
            // windowX
            // 
            this.windowX.Location = new System.Drawing.Point(13, 44);
            this.windowX.Name = "windowX";
            this.windowX.Size = new System.Drawing.Size(29, 20);
            this.windowX.TabIndex = 4;
            // 
            // windowY
            // 
            this.windowY.Location = new System.Drawing.Point(47, 44);
            this.windowY.Name = "windowY";
            this.windowY.Size = new System.Drawing.Size(29, 20);
            this.windowY.TabIndex = 5;
            // 
            // windowWidth
            // 
            this.windowWidth.Location = new System.Drawing.Point(81, 44);
            this.windowWidth.Name = "windowWidth";
            this.windowWidth.Size = new System.Drawing.Size(29, 20);
            this.windowWidth.TabIndex = 6;
            // 
            // windowHeight
            // 
            this.windowHeight.Location = new System.Drawing.Point(115, 44);
            this.windowHeight.Name = "windowHeight";
            this.windowHeight.Size = new System.Drawing.Size(29, 20);
            this.windowHeight.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(150, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Select Open ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 102);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.windowHeight);
            this.Controls.Add(this.windowWidth);
            this.Controls.Add(this.windowY);
            this.Controls.Add(this.windowX);
            this.Controls.Add(this.programNameTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "AddProcessForm";
            this.Text = "SelectProcessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox programNameTextBox;
        private System.Windows.Forms.TextBox windowX;
        private System.Windows.Forms.TextBox windowY;
        private System.Windows.Forms.TextBox windowWidth;
        private System.Windows.Forms.TextBox windowHeight;
        private System.Windows.Forms.Button button1;
    }
}