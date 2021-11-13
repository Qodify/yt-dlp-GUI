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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tcVideoOrAudio = new System.Windows.Forms.TabControl();
            this.tpVideo = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbToWEBM = new System.Windows.Forms.RadioButton();
            this.rbToMKV = new System.Windows.Forms.RadioButton();
            this.rbToMP4 = new System.Windows.Forms.RadioButton();
            this.cbBestVideoQuality = new System.Windows.Forms.CheckBox();
            this.cbSubs = new System.Windows.Forms.CheckBox();
            this.tpAudio = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbToOPUS = new System.Windows.Forms.RadioButton();
            this.rbToMP3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
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
            this.dgvVideoQuality = new System.Windows.Forms.DataGridView();
            this.dgvAudioQuality = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowQualities = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tcVideoOrAudio.SuspendLayout();
            this.tpVideo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpAudio.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudioQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(42, 39);
            this.tbURL.Margin = new System.Windows.Forms.Padding(2);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(842, 27);
            this.tbURL.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 716);
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
            this.tcVideoOrAudio.Location = new System.Drawing.Point(41, 448);
            this.tcVideoOrAudio.Margin = new System.Windows.Forms.Padding(2);
            this.tcVideoOrAudio.Name = "tcVideoOrAudio";
            this.tcVideoOrAudio.SelectedIndex = 0;
            this.tcVideoOrAudio.Size = new System.Drawing.Size(397, 120);
            this.tcVideoOrAudio.TabIndex = 3;
            this.tcVideoOrAudio.SelectedIndexChanged += TcVideoOrAudio_SelectedIndexChanged;

            // 
            // tpVideo
            // 
            this.tpVideo.Controls.Add(this.label7);
            this.tpVideo.Controls.Add(this.panel3);
            this.tpVideo.Controls.Add(this.cbBestVideoQuality);
            this.tpVideo.Controls.Add(this.cbSubs);
            this.tpVideo.Location = new System.Drawing.Point(4, 29);
            this.tpVideo.Margin = new System.Windows.Forms.Padding(2);
            this.tpVideo.Name = "tpVideo";
            this.tpVideo.Padding = new System.Windows.Forms.Padding(2);
            this.tpVideo.Size = new System.Drawing.Size(389, 87);
            this.tpVideo.TabIndex = 0;
            this.tpVideo.Text = "Video";
            this.tpVideo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Format";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbToWEBM);
            this.panel3.Controls.Add(this.rbToMKV);
            this.panel3.Controls.Add(this.rbToMP4);
            this.panel3.Location = new System.Drawing.Point(66, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 31);
            this.panel3.TabIndex = 3;
            // 
            // rbToWEBM
            // 
            this.rbToWEBM.AutoSize = true;
            this.rbToWEBM.Location = new System.Drawing.Point(132, 4);
            this.rbToWEBM.Name = "rbToWEBM";
            this.rbToWEBM.Size = new System.Drawing.Size(71, 24);
            this.rbToWEBM.TabIndex = 2;
            this.rbToWEBM.TabStop = true;
            this.rbToWEBM.Text = "webm";
            this.rbToWEBM.UseVisualStyleBackColor = true;
            this.rbToWEBM.CheckedChanged += new System.EventHandler(this.rbWEBM_CheckedChanged);
            // 
            // rbToMKV
            // 
            this.rbToMKV.AutoSize = true;
            this.rbToMKV.Location = new System.Drawing.Point(69, 3);
            this.rbToMKV.Name = "rbToMKV";
            this.rbToMKV.Size = new System.Drawing.Size(57, 24);
            this.rbToMKV.TabIndex = 1;
            this.rbToMKV.TabStop = true;
            this.rbToMKV.Text = "mkv";
            this.rbToMKV.UseVisualStyleBackColor = true;
            this.rbToMKV.CheckedChanged += new System.EventHandler(this.rbMKV_CheckedChanged);
            // 
            // rbToMP4
            // 
            this.rbToMP4.AutoSize = true;
            this.rbToMP4.Location = new System.Drawing.Point(3, 3);
            this.rbToMP4.Name = "rbToMP4";
            this.rbToMP4.Size = new System.Drawing.Size(60, 24);
            this.rbToMP4.TabIndex = 0;
            this.rbToMP4.TabStop = true;
            this.rbToMP4.Text = "mp4";
            this.rbToMP4.UseVisualStyleBackColor = true;
            this.rbToMP4.CheckedChanged += new System.EventHandler(this.rbMP4_CheckedChanged);
            // 
            // cbBestVideoQuality
            // 
            this.cbBestVideoQuality.AutoSize = true;
            this.cbBestVideoQuality.Location = new System.Drawing.Point(4, 30);
            this.cbBestVideoQuality.Name = "cbBestVideoQuality";
            this.cbBestVideoQuality.Size = new System.Drawing.Size(173, 24);
            this.cbBestVideoQuality.TabIndex = 2;
            this.cbBestVideoQuality.Text = "Get Best Default mp4";
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
            this.tpAudio.Controls.Add(this.panel2);
            this.tpAudio.Controls.Add(this.label6);
            this.tpAudio.Controls.Add(this.label2);
            this.tpAudio.Controls.Add(this.panel1);
            this.tpAudio.Location = new System.Drawing.Point(4, 29);
            this.tpAudio.Margin = new System.Windows.Forms.Padding(2);
            this.tpAudio.Name = "tpAudio";
            this.tpAudio.Padding = new System.Windows.Forms.Padding(2);
            this.tpAudio.Size = new System.Drawing.Size(389, 87);
            this.tpAudio.TabIndex = 1;
            this.tpAudio.Text = "Audio";
            this.tpAudio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbToOPUS);
            this.panel2.Controls.Add(this.rbToMP3);
            this.panel2.Location = new System.Drawing.Point(59, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 33);
            this.panel2.TabIndex = 3;
            // 
            // rbToOPUS
            // 
            this.rbToOPUS.AutoSize = true;
            this.rbToOPUS.Location = new System.Drawing.Point(78, 5);
            this.rbToOPUS.Name = "rbToOPUS";
            this.rbToOPUS.Size = new System.Drawing.Size(62, 24);
            this.rbToOPUS.TabIndex = 1;
            this.rbToOPUS.TabStop = true;
            this.rbToOPUS.Text = "opus";
            this.rbToOPUS.UseVisualStyleBackColor = false;
            this.rbToOPUS.CheckedChanged += new System.EventHandler(this.rbToOPUS_CheckedChanged);
            // 
            // rbToMP3
            // 
            this.rbToMP3.AutoSize = true;
            this.rbToMP3.Location = new System.Drawing.Point(5, 5);
            this.rbToMP3.Name = "rbToMP3";
            this.rbToMP3.Size = new System.Drawing.Size(60, 24);
            this.rbToMP3.TabIndex = 0;
            this.rbToMP3.TabStop = true;
            this.rbToMP3.Text = "mp3";
            this.rbToMP3.UseVisualStyleBackColor = true;
            this.rbToMP3.CheckedChanged += new System.EventHandler(this.rbToMP3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitrate";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbQualityBest);
            this.panel1.Controls.Add(this.rbQualityGreat);
            this.panel1.Controls.Add(this.rbQualityGood);
            this.panel1.Location = new System.Drawing.Point(59, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 33);
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
            this.button2.Location = new System.Drawing.Point(719, 69);
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
            this.rtbLogs.Location = new System.Drawing.Point(41, 586);
            this.rtbLogs.Margin = new System.Windows.Forms.Padding(2);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.ReadOnly = true;
            this.rtbLogs.Size = new System.Drawing.Size(844, 116);
            this.rtbLogs.TabIndex = 5;
            this.rtbLogs.Text = "";
            this.rtbLogs.WordWrap = false;
            this.rtbLogs.TextChanged += new System.EventHandler(this.rtbLogs_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 564);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Logs";
            // 
            // dgvVideoQuality
            // 
            this.dgvVideoQuality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVideoQuality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideoQuality.Location = new System.Drawing.Point(42, 121);
            this.dgvVideoQuality.MultiSelect = false;
            this.dgvVideoQuality.Name = "dgvVideoQuality";
            this.dgvVideoQuality.RowHeadersVisible = false;
            this.dgvVideoQuality.RowHeadersWidth = 51;
            this.dgvVideoQuality.RowTemplate.Height = 29;
            this.dgvVideoQuality.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVideoQuality.Size = new System.Drawing.Size(838, 146);
            this.dgvVideoQuality.TabIndex = 9;
            // 
            // dgvAudioQuality
            // 
            this.dgvAudioQuality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAudioQuality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAudioQuality.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAudioQuality.Location = new System.Drawing.Point(42, 297);
            this.dgvAudioQuality.MultiSelect = false;
            this.dgvAudioQuality.Name = "dgvAudioQuality";
            this.dgvAudioQuality.RowHeadersVisible = false;
            this.dgvAudioQuality.RowHeadersWidth = 51;
            this.dgvAudioQuality.RowTemplate.Height = 29;
            this.dgvAudioQuality.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAudioQuality.Size = new System.Drawing.Size(836, 146);
            this.dgvAudioQuality.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Video Quality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Audio Quality";
            // 
            // btnShowQualities
            // 
            this.btnShowQualities.Location = new System.Drawing.Point(197, 69);
            this.btnShowQualities.Name = "btnShowQualities";
            this.btnShowQualities.Size = new System.Drawing.Size(133, 29);
            this.btnShowQualities.TabIndex = 13;
            this.btnShowQualities.Text = "Show Qualities";
            this.btnShowQualities.UseVisualStyleBackColor = true;
            this.btnShowQualities.Click += new System.EventHandler(this.btnShowQualities_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "youtube URL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 763);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnShowQualities);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAudioQuality);
            this.Controls.Add(this.dgvVideoQuality);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpAudio.ResumeLayout(false);
            this.tpAudio.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideoQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudioQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TcVideoOrAudio_SelectedIndexChanged1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
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
        private DataGridView dgvVideoQuality;
        private DataGridView dgvAudioQuality;
        private Label label3;
        private Label label4;
        private Button btnShowQualities;
        private Label label5;
        private Label label7;
        private Panel panel3;
        private RadioButton rbToWEBM;
        private RadioButton rbToMKV;
        private RadioButton rbToMP4;
        private Panel panel2;
        private RadioButton rbToOPUS;
        private RadioButton rbToMP3;
        private Label label6;
    }
}