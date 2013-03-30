using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Windows.Forms;
using VK_SDK;
using TagLib;
using VkDownloader.Data.Audio;

namespace VkDownloader.UI
{
    public partial class AudioWindow : Form
    {
        VKController _vkController;
        List<Audio> _vkSongs;
        WebClient _webClient;

        List<Artist> _artists;

        public AudioWindow()
        {
            InitializeComponent();
        }
        public AudioWindow(VKController vkController)
        {
            InitializeComponent();
            _vkController = vkController;
            
            _artists = new List<Artist>();

            libSongsList.DisplayMember = "Name";

            _webClient = new WebClient();
            _webClient.DownloadFileCompleted+=_webClient_DownloadFileCompleted;
            _webClient.DownloadProgressChanged+=_webClient_DownloadProgressChanged;
        }

        void _webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
 	       
        }

        void _webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
 	        Audio audio = e.UserState as Audio;
            string filePath = String.Format("{0}.mp3", audio.ToString());
            TagLib.File tagFile = TagLib.File.Create(filePath);
            string artistName = tagFile.Tag.FirstAlbumArtist == null ? "Unknown artist" : tagFile.Tag.FirstAlbumArtist;
            string albumName = tagFile.Tag.Album == null ? "Unknown album" : tagFile.Tag.Album;
            string title = tagFile.Tag.Title == null ? "Unknown title" : tagFile.Tag.Title;
            var artist = _artists.FirstOrDefault(g => g.Name.ToLower() == artistName.ToLower());
            if (artist == null)
            {
                artist = new Artist(artistName);
                _artists.Add(artist);
            }
            var album = artist.Albums.FirstOrDefault(g => g.Name.ToLower() == albumName.ToLower());
            if (album == null)
            {
                album = new Album(albumName);
                artist.Albums.Add(album);
            }
            var song = album.Songs.FirstOrDefault(g => g.Name.ToLower() == title.ToLower());
            if (song == null)
            {
                song = new Song(title, filePath);
                album.Songs.Add(song);
            }
        }
        private void AudioWindow_Load(object sender, EventArgs e)
        {
            _vkSongs = _vkController.GetSongs();
            vkSongsList.DataSource = _vkSongs;
            libSongsList.DataSource = _artists;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void vkSongsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Audio audio in vkSongsList.SelectedItems)
            {
                _webClient.DownloadFileAsync(new Uri(audio.URL),String.Format("{0}.mp3",audio.Name),audio);
            }
        }
    }
}
