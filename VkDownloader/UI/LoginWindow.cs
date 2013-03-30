using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VkDownloader.Data;

namespace VkDownloader.UI
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(String.Format("http://api.vk.com/oauth/authorize?client_id={0}& redirect_uri=http://api.vk.com/blank.html&scope={1}&display=page&response_type=token", StaticData.appId, StaticData.scope));
        }
        private void webBrowser1_DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri.ToString().IndexOf("access_token") != -1)
            {
                string accessToken = "";
                int userId = 0;
                Regex myReg = new Regex(@"(?<name>[\w\d\x5f]+)=(?<value>[^\x26\s]+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                foreach (Match m in myReg.Matches(e.Url.ToString()))
                {
                    if (m.Groups["name"].Value == "access_token")
                    {
                        accessToken = m.Groups["value"].Value;
                    }
                    else if (m.Groups["name"].Value == "user_id")
                    {
                        userId = Convert.ToInt32(m.Groups["value"].Value);
                    }
                }
                if (String.IsNullOrEmpty(accessToken))
                {
                    MessageBox.Show("Ошибка. Ключ доступа не найден.", "Ошибка");
                    return;
                }
                this.Hide();
                new MainWindow(userId, accessToken).Show();
            }
            else if (e.Url.ToString().IndexOf("user_denied") != -1)
            {
                this.Close();
            }
        }
    }
}
