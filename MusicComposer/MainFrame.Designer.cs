using NAudio.Midi;
using System.Collections;

namespace MusicComposer
{
    partial class MainFrame
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        int width = 1200, height = 800;

        #region Windows Form Designer generated code
        public MenuControl menuControl;
        public ComposeControl composeControl;
        public TracksControl tracksControl;
        public EditControl editControl;
        public MidiOut play;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            menuControl = new MenuControl();
            tracksControl = new TracksControl();
            composeControl = new ComposeControl();
            editControl = new EditControl();
            play = new MidiOut(0);
            menuControl.Show();
            composeControl.Hide();
            editControl.Hide();
            tracksControl.Hide();
            // 
            // MainFrame
            // 
            ClientSize = new Size(width, height);
            Controls.Add(menuControl);
            Controls.Add(tracksControl);
            Controls.Add(composeControl);
            Controls.Add(editControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainFrame";
            this.ResumeLayout();
        }

        public void toTracksFromMenu()
        {
            tracksControl.loadTracks();
            tracksControl.Show();
        }
        public void toMenuFromTracks()
        {
            menuControl.Show();
        }

        public void toEditFromTracks(string trackName, ArrayList track)
        {
            editControl.loadTrack(trackName, track);
            editControl.Show();
        }

        public void toTracksFromEdit()
        {
            tracksControl.Show();
        }

        public void toComposeFromMenu()
        {
            composeControl.Show();
        }
        public void toMenuFromCompose()
        {
            menuControl.Show();
        }

        public MidiOut getMidi() { return play; }

        #endregion
    }
}