using System.Collections.Generic;

namespace YTDL
{
    public enum AudioBitrate
    {
        Good,
        Great,
        Best
    }
    public enum AudioFormat
    {
        mp3,
        opus
    }

    public enum VideoFormat
    {
        mp4,
        mkv,
        webm
    }

    public class Cmd
    {
        public AudioBitrate AudioBitrate { get; set; }
        public AudioFormat AudioFormat { get; set; }
        public VideoFormat VideoFormat { get; set; }


        public string ExeString => "yt-dlp.exe";
        public string SelectedPath { get; internal set; }

        public bool IsAudio { get; set; }

        public bool DefaultQuality { get; set; }
        public bool DownloadSubtitles { get; set; }
        public bool DownloadPlaylist { get; set; }


        public string Arguments
        {
            get
            {
                var argumentList = new List<string>
                {
                     $"-o \"{SelectedPath}\\%(title)s.%(ext)s\""
                };
                if (IsAudio) 
                {
                    if (DownloadPlaylist) argumentList.Add("--yes-playlist");
                    else argumentList.Add("--no-playlist");

                    argumentList.Add("--extract-audio");
                    if (AudioBitrate == AudioBitrate.Good) argumentList.Add("--audio-quality 5");
                    if (AudioBitrate == AudioBitrate.Great) argumentList.Add("--audio-quality 3");
                    if (AudioBitrate == AudioBitrate.Best) argumentList.Add("--audio-quality 0");

                    if (AudioFormat == AudioFormat.mp3) argumentList.Add("--audio-format mp3");
                    if (AudioFormat == AudioFormat.opus) argumentList.Add("--audio-format opus");
                }
                else
                {
                    if (DownloadPlaylist)
                    {
                        argumentList.Add("--yes-playlist");
                        argumentList.Add("-f best");
                    }
                    else
                    {
                        argumentList.Add("--no-playlist");
                        if (DefaultQuality) argumentList.Add("-f best");
                    }

                    if (DownloadSubtitles) argumentList.Add("--write-sub --write-auto-sub");

                    if (VideoFormat == VideoFormat.mp4) argumentList.Add("--merge-output-format mp4");
                    if (VideoFormat == VideoFormat.mkv) argumentList.Add("--merge-output-format mkv");
                    if (VideoFormat == VideoFormat.webm) argumentList.Add("--merge-output-format webm");
                }
                return string.Join(" ", argumentList);
            }
        }

    }
}
