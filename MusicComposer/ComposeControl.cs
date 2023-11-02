using NAudio.Midi;
using NAudio.Wave.SampleProviders;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Channels;

namespace MusicComposer
{
    public partial class ComposeControl : UserControl
    {
        int pos = 0, nts = 0, currentNote = 0, currentDuration = 500;
        MidiOut play;
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

        public ComposeControl()
        {
            InitializeComponent();
            play = new MidiOut(0);
        }

        public void toMenuButton_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainFrame).toMenuFromCompose();
        }

        private void noteUp_Click(object sender, EventArgs e)
        {
            if (currentNote == notes.Length - 1)
            {
                currentNote = 0;
            }
            else
            {
                ++currentNote;
            }
            noteLabel.Text = noteConv(notes[currentNote]);
        }

        private void noteDown_Click(object sender, EventArgs e)
        {
            if (currentNote == 0)
            {
                currentNote = notes.Length - 1;
            }
            else
            {
                --currentNote;
            }
            noteLabel.Text = noteConv(notes[currentNote]);
        }

        private void durationUp_Click(object sender, EventArgs e)
        {
            if (currentDuration != 5000)
            {
                currentDuration += 50;
            }
            durationLabel.Text = currentDuration.ToString();
        }

        private void durationDown_Click(object sender, EventArgs e)
        {
            if (currentDuration != 50)
            {
                currentDuration -= 50;
            }
            durationLabel.Text = currentDuration.ToString();
        }

        private void playNoteButton_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() =>
            {
                play.Send(MidiMessage.StartNote(notes[currentNote], 127, 1).RawData);
                Thread.Sleep(currentDuration);
                play.Send(MidiMessage.StopNote(notes[currentNote], 0, 1).RawData);
            });
            thread.Start();
        }

        public string noteConv(int noteNumber)
        {
            string[] noteNames = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            int octave = (noteNumber / 12) - 1;
            int noteIndex = noteNumber % 12;
            return noteNames[noteIndex] + octave;
        }

    }
}
