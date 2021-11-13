using System.Diagnostics;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Text;

namespace YTDL
{
    public partial class Form1 : Form
    {
        public Cmd cmd { get; set; }
        string c = "";
        public Form1()
        {
            InitializeComponent();
            //tbCommand.Text = youtubedl + " " + argumentList[0];
            //c = tbCommand.Text;
            cmd = new Cmd();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        //private bool isInvalidURL()
        //{
        //    if (!tbURL.Text.Contains("https://www.youtube.com/"))
        //    {
        //        MessageBox.Show("Enter valid Youtube URL", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return true;
        //    }
        //    return false;
        //}
        private void btnExecute_Click(object sender, EventArgs e)
        {
            var dgvVideoCellsValue = dgvVideoQuality.SelectedCells;
            var dgvAudioCellsValue = dgvAudioQuality.SelectedCells;
            var audioQty = "";
            var videoQty = "";
            if (dgvAudioCellsValue.Count == 0 || dgvVideoCellsValue.Count == 0)
            {
                cmd.DefaultQuality = true;
            }
            else
            {
                audioQty = dgvAudioCellsValue[0].Value.ToString().Split(' ')[0];
                videoQty = dgvVideoCellsValue[0].Value.ToString().Split(' ')[0];

            }
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            rtbLogs.Text = String.Empty;
            var dir = folderBrowserDialog.SelectedPath;
            cmd.SelectedPath = folderBrowserDialog.SelectedPath;
            Cursor.Current = Cursors.WaitCursor;
            // Perform a time consuming operation and report progress.
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = cmd.ExeString,
                Arguments = string.Join(" ", cmd.Arguments, cmd.DefaultQuality ? "-f best" : cmd.IsAudio ? $"-f {audioQty}" : $"-f {videoQty}+{audioQty}", tbURL.Text),
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true,
            };

            using (Process p = Process.Start(psi))
            {
                StringBuilder sb = new StringBuilder();
                while (!p.StandardOutput.EndOfStream)
                {

                    sb.Clear();
                    sb.Append(p.StandardOutput.ReadLine());
                    if (string.IsNullOrWhiteSpace(sb.ToString())) continue;

                    rtbLogs.Text += sb.AppendLine().ToString();
                }
                p.WaitForExit();
                rtbLogs.ScrollToCaret();
                if (p.ExitCode != 0)
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Process.Start("explorer.exe", dir);

        }

        private void btnShowQualities_Click(object sender, EventArgs e)
        {
            IList<string> list_string_audio = new List<string>();
            IList<string> list_string_video = new List<string>();
            int count = 0;
            bool flag = false;

            var psi = new ProcessStartInfo
            {
                FileName = cmd.ExeString,
                Arguments = "-F " + tbURL.Text,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true,
            };
            using Process p = Process.Start(psi);

            StringBuilder strBuil = new();
            while (!p.StandardOutput.EndOfStream)
            {
                strBuil.Clear().Append(p.StandardOutput.ReadLine());
                if (string.IsNullOrWhiteSpace(strBuil.ToString())) continue;
                if (strBuil.ToString().Contains("Available formats for"))
                {
                    flag = true;
                    continue;
                }
                if (flag == true && count < 3) count++;

                if (flag && count == 3)
                {
                    if (strBuil.ToString().Contains("DASH")) continue;
                    if (strBuil.ToString().Contains("audio only"))
                    {
                        list_string_audio.Add(strBuil.ToString());
                    }
                    else
                    {
                        list_string_video.Add(strBuil.ToString());
                    }
                }
                //if (string.IsNullOrWhiteSpace(strBuil.ToString())) continue;
                //rtbLogs.Text += strBuil.AppendLine().ToString();
            }
            p.WaitForExit();

            if (p.ExitCode != 0)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dgvAudioQuality.DataSource = list_string_audio.Select(x => new { Value = x }).ToList();
            dgvVideoQuality.DataSource = list_string_video.Select(x => new { Value = x }).ToList();

            int nRowIndex = dgvAudioQuality.Rows.Count - 1;
            dgvAudioQuality.Rows[nRowIndex].Selected = true;
            dgvAudioQuality.Rows[nRowIndex].Cells[0].Selected = true;
            dgvAudioQuality.FirstDisplayedScrollingRowIndex = nRowIndex;

            nRowIndex = dgvVideoQuality.Rows.Count - 1;
            dgvVideoQuality.Rows[nRowIndex].Selected = true;
            dgvVideoQuality.Rows[nRowIndex].Cells[0].Selected = true;
            dgvVideoQuality.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void btnUpdater(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = cmd.ExeString,
                Arguments = "-U",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true,
            };
            using (Process p = Process.Start(psi))
            {
                while (!p.StandardOutput.EndOfStream)
                {
                    string line = p.StandardOutput.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    rtbLogs.Text += line + "\n";
                }
                rtbLogs.Text = rtbLogs.Text.Remove(rtbLogs.Text.Length - 3);
                p.WaitForExit();
                // Note: You can process p.ExitCode here.  
            }

            Cursor.Current = Cursors.Default;
            rtbLogs.ScrollToCaret();
        }

        private void cbDownloadPlaylist_CheckedChanged(object sender, EventArgs e)
            => cmd.DownloadPlaylist = cbDownloadPlaylist.Checked;

        private void cbSubs_CheckedChanged(object sender, EventArgs e)
            => cmd.DownloadSubtitles = cbSubs.Checked;

        private void rtbLogs_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtbLogs.SelectionStart = rtbLogs.Text.Length;
            // scroll it automatically
            rtbLogs.ScrollToCaret();
        }

        private void TcVideoOrAudio_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tcVideoOrAudio.SelectedIndex == 1)
            {
                cmd.IsAudio = true;
            }
            else
            {
                cmd.IsAudio = false;
            }
        }

        private void rbQualityGood_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToMP4.Checked) cmd.AudioBitrate = AudioBitrate.Good;
        }

        private void rbQualityGreat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToMP4.Checked) cmd.AudioBitrate = AudioBitrate.Great;
        }

        private void rbQualityBest_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToMP4.Checked) cmd.AudioBitrate = AudioBitrate.Best;
        }

        private void cbBestVideoQuality_CheckedChanged(object sender, EventArgs e)
            => cmd.DefaultQuality = cbBestVideoQuality.Checked;


        private void rbToMP3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToMP3.Checked) cmd.AudioFormat = AudioFormat.mp3;
        }

        private void rbToOPUS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToOPUS.Checked) cmd.AudioFormat = AudioFormat.opus;
        }



        private void rbMP4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToMP4.Checked) cmd.VideoFormat = VideoFormat.mp4;
        }

        private void rbMKV_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToMKV.Checked) cmd.VideoFormat = VideoFormat.mkv;
        }

        private void rbWEBM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbToWEBM.Checked) cmd.VideoFormat = VideoFormat.webm;
        }
    }
}