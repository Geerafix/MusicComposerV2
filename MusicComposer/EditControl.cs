using System.Collections;

namespace MusicComposer
{
	public partial class EditControl : UserControl
	{
		private ArrayList track;
		private string trackName;
		private int pos = 0, currentNote = 0, currentDuration = 500;
		private int[] notes = {
			24, 25, 26, 27, 28, 29, 30, 31, 32, 33,
			34, 35, 36, 37, 38, 39, 40, 41, 42, 43,
			44, 45, 46, 47, 48, 49, 50, 51, 52, 53,
			54, 55, 56, 57, 58, 59, 60, 61, 62, 63,
			64, 65, 66, 67, 68, 69, 70, 71, 72, 73,
			74, 75, 76, 77, 78, 79, 80, 81, 82, 83,
			84, 85, 86, 87, 88, 89, 90, 91, 92, 93,
			94, 95, 96, 97, 98, 99, 100, 101, 102
		};

		public EditControl()
		{
			InitializeComponent();
		}

		public void loadTrack(string trackName, ArrayList track)
		{
			this.trackName = trackName;
			this.track = track;
			foreach (Note note in track)
			{
				trackNotesListBox.Items.Add(" " + noteConv(note.getNumber()) + " " + note.getDuration());
			}

			if (track.Count > 0)
			{
				Note temp = (Note)track[0];
				currentNote = temp.getNumber();
				currentDuration = temp.getDuration();
				noteLabel.Text = noteConv(currentNote).ToString();
				durationLabel.Text = currentDuration.ToString();
				noteCount.Text = track.Count.ToString();
			}
		}

		private void toTracksButton_Click(object sender, EventArgs e)
		{
			((MainFrame)this.ParentForm).toTracksFromEdit();
			this.Hide();
			trackNotesListBox.Items.Clear();
		}

		public string noteConv(int noteNumber)
		{
			string[] noteNames = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
			return (noteNames[noteNumber % 12] + ((noteNumber / 12) - 1));
		}
	}
}
