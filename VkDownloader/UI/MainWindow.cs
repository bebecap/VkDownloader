using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VK_SDK;

namespace VkDownloader.UI
{
    public partial class MainWindow : Form
    {

        public int UserID;
        public string Token;
        private VKController _vkController;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(int userid, string token)
        {
            InitializeComponent();
            UserID = userid;
            Token = token;
            _vkController = new VKController(userid, token, "");
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void audioBtn_Click(object sender, EventArgs e)
        {
            new AudioWindow(_vkController).Show();
            this.Hide();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
