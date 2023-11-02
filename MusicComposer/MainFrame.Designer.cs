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
        public UserControl menuControl, tracksControl, composeControl;

        private void InitializeComponent()
        {
            menuControl = new MenuControl();
            tracksControl = new TracksControl();
            composeControl = new ComposeControl();
            SuspendLayout();
            // 
            // menuControl
            // 
            menuControl.Dock = DockStyle.Fill;
            menuControl.Location = new Point(0, 0);
            menuControl.Name = "menuControl";
            menuControl.Size = new Size(width, height);
            menuControl.TabIndex = 0;
            menuControl.Load += menuControl_Load;
            // 
            // MainFrame
            // 
            ClientSize = new Size(width, height);
            Controls.Add(menuControl);
            Controls.Add(tracksControl);
            Controls.Add(composeControl);
            Name = "MainFrame";
            ResumeLayout(false);
        }

        public void toTracksFromMenu()
        {
            menuControl.Hide();
            composeControl.Hide();
            tracksControl.Show();
        }
        public void toMenuFromTracks()
        {
            tracksControl.Hide();
            composeControl.Hide();
            menuControl.Show();
        }

        public void toEditFromTracks()
        {

        }
        public void toTracksFromEdit()
        {

        }
        public void toComposeFromMenu()
        {
            menuControl.Hide();
            tracksControl.Hide();
            composeControl.Show();
        }
        public void toMenuFromCompose()
        {
            composeControl.Hide();
            tracksControl.Hide();
            menuControl.Show();
        }


        #endregion
    }
}