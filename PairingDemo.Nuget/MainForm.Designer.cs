﻿namespace PairingDemo.Nuget
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnPairTerminal = new Button();
            SuspendLayout();
            // 
            // BtnPairTerminal
            // 
            BtnPairTerminal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnPairTerminal.BackColor = SystemColors.Control;
            BtnPairTerminal.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPairTerminal.ForeColor = SystemColors.ControlText;
            BtnPairTerminal.Location = new Point(292, 201);
            BtnPairTerminal.Name = "BtnPairTerminal";
            BtnPairTerminal.Size = new Size(217, 48);
            BtnPairTerminal.TabIndex = 38;
            BtnPairTerminal.Text = "Pair with terminal";
            BtnPairTerminal.UseVisualStyleBackColor = false;
            BtnPairTerminal.Click += BtnPairTerminal_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnPairTerminal);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPairTerminal;
    }
}