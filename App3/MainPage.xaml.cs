using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MaximizeWindowOnload();
        }

        private static void MaximizeWindowOnload()
        {
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }



        private MediaState state = MediaState.Stopped;
        private SongPlaying song = SongPlaying.None;

//FreightTrain Click Handler
        private void PlayFreightTrain_Click(object sender, RoutedEventArgs e)
        {
            //When no song is playing
            if (song == SongPlaying.None)
            {
                state = MediaState.Playing;
                song = SongPlaying.FreightTrain;
                freightTrain_MediaElement.Play();
            }
            else if (song == SongPlaying.FreightTrain)
            {
                state = MediaState.Paused;
                song = SongPlaying.None;
                freightTrain_MediaElement.Pause();
            }
            else if (song == SongPlaying.BradGuitar)
            {
                state = MediaState.Playing;
                song = SongPlaying.FreightTrain;
                bradGuitar_MediaElement.Pause();
                freightTrain_MediaElement.Play();
            }
            else if (song == SongPlaying.WagonWheel)
            {
                state = MediaState.Playing;
                song = SongPlaying.FreightTrain;
                wagonWheel_MediaElement.Pause();
                freightTrain_MediaElement.Play();
            }
            else if (song == SongPlaying.KathyMov)
            {
                state = MediaState.Playing;
                song = SongPlaying.FreightTrain;
                kathyMov_MediaElement.Pause();
                freightTrain_MediaElement.Play();
            }

        }

        private void freighttrain_MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            state = MediaState.Stopped;
        }





//BradGuitar Click Handler
        private void PlayBradGuitar_Click(object sender, RoutedEventArgs e)
        {

            if (song == SongPlaying.None)
            {
                state = MediaState.Playing;
                song = SongPlaying.FreightTrain;
                bradGuitar_MediaElement.Play();
            }
            else if (song == SongPlaying.BradGuitar)
            {
                state = MediaState.Paused;
                song = SongPlaying.None;
                bradGuitar_MediaElement.Pause();
            }
            else if (song == SongPlaying.FreightTrain)
            {
                state = MediaState.Playing;
                song = SongPlaying.BradGuitar;
                freightTrain_MediaElement.Pause();
                bradGuitar_MediaElement.Play();
            }
            else if (song == SongPlaying.KathyMov)
            {
                state = MediaState.Playing;
                song = SongPlaying.BradGuitar;
                kathyMov_MediaElement.Pause();
                bradGuitar_MediaElement.Play();
            }
            else if (song == SongPlaying.WagonWheel)
            {
                state = MediaState.Playing;
                song = SongPlaying.BradGuitar;
                wagonWheel_MediaElement.Pause();
                bradGuitar_MediaElement.Play();
            }
        }

//WagonWheel Click Handler
        private void PlayWagonWheel_Click(object sender, RoutedEventArgs e)
        {
            if (song == SongPlaying.None)
            {
                state = MediaState.Playing;
                song = SongPlaying.WagonWheel;
                wagonWheel_MediaElement.Play();
            }
            else if (song == SongPlaying.WagonWheel)
            {
                state = MediaState.Paused;
                song = SongPlaying.None;
                wagonWheel_MediaElement.Pause();
            }
            else if (song == SongPlaying.FreightTrain)
            {
                state = MediaState.Playing;
                song = SongPlaying.WagonWheel;
                freightTrain_MediaElement.Pause();
                wagonWheel_MediaElement.Play();
            }
            else if (song == SongPlaying.BradGuitar)
            {
                state = MediaState.Playing;
                song = SongPlaying.WagonWheel;
                bradGuitar_MediaElement.Pause();
                wagonWheel_MediaElement.Play();
            }
            else if (song == SongPlaying.KathyMov)
            {
                state = MediaState.Playing;
                song = SongPlaying.WagonWheel;
                kathyMov_MediaElement.Pause();
                wagonWheel_MediaElement.Play();
            }
        }

//KathyMov Click Handler
        private void PlayKathyMov_Click(object sender, RoutedEventArgs e)
        {
            if (song == SongPlaying.None)
            {
                state = MediaState.Playing;
                song = SongPlaying.KathyMov;
                kathyMov_MediaElement.Play();
            }
            else if (song == SongPlaying.KathyMov)
            {
                state = MediaState.Paused;
                song = SongPlaying.None;
                kathyMov_MediaElement.Pause();
            }
            else if (song == SongPlaying.FreightTrain)
            {
                state = MediaState.Playing;
                song = SongPlaying.KathyMov;
                freightTrain_MediaElement.Pause();
                kathyMov_MediaElement.Play();
            }
            else if (song == SongPlaying.BradGuitar)
            {
                state = MediaState.Playing;
                song = SongPlaying.KathyMov;
                bradGuitar_MediaElement.Pause();
                kathyMov_MediaElement.Play();
            }
            else if (song == SongPlaying.WagonWheel)
            {
                state = MediaState.Playing;
                song = SongPlaying.KathyMov;
                wagonWheel_MediaElement.Pause();
                kathyMov_MediaElement.Play();
            }
        }

        //Media State Machine
        public enum MediaState
        {
            Stopped,
            Playing,
            Paused
        }

//Song Selection State Machine
        public enum SongPlaying
        {
            FreightTrain,
            BradGuitar,
            KathyMov,
            WagonWheel,
            None
        }


    }
}
