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
            progressBar1 = new SmoothProgressBar();
            BtnDialogCancel = new Button();
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
            BtnNext.BackColor = SystemColors.ButtonFace;
            BtnNext.FlatAppearance.BorderSize = 0;
            BtnNext.FlatStyle = FlatStyle.Flat;
            BtnNext.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNext.ForeColor = SystemColors.WindowText;
            BtnNext.Location = new Point(400, 499);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(368, 48);
            BtnNext.TabIndex = 39;
            BtnNext.UseVisualStyleBackColor = false;
            BtnNext.Click += BtnNext_Click;
            BtnNext.Paint += BtnNext_Paint;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(16, 9);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(324, 32);
            label11.TabIndex = 42;
            label11.Text = "DATAMESH TERMINAL PAIRING";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PnlQRCode
            // 
            PnlQRCode.Controls.Add(BtnEnterCredentialsManually);
            PnlQRCode.Controls.Add(lblVersion);
            PnlQRCode.Controls.Add(qrPictureBox);
            PnlQRCode.Location = new Point(0, 44);
            PnlQRCode.Name = "PnlQRCode";
            PnlQRCode.Size = new Size(784, 391);
            PnlQRCode.TabIndex = 43;
            // 
            // BtnEnterCredentialsManually
            // 
            BtnEnterCredentialsManually.Anchor = AnchorStyles.None;
            BtnEnterCredentialsManually.BackColor = Color.FromArgb(232, 232, 232);
            BtnEnterCredentialsManually.FlatAppearance.BorderSize = 0;
            BtnEnterCredentialsManually.FlatStyle = FlatStyle.Flat;
            BtnEnterCredentialsManually.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEnterCredentialsManually.ForeColor = Color.FromArgb(80, 80, 80);
            BtnEnterCredentialsManually.Location = new Point(400, 320);
            BtnEnterCredentialsManually.Name = "BtnEnterCredentialsManually";
            BtnEnterCredentialsManually.Size = new Size(368, 48);
            BtnEnterCredentialsManually.TabIndex = 46;
            BtnEnterCredentialsManually.Text = "ENTER CREDENTIALS MANUALLY";
            BtnEnterCredentialsManually.UseVisualStyleBackColor = false;
            BtnEnterCredentialsManually.Click += BtnEnterCredentialsManually_Click_1;
            // 
            // lblVersion
            // 
            lblVersion.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.Black;
            lblVersion.Location = new Point(400, 0);
            lblVersion.Margin = new Padding(0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(368, 317);
            lblVersion.TabIndex = 43;
            lblVersion.Text = resources.GetString("lblVersion.Text");
            lblVersion.Click += lblVersion_Click;
            // 
            // qrPictureBox
            // 
            qrPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            qrPictureBox.Image = (Image)resources.GetObject("qrPictureBox.Image");
            qrPictureBox.Location = new Point(0, -18);
            qrPictureBox.Margin = new Padding(0);
            qrPictureBox.Name = "qrPictureBox";
            qrPictureBox.Size = new Size(418, 409);
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
            PnlPairingStatus.Location = new Point(0, 44);
            PnlPairingStatus.Name = "PnlPairingStatus";
            PnlPairingStatus.Size = new Size(784, 391);
            PnlPairingStatus.TabIndex = 45;
            PnlPairingStatus.Visible = false;
            // 
            // BusyIndicator
            // 
            BusyIndicator.Image = (Image)resources.GetObject("BusyIndicator.Image");
            BusyIndicator.Location = new Point(16, 219);
            BusyIndicator.Name = "BusyIndicator";
            BusyIndicator.Size = new Size(752, 169);
            BusyIndicator.SizeMode = PictureBoxSizeMode.Zoom;
            BusyIndicator.TabIndex = 45;
            BusyIndicator.TabStop = false;
            // 
            // LblPaymentDialogLine1
            // 
            LblPaymentDialogLine1.Anchor = AnchorStyles.None;
            LblPaymentDialogLine1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPaymentDialogLine1.ForeColor = Color.FromArgb(80, 80, 80);
            LblPaymentDialogLine1.Location = new Point(16, 130);
            LblPaymentDialogLine1.Name = "LblPaymentDialogLine1";
            LblPaymentDialogLine1.Size = new Size(752, 39);
            LblPaymentDialogLine1.TabIndex = 48;
            LblPaymentDialogLine1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPaymentDialogText
            // 
            TxtPaymentDialogText.Anchor = AnchorStyles.None;
            TxtPaymentDialogText.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPaymentDialogText.ForeColor = Color.FromArgb(80, 80, 80);
            TxtPaymentDialogText.Location = new Point(16, 183);
            TxtPaymentDialogText.Name = "TxtPaymentDialogText";
            TxtPaymentDialogText.Size = new Size(752, 77);
            TxtPaymentDialogText.TabIndex = 47;
            TxtPaymentDialogText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblPaymentDialogTitle
            // 
            LblPaymentDialogTitle.Anchor = AnchorStyles.None;
            LblPaymentDialogTitle.BackColor = Color.FromArgb(232, 232, 232);
            LblPaymentDialogTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LblPaymentDialogTitle.ForeColor = Color.FromArgb(80, 80, 80);
            LblPaymentDialogTitle.Location = new Point(16, 12);
            LblPaymentDialogTitle.Name = "LblPaymentDialogTitle";
            LblPaymentDialogTitle.Size = new Size(752, 87);
            LblPaymentDialogTitle.TabIndex = 46;
            LblPaymentDialogTitle.Text = "PAIRING WITH TERMINAL";
            LblPaymentDialogTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            PnlManualEntry.Location = new Point(0, 44);
            PnlManualEntry.Name = "PnlManualEntry";
            PnlManualEntry.Size = new Size(784, 391);
            PnlManualEntry.TabIndex = 44;
            // 
            // BtnBack
            // 
            BtnBack.Anchor = AnchorStyles.None;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.Location = new Point(63, 3);
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
            BtnDialogOK.BackColor = Color.FromArgb(232, 232, 232);
            BtnDialogOK.FlatAppearance.BorderSize = 0;
            BtnDialogOK.FlatStyle = FlatStyle.Flat;
            BtnDialogOK.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDialogOK.ForeColor = Color.FromArgb(80, 80, 80);
            BtnDialogOK.Location = new Point(400, 499);
            BtnDialogOK.Name = "BtnDialogOK";
            BtnDialogOK.Size = new Size(368, 48);
            BtnDialogOK.TabIndex = 5;
            BtnDialogOK.Text = "CLOSE";
            BtnDialogOK.UseVisualStyleBackColor = false;
            BtnDialogOK.Visible = false;
            BtnDialogOK.Click += BtnDialogOk_Click;
            // 
            // NextTimer
            // 
            NextTimer.Interval = 1000;
            NextTimer.Tick += NextTimer_Tick;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Black;
            progressBar1.ForeColor = Color.Fuchsia;
            progressBar1.Location = new Point(400, 537);
            progressBar1.Margin = new Padding(0);
            progressBar1.Maximum = 1000;
            progressBar1.Minimum = 0;
            progressBar1.Name = "progressBar1";
            progressBar1.ProgressBarColor = Color.Blue;
            progressBar1.Size = new Size(368, 10);
            progressBar1.TabIndex = 47;
            progressBar1.Value = 100;
            // 
            // BtnDialogCancel
            // 
            BtnDialogCancel.Anchor = AnchorStyles.None;
            BtnDialogCancel.BackColor = Color.FromArgb(232, 232, 232);
            BtnDialogCancel.FlatAppearance.BorderSize = 0;
            BtnDialogCancel.FlatStyle = FlatStyle.Flat;
            BtnDialogCancel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDialogCancel.ForeColor = Color.FromArgb(80, 80, 80);
            BtnDialogCancel.Location = new Point(16, 499);
            BtnDialogCancel.Name = "BtnDialogCancel";
            BtnDialogCancel.Size = new Size(368, 48);
            BtnDialogCancel.TabIndex = 48;
            BtnDialogCancel.Text = "CANCEL";
            BtnDialogCancel.UseVisualStyleBackColor = false;
            BtnDialogCancel.Click += BtnDialogCancel_Click;
            // 
            // PairingDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            Controls.Add(BtnDialogCancel);
            Controls.Add(progressBar1);
            Controls.Add(BtnDialogOK);
            Controls.Add(label11);
            Controls.Add(BtnNext);
            Controls.Add(PnlQRCode);
            Controls.Add(PnlManualEntry);
            Controls.Add(PnlPairingStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PairingDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DataMesh Terminal Pairing";
            Load += PairingDialog_Load;
            PnlQRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)qrPictureBox).EndInit();
            PnlPairingStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BusyIndicator).EndInit();
            PnlManualEntry.ResumeLayout(false);
            PnlManualEntry.PerformLayout();
            ResumeLayout(false);
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
        private Panel PnlPairingStatus;
        private PictureBox BusyIndicator;
        private Label LblPaymentDialogTitle;
        private Button BtnDialogOK;
        private Label LblPaymentDialogLine1;
        private Label TxtPaymentDialogText;
        private Button BtnBack;
        private System.Windows.Forms.Timer NextTimer;
        private SmoothProgressBar progressBar1;
        private Button BtnEnterCredentialsManually;
        private Button BtnDialogCancel;
    }
}