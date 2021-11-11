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


        private void Cancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
            }
        }

        // This event handler is where the time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {

           
                    worker.ReportProgress(i * 10);
                }
            }
        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {
                resultLabel.Text = "Done!";
            }
        }


        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            rtbLogs.Text = String.Empty;
            var dir = folderBrowserDialog.SelectedPath;
            cmd.setOutputFilePath(folderBrowserDialog.SelectedPath);
            Cursor.Current = Cursors.WaitCursor;
            // Perform a time consuming operation and report progress.
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = cmd.ExeString,
                Arguments = string.Join(" ", cmd.Arguments, tbURL.Text),
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true,
            };
            //Thread th = new Thread(() =>
            //{
            using (Process p = Process.Start(psi))
            {
                StringBuilder sb = new StringBuilder();
                while (!p.StandardOutput.EndOfStream)
                {
                    sb.Append(p.StandardOutput.ReadLine());
                    if (string.IsNullOrWhiteSpace(sb.ToString())) continue;
                    rtbLogs.Text += sb.ToString() + "\n";
                    sb.Clear();
                }
                rtbLogs.Text = rtbLogs.Text.Remove(rtbLogs.Text.Length - 3);
                p.WaitForExit();
            }
            Process.Start("explorer.exe", dir);
            Cursor.Current = Cursors.Default;
            rtbLogs.ScrollToCaret();
            //if (!backgroundWorker1.IsBusy)
            //{
            //    // Start the asynchronous operation.
            //    backgroundWorker1.RunWorkerAsync();
            //}
        }


        public void Doing()
        {

        }

                // Note: You can process p.ExitCode here.  
                //})
                //{ IsBackground = true };
                //th.Start();
                //if (!cmd.IsAudio)
                //{
                //    string pattern = "*.webm";
                //    var directory = new DirectoryInfo(dir);
                //    var myFile = directory.GetFiles(pattern).OrderByDescending(f => f.LastWriteTime).First();
                //    psi = new ProcessStartInfo
                //    {
                //        FileName = "ffmpeg",
                //        Arguments = "- i " + myFile.Name + "- qscale 0 " + myFile.Name.Replace(".webm", ".mp4"),
                //        CreateNoWindow = true,
                //        WindowStyle = ProcessWindowStyle.Hidden,
                //        UseShellExecute = false,
                //        RedirectStandardOutput = true,
                //    };
                //    using (Process p = Process.Start(psi))
                //    {
                //        while (!p.StandardOutput.EndOfStream)
                //        {
                //            string line = p.StandardOutput.ReadLine();
                //            if (string.IsNullOrWhiteSpace(line)) continue;
                //            rtbLogs.Text += line + "\n";
                //        }
                //        rtbLogs.Text = rtbLogs.Text.Remove(rtbLogs.Text.Length - 3);
                //        p.WaitForExit();
                //    }
                //}

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
            => cmd.AudioQuality = AudioQuality.Good;

        private void rbQualityGreat_CheckedChanged(object sender, EventArgs e)
            => cmd.AudioQuality = AudioQuality.Great;

        private void rbQualityBest_CheckedChanged(object sender, EventArgs e)
            => cmd.AudioQuality = AudioQuality.Best;

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
            //})
            //{ IsBackground = true };
            //th.Start();
            Cursor.Current = Cursors.Default;
            rtbLogs.ScrollToCaret();
        }

        private void cbBestVideoQuality_CheckedChanged(object sender, EventArgs e)
            => cmd.BestVideoQuality = cbBestVideoQuality.Checked;

        private void cbFormatToMP3_CheckedChanged(object sender, EventArgs e)
        {
            cmd.IsAudioFormatMP3 = cbFormatToMP3.Checked;
        }

    }
}