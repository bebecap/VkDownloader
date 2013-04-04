using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VKD.BL;
using VKD.DAL;

namespace VKD.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            loginWindowVK.ScriptErrorsSuppressed = true;
        }

        private void loginWindowVK_DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
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
                Library library = new Library();
                library.SetAccountData(userId, accessToken);
                var window = new AudioWindow(library);
                window.Show();
                
            }
            else if (e.Url.ToString().IndexOf("user_denied") != -1)
            {
                this.Close();
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            loginWindowVK.Navigate(String.Format("http://api.vk.com/oauth/authorize?client_id={0}&redirect_uri=http://oauth.vk.com/blank.html&scope={1}&display=page&response_type=token", ConfigurationSettings.AppSettings["AppID"], ConfigurationSettings.AppSettings["Scope"]));
        }
    }
}
