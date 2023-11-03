using NAudio.Midi;
using System.Collections;

namespace MusicComposer
{
    public partial class TracksControl : UserControl
    {
        private FileInfo[] tracks;
        private DirectoryInfo directory;
        private Thread thread;
        private string path = "../../../tracks/";
        private int id;

        public TracksControl()
        {
            InitializeComponent();
            directory = new DirectoryInfo(path);
        }

        public void loadTracks()
        {
            tracksListBox.Items.Clear();
            tracks = directory.GetFiles("*.txt");
            foreach (FileInfo file in tracks)
            {
                tracksListBox.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            ((MainFrame)this.ParentForm).toMenuFromTracks();
            this.Hide();
            hideButtons();
        }

        private void modifyTrackButton_Click(object sender, EventArgs e)
        {
            ((MainFrame)this.ParentForm).toEditFromTracks(tracksListBox.Items[id].ToString(), toList(tracksListBox.Items[id].ToString()));
            this.Hide();
            hideButtons();
        }

        private void tracksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((id = tracksListBox.SelectedIndex) != -1)
            {
                deleteTrackButton.Show();
                modifyTrackButton.Show();
                playTrackButton.Show();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            tracks[id].Delete();
            tracksListBox.Items.RemoveAt(id);
            hideButtons();
        }

        private void playTrackButton_Click(Object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(path + tracksListBox.Items[id].ToString() + ".txt");
            thread = new Thread(() =>
            {
                MidiOut play = ((MainFrame)this.ParentForm).getMidi();
                for (int i = 0; i < lines.Length; i += 2)
                {
                    play.Send(MidiMessage.StartNote(Int32.Parse(lines[i]), 127, 1).RawData);
                    Thread.Sleep(Int32.Parse(lines[i + 1]));
                    play.Send(MidiMessage.StopNote(Int32.Parse(lines[i]), 127, 1).RawData);
                }
            });
            thread.Start();
        }

        public void hideButtons()
        {
            deleteTrackButton.Hide();
            modifyTrackButton.Hide();
            playTrackButton.Hide();
        }

        private List<Note> toList(string filename)
        {
            List<Note> track = new List<Note>();
            string[] lines = File.ReadAllLines(path + filename + ".txt");
            for (int i = 0; i < lines.Length; i += 2)
            {
                track.Add(new Note(Int32.Parse(lines[i]), Int32.Parse(lines[i + 1])));
            }
            return track;
        }

        private void TracksControl_Load(object sender, EventArgs e)
        {

        }
    }
}
