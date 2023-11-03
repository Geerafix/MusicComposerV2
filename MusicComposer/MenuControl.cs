namespace MusicComposer
{
	public partial class MenuControl : UserControl
	{
		public MenuControl()
		{
			InitializeComponent();
		}

		private void tracksButton_Click(object sender, EventArgs e)
		{
			((MainFrame)this.ParentForm).toTracksFromMenu();
			this.Hide();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void composeButton_Click(object sender, EventArgs e)
		{
			((MainFrame)this.ParentForm).toComposeFromMenu();
			this.Hide();
		}
	}
}
