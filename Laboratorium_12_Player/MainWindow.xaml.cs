using System.Windows;
using System.Windows.Threading;
using Microsoft.Win32;

namespace Laboratorium_12_Player;

public partial class MainWindow : Window
{
    private DispatcherTimer timer;
    private Random random = new Random();

    public MainWindow()
    {
        InitializeComponent();
        timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
        timer.Tick += Timer_Tick;
        MediaElement.Volume = 0.5;
        BtnPlay.IsEnabled = false;
        BtnPause.IsEnabled = false;
        BtnStop.IsEnabled = false;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        if (MediaElement.NaturalDuration.HasTimeSpan)
        {
            ProgressSlider.Maximum = MediaElement.NaturalDuration.TimeSpan.TotalSeconds;
            ProgressSlider.Value = MediaElement.Position.TotalSeconds;
        }
    }

    private void btnPlay_Click(object sender, RoutedEventArgs e)
    {
        MediaElement.Play();
        timer.Start();
        BtnPlay.IsEnabled = false;
    }

    private void btnPause_Click(object sender, RoutedEventArgs e)
    {
        MediaElement.Pause();
        timer.Stop();
        BtnPlay.IsEnabled = true;
    }

    private void btnStop_Click(object sender, RoutedEventArgs e)
    {
        MediaElement.Stop();
        timer.Stop();
        ProgressSlider.Value = 0;
        BtnStop.IsEnabled = false;
        BtnPlay.IsEnabled = true;
    }

    private void BtnOpen_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "Audio Files|*.mp3;*.wav;*.wma;*.aac;*.m4a;*.flac",
            Title = "Open Audio File",
            InitialDirectory = "c:\\data"
        };

        if (openFileDialog.ShowDialog() == true)
        {
            MediaElement.Source = new Uri(openFileDialog.FileName);
            SongList.Items.Add(openFileDialog.FileName);
            MediaElement.Play();
            timer.Start();
            BtnPause.IsEnabled = true;
            BtnStop.IsEnabled = true;
            ReadMetadata(openFileDialog.FileName);
        }
    }

    private void ProgressSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        if (Math.Abs(MediaElement.Position.TotalSeconds - ProgressSlider.Value) > 1)
        {
            MediaElement.Position = TimeSpan.FromSeconds(ProgressSlider.Value);
        }
    }

    private void SongList_OnSelected(object sender, RoutedEventArgs e)
    {
        string song = (string)SongList.SelectedItem;
        MediaElement.Source = new Uri(song);
        MediaElement.Play();
        timer.Start();
        BtnPause.IsEnabled = true;
        BtnStop.IsEnabled = true;
    }
    
    private void ReadMetadata(string filePath)
    {
        try
        {
            var file = TagLib.File.Create(filePath);
            string title = file.Tag.Title ?? "Unknown Title";
            string artist = file.Tag.FirstPerformer ?? "Unknown Artist";
            string album = file.Tag.Album ?? "Unknown Album";
            uint year = file.Tag.Year;
            string lenght= file.Tag.Length;

            SongTitle.Text = $"Title: {title}\nArtist: {artist}\nAlbum: {album}\nYear: {year}\nLength: {lenght}";
        }
        catch (Exception ex)
        {
            SongTitle.Text = "Error reading metadata: " + ex.Message;
        }
    }

}
