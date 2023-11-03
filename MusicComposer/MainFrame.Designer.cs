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
        public MidiOut play = new MidiOut(0);

        private void InitializeComponent()
        {
            menuControl = new MenuControl();
            tracksControl = new TracksControl();
            composeControl = new ComposeControl();
            editControl = new EditControl();
            SuspendLayout();
            // 
            // menuControl
            // 
            menuControl.BackColor = Color.FromArgb(32, 37, 50);
            menuControl.Location = new Point(0, 0);
            menuControl.Name = "menuControl";
            menuControl.Size = new Size(1200, 800);
            menuControl.TabIndex = 0;
            menuControl.Visible = true;
            // 
            // tracksControl
            // 
            tracksControl.BackColor = Color.Transparent;
            tracksControl.Location = new Point(0, 0);
            tracksControl.Name = "tracksControl";
            tracksControl.Size = new Size(1200, 800);
            tracksControl.TabIndex = 1;
            tracksControl.Visible = false;
            // 
            // composeControl
            // 
            composeControl.BackColor = Color.Transparent;
            composeControl.Location = new Point(0, 0);
            composeControl.Name = "composeControl";
            composeControl.Size = new Size(1200, 800);
            composeControl.TabIndex = 2;
            composeControl.Visible = false;
            // 
            // editControl
            // 
            editControl.BackColor = Color.Transparent;
            editControl.Location = new Point(0, 0);
            editControl.Name = "editControl";
            editControl.Size = new Size(1200, 800);
            editControl.TabIndex = 3;
            editControl.Visible = false;
            // 
            // MainFrame
            // 
            BackColor = ColorTranslator.FromHtml("#1f2430");
            ClientSize = new Size(1200, 800);
            Controls.Add(menuControl);
            Controls.Add(tracksControl);
            Controls.Add(composeControl);
            Controls.Add(editControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainFrame";
            ResumeLayout(false);
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

        public void toEditFromTracks(string trackName, List<Note> track)
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