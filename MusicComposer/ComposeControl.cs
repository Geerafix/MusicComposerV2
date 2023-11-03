using NAudio.Midi;

namespace MusicComposer {
    public partial class ComposeControl : UserControl {
        private List<Note> track = new List<Note>();
        private Thread thread;
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

        public ComposeControl() {
            InitializeComponent();
        }

        private void toMenuButton_Click(object sender, EventArgs e) {
            ((MainFrame)this.ParentForm).toMenuFromCompose();
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e) {
            if (!trackNameTextBox.Visible) {
                saveButton.Text = "✓";
                trackNameTextBox.Show();
            } else if (trackNameTextBox.Visible) {
                if (trackNameTextBox.Text != "") {
                    string trackName = trackNameTextBox.Text;
                    trackNameTextBox.Text = null;
                    StreamWriter writer = new StreamWriter("../../../tracks/" + trackName + ".txt");
                    foreach (Note note in track) {
                        writer.WriteLine(note.getNumber());
                        writer.WriteLine(note.getDuration());
                    }
                    writer.Close();
                    track.Clear();
                    pos = 0;
                    currentNote = 0;
                    currentDuration = 500;
                    noteLabel.Text = noteConv(notes[currentNote]);
                    position.Text = (pos + 1).ToString();
                    noteCount.Text = pos.ToString();
                    durationLabel.Text = currentDuration.ToString();
                    trackNotesListBox.Items.Clear();
                }
                saveButton.Text = "Save";
                trackNameTextBox.Hide();
            }
        }

        private void noteUp_Click(object sender, EventArgs e) {
            if (currentNote == notes.Length - 1) {
                currentNote = 0;
            } else {
                ++currentNote;
            }
            noteLabel.Text = noteConv(notes[currentNote]);
        }

        private void noteDown_Click(object sender, EventArgs e) {
            if (currentNote == 0) {
                currentNote = notes.Length - 1;
            } else {
                --currentNote;
            }
            noteLabel.Text = noteConv(notes[currentNote]);
        }

        private void durationUp_Click(object sender, EventArgs e) {
            if (currentDuration != 5000) {
                currentDuration += 50;
            }
            durationLabel.Text = currentDuration.ToString();
        }

        private void durationDown_Click(object sender, EventArgs e) {
            if (currentDuration != 50) {
                currentDuration -= 50;
            }
            durationLabel.Text = currentDuration.ToString();
        }

        private void playNoteButton_Click(object sender, EventArgs e) {
            thread = new Thread(() => {
                MidiOut play = ((MainFrame)this.ParentForm).getMidi();
                play.Send(MidiMessage.StartNote(notes[currentNote], 127, 1).RawData);
                Thread.Sleep(currentDuration);
                play.Send(MidiMessage.StopNote(notes[currentNote], 0, 1).RawData);
            });
            thread.Start();
        }

        private void addNoteButton_Click(object sender, EventArgs e) {
            if (pos == track.Count && track.Count < 60) {
                track.Add(new Note(notes[currentNote], currentDuration));
                noteCount.Text = track.Count.ToString();
                pos += 1;
                position.Text = (pos + 1).ToString();
                trackNotesListBox.Items.Add(" " + noteConv(notes[currentNote]) + " " + currentDuration);
            } else if (pos < track.Count) {
                track[pos] = new Note(notes[currentNote], currentDuration);
                trackNotesListBox.Items[pos] = " " + noteConv(notes[currentNote]) + " " + currentDuration;
            }
        }

        private void deleteNoteButton_Click(object sender, EventArgs e) {
            if (pos < track.Count) {
                track.Remove(track[pos]);
                if (track.Count != 0 && pos != track.Count) {
                    currentNote = track[pos].getNumber() - 24;
                    currentDuration = track[pos].getDuration();
                } else {
                    currentNote = 0;
                    currentDuration = 500;
                }

                noteLabel.Text = noteConv(notes[currentNote]).ToString();
                durationLabel.Text = currentDuration.ToString();
                noteCount.Text = track.Count.ToString();
                trackNotesListBox.Items.RemoveAt(pos);
            }

            if (pos == track.Count) {
                addNoteButton.Text = "+";
            }
        }

        public void previousNoteButton_Click(object sender, EventArgs e) {
            if (pos > 0) {
                pos -= 1;
                currentNote = track[pos].getNumber() - 24;
                currentDuration = track[pos].getDuration();
                position.Text = (pos + 1).ToString();
                noteLabel.Text = noteConv(notes[currentNote]).ToString();
                durationLabel.Text = currentDuration.ToString();
            }

            if (pos < track.Count) {
                addNoteButton.Text = "✎";
            }
        }

        public void nextNoteButton_Click(object sender, EventArgs e) {
            if (pos < track.Count) {
                pos += 1;
            }

            if (pos < track.Count) {
                currentNote = track[pos].getNumber() - 24;
                currentDuration = track[pos].getDuration();
                noteLabel.Text = noteConv(notes[currentNote]).ToString();
                durationLabel.Text = currentDuration.ToString();
            }

            if (pos == track.Count) {
                addNoteButton.Text = "+";
            }

            position.Text = (pos + 1).ToString();
        }

        public string noteConv(int noteNumber) {
            string[] noteNames = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            return noteNames[noteNumber % 12] + ((noteNumber / 12) - 1);
        }



        /*        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Hide();
            stopButton.Show();
            playThread = new Thread(playing);
            run = true;
            playThread.Start();
        }*/

        /*        private void playing(object obj)
				{
					foreach (Note note in track)
					{
						if (run == true)
						{
							play.Send(MidiMessage.StartNote(note.getNumber(), 127, 1).RawData);
							Thread.Sleep(note.getDuration());
							play.Send(MidiMessage.StopNote(note.getNumber(), 0, 1).RawData);
						} 
						else
						{
							break;
						}
					}
					stopButton.Hide();
					playButton.Show();
				}*/

        /*        private void stopButton_Click(object sender, EventArgs e)
				{
					stopButton.Hide();
					playButton.Show();
					run = false;

				}*/
    }
}
