using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace YTDL
{
    public enum AudioQuality
    {
        Good = 5,
        Great = 8,
        Best = 10
    }

    public class Cmd
    {
        public string OutputFilePath { get; set; }
        public bool IsAudio { get; set; }
        public string ArgIsAudio => "--extract-audio";
        public bool IsAudioFormatMP3 { get; set; }
        public string ArgAudioFormat => "--audio-format mp3";
        public string ArgAudioQualityGood => "--audio-quality 5";
        public string ArgAudioQualityGreat => "--audio-quality 3";
        public string ArgAudioQualityBest => "--audio-quality 0";
        public AudioQuality AudioQuality { get; set; }

        public bool BestVideoQuality { get; set; }
        public string ArgBestVideoQuality => "-f bestvideo+bestaudio";

        public string ExeString => "yt-dlp.exe";
        public bool DownloadSubtitles { get; set; }
        public string ArgDownloadSubtitles => "--write-sub --write-auto-sub";

        public bool DownloadPlaylist { get; set; }
        public string ArgDownloadPlaylist => "--yes-playlist";

        public void setOutputFilePath(string SelectedPath)
        {
            OutputFilePath = "-o " + SelectedPath + "\\%(title)s.%(ext)s";

        }
        public string Arguments
        {
            get
            {
                var argumentList = new List<string>();
                argumentList.Add(OutputFilePath);
                if (!IsAudio)
                {
                    if (DownloadSubtitles) argumentList.Add(ArgDownloadSubtitles);
                    if (BestVideoQuality) argumentList.Add(ArgBestVideoQuality);
                }
                else
                {
                    argumentList.Add(ArgIsAudio);
                    if (AudioQuality == AudioQuality.Good) argumentList.Add(ArgAudioQualityGood);
                    if (AudioQuality == AudioQuality.Great) argumentList.Add(ArgAudioQualityGreat);
                    if (AudioQuality == AudioQuality.Best) argumentList.Add(ArgAudioQualityBest);
                    if (IsAudioFormatMP3) argumentList.Add(ArgAudioFormat);
                }
                if (DownloadPlaylist) argumentList.Add(ArgDownloadPlaylist);
                return string.Join(" ", argumentList);
            }
        }


    }
}
