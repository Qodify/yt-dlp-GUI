using System.ComponentModel;
using System.Windows.Forms;

namespace YTDL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tcVideoOrAudio = new System.Windows.Forms.TabControl();
            this.tpVideo = new System.Windows.Forms.TabPage();
            this.cbBestVideoQuality = new System.Windows.Forms.CheckBox();
            this.cbSubs = new System.Windows.Forms.CheckBox();
            this.tpAudio = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbQualityBest = new System.Windows.Forms.RadioButton();
            this.rbQualityGreat = new System.Windows.Forms.RadioButton();
            this.rbQualityGood = new System.Windows.Forms.RadioButton();
            this.cbDownloadPlaylist = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ttDownloadPlaylist = new System.Windows.Forms.ToolTip(this.components);
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Cancel = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.cbFormatToMP3 = new System.Windows.Forms.CheckBox();
            this.tcVideoOrAudio.SuspendLayout();
            this.tpVideo.SuspendLayout();
            this.tpAudio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(42, 39);
            this.tbURL.Margin = new System.Windows.Forms.Padding(2);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(743, 27);
            this.tbURL.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tcVideoOrAudio
            // 
            this.tcVideoOrAudio.Controls.Add(this.tpVideo);
            this.tcVideoOrAudio.Controls.Add(this.tpAudio);
            this.tcVideoOrAudio.Location = new System.Drawing.Point(42, 100);
            this.tcVideoOrAudio.Margin = new System.Windows.Forms.Padding(2);
            this.tcVideoOrAudio.Name = "tcVideoOrAudio";
            this.tcVideoOrAudio.SelectedIndex = 0;
            this.tcVideoOrAudio.Size = new System.Drawing.Size(725, 194);
            this.tcVideoOrAudio.TabIndex = 3;
            this.tcVideoOrAudio.SelectedIndexChanged += TcVideoOrAudio_SelectedIndexChanged;
            // 
            // tpVideo
            // 
            this.tpVideo.Controls.Add(this.cbBestVideoQuality);
            this.tpVideo.Controls.Add(this.cbSubs);
            this.tpVideo.Location = new System.Drawing.Point(4, 29);
            this.tpVideo.Margin = new System.Windows.Forms.Padding(2);
            this.tpVideo.Name = "tpVideo";
            this.tpVideo.Padding = new System.Windows.Forms.Padding(2);
            this.tpVideo.Size = new System.Drawing.Size(717, 161);
            this.tpVideo.TabIndex = 0;
            this.tpVideo.Text = "Video";
            this.tpVideo.UseVisualStyleBackColor = true;
            // 
            // cbBestVideoQuality
            // 
            this.cbBestVideoQuality.AutoSize = true;
            this.cbBestVideoQuality.Location = new System.Drawing.Point(4, 30);
            this.cbBestVideoQuality.Name = "cbBestVideoQuality";
            this.cbBestVideoQuality.Size = new System.Drawing.Size(165, 24);
            this.cbBestVideoQuality.TabIndex = 2;
            this.cbBestVideoQuality.Text = "Best Quality (webm)";
            this.cbBestVideoQuality.UseVisualStyleBackColor = true;
            this.cbBestVideoQuality.CheckedChanged += new System.EventHandler(this.cbBestVideoQuality_CheckedChanged);
            // 
            // cbSubs
            // 
            this.cbSubs.AutoSize = true;
            this.cbSubs.Location = new System.Drawing.Point(4, 4);
            this.cbSubs.Margin = new System.Windows.Forms.Padding(2);
            this.cbSubs.Name = "cbSubs";
            this.cbSubs.Size = new System.Drawing.Size(98, 24);
            this.cbSubs.TabIndex = 1;
            this.cbSubs.Text = "Subtitle(s)";
            this.cbSubs.UseVisualStyleBackColor = true;
            this.cbSubs.CheckedChanged += new System.EventHandler(this.cbSubs_CheckedChanged);
            // 
            // tpAudio
            // 
            this.tpAudio.Controls.Add(this.cbFormatToMP3);
            this.tpAudio.Controls.Add(this.label2);
            this.tpAudio.Controls.Add(this.panel1);
            this.tpAudio.Location = new System.Drawing.Point(4, 29);
            this.tpAudio.Margin = new System.Windows.Forms.Padding(2);
            this.tpAudio.Name = "tpAudio";
            this.tpAudio.Padding = new System.Windows.Forms.Padding(2);
            this.tpAudio.Size = new System.Drawing.Size(717, 161);
            this.tpAudio.TabIndex = 1;
            this.tpAudio.Text = "Audio";
            this.tpAudio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quality";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbQualityBest);
            this.panel1.Controls.Add(this.rbQualityGreat);
            this.panel1.Controls.Add(this.rbQualityGood);
            this.panel1.Location = new System.Drawing.Point(59, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 33);
            this.panel1.TabIndex = 0;
            // 
            // rbQualityBest
            // 
            this.rbQualityBest.AutoSize = true;
            this.rbQualityBest.Location = new System.Drawing.Point(150, 5);
            this.rbQualityBest.Name = "rbQualityBest";
            this.rbQualityBest.Size = new System.Drawing.Size(58, 24);
            this.rbQualityBest.TabIndex = 2;
            this.rbQualityBest.TabStop = true;
            this.rbQualityBest.Text = "Best";
            this.rbQualityBest.UseVisualStyleBackColor = false;
            this.rbQualityBest.CheckedChanged += new System.EventHandler(this.rbQualityBest_CheckedChanged);
            // 
            // rbQualityGreat
            // 
            this.rbQualityGreat.AutoSize = true;
            this.rbQualityGreat.Location = new System.Drawing.Point(78, 5);
            this.rbQualityGreat.Name = "rbQualityGreat";
            this.rbQualityGreat.Size = new System.Drawing.Size(66, 24);
            this.rbQualityGreat.TabIndex = 1;
            this.rbQualityGreat.TabStop = true;
            this.rbQualityGreat.Text = "Great";
            this.rbQualityGreat.UseVisualStyleBackColor = false;
            this.rbQualityGreat.CheckedChanged += new System.EventHandler(this.rbQualityGreat_CheckedChanged);
            // 
            // rbQualityGood
            // 
            this.rbQualityGood.AutoSize = true;
            this.rbQualityGood.Location = new System.Drawing.Point(5, 5);
            this.rbQualityGood.Name = "rbQualityGood";
            this.rbQualityGood.Size = new System.Drawing.Size(67, 24);
            this.rbQualityGood.TabIndex = 0;
            this.rbQualityGood.TabStop = true;
            this.rbQualityGood.Text = "Good";
            this.rbQualityGood.UseVisualStyleBackColor = true;
            this.rbQualityGood.CheckedChanged += new System.EventHandler(this.rbQualityGood_CheckedChanged);
            // 
            // cbDownloadPlaylist
            // 
            this.cbDownloadPlaylist.AutoSize = true;
            this.cbDownloadPlaylist.Location = new System.Drawing.Point(42, 72);
            this.cbDownloadPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.cbDownloadPlaylist.Name = "cbDownloadPlaylist";
            this.cbDownloadPlaylist.Size = new System.Drawing.Size(150, 24);
            this.cbDownloadPlaylist.TabIndex = 0;
            this.cbDownloadPlaylist.Text = "Download Playlist";
            this.ttDownloadPlaylist.SetToolTip(this.cbDownloadPlaylist, "Download playlist if URL refers to video and playlist");
            this.cbDownloadPlaylist.UseVisualStyleBackColor = true;
            this.cbDownloadPlaylist.CheckedChanged += new System.EventHandler(this.cbDownloadPlaylist_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update Downloader";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnUpdater);
            // 
            // rtbLogs
            // 
            this.rtbLogs.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbLogs.Location = new System.Drawing.Point(40, 298);
            this.rtbLogs.Margin = new System.Windows.Forms.Padding(2);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.ReadOnly = true;
            this.rtbLogs.Size = new System.Drawing.Size(727, 116);
            this.rtbLogs.TabIndex = 5;
            this.rtbLogs.Text = "";
            this.rtbLogs.WordWrap = false;
            this.rtbLogs.TextChanged += new System.EventHandler(this.rtbLogs_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Logs";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(146, 417);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 29);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "btnCancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(259, 421);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(81, 20);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "resultLabel";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbFormatToMP3
            // 
            this.cbFormatToMP3.AutoSize = true;
            this.cbFormatToMP3.Location = new System.Drawing.Point(5, 42);
            this.cbFormatToMP3.Name = "cbFormatToMP3";
            this.cbFormatToMP3.Size = new System.Drawing.Size(132, 24);
            this.cbFormatToMP3.TabIndex = 2;
            this.cbFormatToMP3.Text = "Format To mp3";
            this.cbFormatToMP3.UseVisualStyleBackColor = true;
            this.cbFormatToMP3.CheckedChanged += new System.EventHandler(this.cbFormatToMP3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 473);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDownloadPlaylist);
            this.Controls.Add(this.rtbLogs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tcVideoOrAudio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbURL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tcVideoOrAudio.ResumeLayout(false);
            this.tpVideo.ResumeLayout(false);
            this.tpVideo.PerformLayout();
            this.tpAudio.ResumeLayout(false);
            this.tpAudio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion

        private TextBox tbURL;
        private Button button1;
        private TabControl tcVideoOrAudio;
        private TabPage tpVideo;
        private TabPage tpAudio;
        private CheckBox cbDownloadPlaylist;
        private Button button2;
        private ToolTip ttDownloadPlaylist;
        private CheckBox cbSubs;
        private RichTextBox rtbLogs;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog;
        private Label label2;
        private Panel panel1;
        private RadioButton rbQualityBest;
        private RadioButton rbQualityGreat;
        private RadioButton rbQualityGood;
        private CheckBox cbBestVideoQuality;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Cancel;
        private Label resultLabel;
        private CheckBox cbFormatToMP3;
    }
}