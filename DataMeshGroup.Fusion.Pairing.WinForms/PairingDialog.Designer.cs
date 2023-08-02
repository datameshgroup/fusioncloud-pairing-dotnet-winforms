using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMeshGroup.Fusion.Pairing.WinForms
{
    partial class PairingDialog
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PairingDialog));
            BtnNext = new Button();
            label11 = new Label();
            PnlQRCode = new Panel();
            BtnEnterCredentialsManually = new Button();
            lblVersion = new Label();
            qrPictureBox = new PictureBox();
            PnlPairingStatus = new Panel();
            BusyIndicator = new PictureBox();
            LblPaymentDialogLine1 = new Label();
            TxtPaymentDialogText = new Label();
            LblPaymentDialogTitle = new Label();
            button1 = new Button();
            PnlManualEntry = new Panel();
            BtnBack = new Button();
            txtKEK = new TextBox();
            txtPOIId = new TextBox();
            txtSaleID = new TextBox();
            LblKEKLabel = new Label();
            LblPOIIDLabel = new Label();
            LblSaleIDLabel = new Label();
            BtnDialogOK = new Button();
            NextTimer = new System.Windows.Forms.Timer(components);
            lblNextTimer = new Label();
            PnlQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrPictureBox).BeginInit();
            PnlPairingStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BusyIndicator).BeginInit();
            PnlManualEntry.SuspendLayout();
            SuspendLayout();
            // 
            // BtnNext
            // 
            BtnNext.Anchor = AnchorStyles.None;
            BtnNext.Enabled = false;
            BtnNext.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNext.Location = new Point(659, 443);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(152, 48);
            BtnNext.TabIndex = 39;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(136, 136, 136);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(419, 32);
            label11.TabIndex = 42;
            label11.Text = "DATAMESH TERMINAL PAIRING";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PnlQRCode
            // 
            PnlQRCode.Controls.Add(BtnEnterCredentialsManually);
            PnlQRCode.Controls.Add(lblVersion);
            PnlQRCode.Controls.Add(qrPictureBox);
            PnlQRCode.Location = new Point(12, 44);
            PnlQRCode.Name = "PnlQRCode";
            PnlQRCode.Size = new Size(799, 391);
            PnlQRCode.TabIndex = 43;
            // 
            // BtnEnterCredentialsManually
            // 
            BtnEnterCredentialsManually.Anchor = AnchorStyles.None;
            BtnEnterCredentialsManually.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEnterCredentialsManually.Location = new Point(24, 335);
            BtnEnterCredentialsManually.Name = "BtnEnterCredentialsManually";
            BtnEnterCredentialsManually.Size = new Size(300, 36);
            BtnEnterCredentialsManually.TabIndex = 45;
            BtnEnterCredentialsManually.Text = "Enter credentials manually";
            BtnEnterCredentialsManually.UseVisualStyleBackColor = true;
            BtnEnterCredentialsManually.Click += BtnEnterCredentialsManually_Click;
            // 
            // lblVersion
            // 
            lblVersion.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.Black;
            lblVersion.Location = new Point(330, 29);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(449, 300);
            lblVersion.TabIndex = 43;
            lblVersion.Text = "1. Scan the QR code on the DataMesh terminal, and follow the instructions on the terminal screen.\r\n\r\n2. After the terminal has been paired with the POS, press Next.\r\n";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // qrPictureBox
            // 
            qrPictureBox.Location = new Point(24, 29);
            qrPictureBox.Name = "qrPictureBox";
            qrPictureBox.Size = new Size(300, 300);
            qrPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            qrPictureBox.TabIndex = 42;
            qrPictureBox.TabStop = false;
            // 
            // PnlPairingStatus
            // 
            PnlPairingStatus.Controls.Add(BusyIndicator);
            PnlPairingStatus.Controls.Add(LblPaymentDialogLine1);
            PnlPairingStatus.Controls.Add(TxtPaymentDialogText);
            PnlPairingStatus.Controls.Add(LblPaymentDialogTitle);
            PnlPairingStatus.Controls.Add(button1);
            PnlPairingStatus.Location = new Point(12, 44);
            PnlPairingStatus.Name = "PnlPairingStatus";
            PnlPairingStatus.Size = new Size(799, 391);
            PnlPairingStatus.TabIndex = 45;
            PnlPairingStatus.Visible = false;
            // 
            // BusyIndicator
            // 
            BusyIndicator.Image = (Image)resources.GetObject("BusyIndicator.Image");
            BusyIndicator.Location = new Point(19, 245);
            BusyIndicator.Name = "BusyIndicator";
            BusyIndicator.Size = new Size(760, 133);
            BusyIndicator.SizeMode = PictureBoxSizeMode.Zoom;
            BusyIndicator.TabIndex = 45;
            BusyIndicator.TabStop = false;
            // 
            // LblPaymentDialogLine1
            // 
            LblPaymentDialogLine1.Anchor = AnchorStyles.None;
            LblPaymentDialogLine1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPaymentDialogLine1.ForeColor = Color.FromArgb(136, 136, 136);
            LblPaymentDialogLine1.Location = new Point(19, 130);
            LblPaymentDialogLine1.Name = "LblPaymentDialogLine1";
            LblPaymentDialogLine1.Size = new Size(760, 39);
            LblPaymentDialogLine1.TabIndex = 48;
            LblPaymentDialogLine1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPaymentDialogText
            // 
            TxtPaymentDialogText.Anchor = AnchorStyles.None;
            TxtPaymentDialogText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPaymentDialogText.ForeColor = Color.FromArgb(136, 136, 136);
            TxtPaymentDialogText.Location = new Point(19, 183);
            TxtPaymentDialogText.Name = "TxtPaymentDialogText";
            TxtPaymentDialogText.Size = new Size(760, 77);
            TxtPaymentDialogText.TabIndex = 47;
            TxtPaymentDialogText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblPaymentDialogTitle
            // 
            LblPaymentDialogTitle.Anchor = AnchorStyles.None;
            LblPaymentDialogTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LblPaymentDialogTitle.ForeColor = Color.Black;
            LblPaymentDialogTitle.Location = new Point(19, 12);
            LblPaymentDialogTitle.Name = "LblPaymentDialogTitle";
            LblPaymentDialogTitle.Size = new Size(760, 87);
            LblPaymentDialogTitle.TabIndex = 46;
            LblPaymentDialogTitle.Text = "PAIRING WITH TERMINAL";
            LblPaymentDialogTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(323, 480);
            button1.Name = "button1";
            button1.Size = new Size(300, 36);
            button1.TabIndex = 44;
            button1.Text = "Enter credentials manually";
            button1.UseVisualStyleBackColor = true;
            // 
            // PnlManualEntry
            // 
            PnlManualEntry.BackColor = SystemColors.Control;
            PnlManualEntry.Controls.Add(BtnBack);
            PnlManualEntry.Controls.Add(txtKEK);
            PnlManualEntry.Controls.Add(txtPOIId);
            PnlManualEntry.Controls.Add(txtSaleID);
            PnlManualEntry.Controls.Add(LblKEKLabel);
            PnlManualEntry.Controls.Add(LblPOIIDLabel);
            PnlManualEntry.Controls.Add(LblSaleIDLabel);
            PnlManualEntry.Location = new Point(12, 44);
            PnlManualEntry.Name = "PnlManualEntry";
            PnlManualEntry.Size = new Size(799, 391);
            PnlManualEntry.TabIndex = 44;
            // 
            // BtnBack
            // 
            BtnBack.Anchor = AnchorStyles.None;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.Location = new Point(19, 12);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(82, 48);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "←";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // txtKEK
            // 
            txtKEK.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtKEK.Location = new Point(151, 203);
            txtKEK.Name = "txtKEK";
            txtKEK.Size = new Size(592, 29);
            txtKEK.TabIndex = 4;
            // 
            // txtPOIId
            // 
            txtPOIId.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPOIId.Location = new Point(151, 168);
            txtPOIId.Name = "txtPOIId";
            txtPOIId.Size = new Size(320, 29);
            txtPOIId.TabIndex = 3;
            // 
            // txtSaleID
            // 
            txtSaleID.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSaleID.Location = new Point(151, 133);
            txtSaleID.Name = "txtSaleID";
            txtSaleID.Size = new Size(320, 29);
            txtSaleID.TabIndex = 2;
            // 
            // LblKEKLabel
            // 
            LblKEKLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblKEKLabel.ForeColor = Color.FromArgb(136, 136, 136);
            LblKEKLabel.Location = new Point(19, 203);
            LblKEKLabel.Name = "LblKEKLabel";
            LblKEKLabel.Size = new Size(126, 32);
            LblKEKLabel.TabIndex = 39;
            LblKEKLabel.Text = "KEK";
            LblKEKLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblPOIIDLabel
            // 
            LblPOIIDLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPOIIDLabel.ForeColor = Color.FromArgb(136, 136, 136);
            LblPOIIDLabel.Location = new Point(19, 168);
            LblPOIIDLabel.Name = "LblPOIIDLabel";
            LblPOIIDLabel.Size = new Size(126, 32);
            LblPOIIDLabel.TabIndex = 38;
            LblPOIIDLabel.Text = "POI ID";
            LblPOIIDLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblSaleIDLabel
            // 
            LblSaleIDLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblSaleIDLabel.ForeColor = Color.FromArgb(136, 136, 136);
            LblSaleIDLabel.Location = new Point(19, 130);
            LblSaleIDLabel.Name = "LblSaleIDLabel";
            LblSaleIDLabel.Size = new Size(126, 32);
            LblSaleIDLabel.TabIndex = 37;
            LblSaleIDLabel.Text = "SALE ID";
            LblSaleIDLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnDialogOK
            // 
            BtnDialogOK.Anchor = AnchorStyles.None;
            BtnDialogOK.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDialogOK.Location = new Point(659, 443);
            BtnDialogOK.Name = "BtnDialogOK";
            BtnDialogOK.Size = new Size(152, 48);
            BtnDialogOK.TabIndex = 5;
            BtnDialogOK.Text = "OK";
            BtnDialogOK.UseVisualStyleBackColor = true;
            BtnDialogOK.Visible = false;
            BtnDialogOK.Click += BtnDialogOk_Click;
            // 
            // NextTimer
            // 
            NextTimer.Interval = 1000;
            NextTimer.Tick += NextTimer_Tick;
            // 
            // lblNextTimer
            // 
            lblNextTimer.AutoSize = true;
            lblNextTimer.BackColor = SystemColors.ScrollBar;
            lblNextTimer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNextTimer.ForeColor = SystemColors.ButtonShadow;
            lblNextTimer.Location = new Point(785, 464);
            lblNextTimer.Name = "lblNextTimer";
            lblNextTimer.RightToLeft = RightToLeft.Yes;
            lblNextTimer.Size = new Size(18, 20);
            lblNextTimer.TabIndex = 46;
            lblNextTimer.Text = "9";
            lblNextTimer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PairingDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 503);
            Controls.Add(lblNextTimer);
            Controls.Add(BtnDialogOK);
            Controls.Add(label11);
            Controls.Add(BtnNext);
            Controls.Add(PnlQRCode);
            Controls.Add(PnlManualEntry);
            Controls.Add(PnlPairingStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PairingDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PairingDialog";
            Load += PairingDialog_Load;
            PnlQRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)qrPictureBox).EndInit();
            PnlPairingStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BusyIndicator).EndInit();
            PnlManualEntry.ResumeLayout(false);
            PnlManualEntry.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnNext;
        private Label label11;
        private Panel PnlQRCode;
        private Label lblVersion;
        private PictureBox qrPictureBox;
        private Panel PnlManualEntry;
        private TextBox txtKEK;
        private TextBox txtPOIId;
        private TextBox txtSaleID;
        private Label LblKEKLabel;
        private Label LblPOIIDLabel;
        private Label LblSaleIDLabel;
        private Button BtnEnterCredentialsManually;
        private Panel PnlPairingStatus;
        private PictureBox BusyIndicator;
        private Label LblPaymentDialogTitle;
        private Button button1;
        private Button BtnDialogOK;
        private Label LblPaymentDialogLine1;
        private Label TxtPaymentDialogText;
        private Button BtnBack;
        private System.Windows.Forms.Timer NextTimer;
        private Label lblNextTimer;
    }
}