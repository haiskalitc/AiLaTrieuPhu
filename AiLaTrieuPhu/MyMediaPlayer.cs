using MediaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu
{
    public class MyMediaPlayer
    {
        public string Current = "";
        private MyMediaPlayer()
        {
            CrossMediaManager.Wpf.Init();
            CrossMediaManager.Wpf.MediaItemFinished += Wpf_MediaItemFinished;
        }

        private async void Wpf_MediaItemFinished(object sender, MediaManager.Media.MediaItemEventArgs e)
        {
            await CrossMediaManager.Wpf.Play(Current);
        }

        public static MyMediaPlayer getInstance { get { return NestedSelenium.instance; } }
        private class NestedSelenium
        {
            static NestedSelenium()
            {
            }
            internal static readonly MyMediaPlayer instance = new MyMediaPlayer();
        }

        public async void PlayMusic(string path)
        {
            string startupPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Music\\" + path + ".mp3";
            Current = startupPath;
            //await CrossMediaManager.Wpf.Stop();
            await CrossMediaManager.Wpf.Play(startupPath);
        }
        public async void StopMusic()
        {
            await CrossMediaManager.Wpf.Stop();
        }
    }
}
