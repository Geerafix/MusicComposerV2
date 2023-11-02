using NAudio.Midi;

namespace MusicComposer
{
    partial class ComposeControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            positionLabel = new Label();
            noteCountLabel = new Label();
            position = new Label();
            toMenuButton = new Button();
            noteCount = new Label();
            noteLabel = new Label();
            durationLabel = new Label();
            noteUp = new Button();
            noteDown = new Button();
            durationUp = new Button();
            durationDown = new Button();
            playNoteButton = new Button();
            addNoteButton = new Button();
            previousNoteButton = new Button();
            nextNoteButton = new Button();
            trackNotesListBox = new ListBox();
            deleteNoteButtton = new Button();
            playButton = new Button();
            stopButton = new Button();
            SuspendLayout();
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            positionLabel.Location = new Point(759, 18);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(137, 37);
            positionLabel.TabIndex = 0;
            positionLabel.Text = "Position:";
            // 
            // noteCountLabel
            // 
            noteCountLabel.AutoSize = true;
            noteCountLabel.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            noteCountLabel.Location = new Point(959, 16);
            noteCountLabel.Name = "noteCountLabel";
            noteCountLabel.Size = new Size(189, 37);
            noteCountLabel.TabIndex = 1;
            noteCountLabel.Text = "Note count:";
            // 
            // position
            // 
            position.AutoSize = true;
            position.BackColor = Color.Transparent;
            position.Font = new Font("Century Gothic", 21F, FontStyle.Bold, GraphicsUnit.Point);
            position.Location = new Point(885, 16);
            position.Name = "position";
            position.Size = new Size(38, 41);
            position.TabIndex = 2;
            position.Text = "1";
            // 
            // toMenuButton
            // 
            toMenuButton.Cursor = Cursors.Hand;
            toMenuButton.Location = new Point(3, 3);
            toMenuButton.Name = "toMenuButton";
            toMenuButton.Size = new Size(75, 75);
            toMenuButton.TabIndex = 3;
            toMenuButton.Text = "Main menu";
            toMenuButton.UseVisualStyleBackColor = true;
            toMenuButton.Click += toMenuButton_Click;
            // 
            // noteCount
            // 
            noteCount.AutoSize = true;
            noteCount.Font = new Font("Century Gothic", 21F, FontStyle.Bold, GraphicsUnit.Point);
            noteCount.Location = new Point(1137, 14);
            noteCount.Name = "noteCount";
            noteCount.Size = new Size(38, 41);
            noteCount.TabIndex = 4;
            noteCount.Text = "0";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new Font("Century Gothic", 85F, FontStyle.Bold, GraphicsUnit.Point);
            noteLabel.ForeColor = Color.Teal;
            noteLabel.Location = new Point(133, 360);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(261, 168);
            noteLabel.TabIndex = 5;
            noteLabel.Text = "C1";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Century Gothic", 85F, FontStyle.Bold, GraphicsUnit.Point);
            durationLabel.ForeColor = Color.Teal;
            durationLabel.Location = new Point(495, 359);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(310, 168);
            durationLabel.TabIndex = 6;
            durationLabel.Text = "500";
            // 
            // noteUp
            // 
            noteUp.Cursor = Cursors.Hand;
            noteUp.Location = new Point(167, 200);
            noteUp.Name = "noteUp";
            noteUp.Size = new Size(94, 132);
            noteUp.TabIndex = 7;
            noteUp.UseVisualStyleBackColor = true;
            noteUp.Click += noteUp_Click;
            // 
            // noteDown
            // 
            noteDown.Cursor = Cursors.Hand;
            noteDown.Location = new Point(167, 560);
            noteDown.Name = "noteDown";
            noteDown.Size = new Size(94, 132);
            noteDown.TabIndex = 8;
            noteDown.UseVisualStyleBackColor = true;
            noteDown.Click += noteDown_Click;
            // 
            // durationUp
            // 
            durationUp.Cursor = Cursors.Hand;
            durationUp.Location = new Point(524, 200);
            durationUp.Name = "durationUp";
            durationUp.Size = new Size(94, 132);
            durationUp.TabIndex = 9;
            durationUp.UseVisualStyleBackColor = true;
            durationUp.Click += durationUp_Click;
            // 
            // durationDown
            // 
            durationDown.Cursor = Cursors.Hand;
            durationDown.Location = new Point(524, 560);
            durationDown.Name = "durationDown";
            durationDown.Size = new Size(94, 132);
            durationDown.TabIndex = 10;
            durationDown.UseVisualStyleBackColor = true;
            durationDown.Click += durationDown_Click;
            // 
            // playNoteButton
            // 
            playNoteButton.Cursor = Cursors.Hand;
            playNoteButton.FlatStyle = FlatStyle.System;
            playNoteButton.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            playNoteButton.ForeColor = Color.DarkSlateGray;
            playNoteButton.Location = new Point(47, 372);
            playNoteButton.Name = "playNoteButton";
            playNoteButton.Size = new Size(80, 80);
            playNoteButton.TabIndex = 11;
            playNoteButton.UseVisualStyleBackColor = true;
            playNoteButton.Click += playNoteButton_Click;
            // 
            // addNoteButton
            // 
            addNoteButton.Cursor = Cursors.Hand;
            addNoteButton.FlatStyle = FlatStyle.System;
            addNoteButton.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point);
            addNoteButton.Location = new Point(47, 453);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Size = new Size(80, 80);
            addNoteButton.TabIndex = 12;
            addNoteButton.UseVisualStyleBackColor = true;
            addNoteButton.Click += addNoteButton_Click;
            // 
            // previousNoteButton
            // 
            previousNoteButton.Cursor = Cursors.Hand;
            previousNoteButton.Location = new Point(167, 118);
            previousNoteButton.Name = "previousNoteButton";
            previousNoteButton.Size = new Size(94, 29);
            previousNoteButton.TabIndex = 13;
            previousNoteButton.Text = "<";
            previousNoteButton.UseVisualStyleBackColor = true;
            previousNoteButton.Click += previousNoteButton_Click;
            // 
            // nextNoteButton
            // 
            nextNoteButton.Cursor = Cursors.Hand;
            nextNoteButton.Location = new Point(524, 118);
            nextNoteButton.Name = "nextNoteButton";
            nextNoteButton.Size = new Size(94, 29);
            nextNoteButton.TabIndex = 14;
            nextNoteButton.Text = ">";
            nextNoteButton.UseVisualStyleBackColor = true;
            nextNoteButton.Click += nextNoteButton_Click;
            // 
            // trackNotesListBox
            // 
            trackNotesListBox.BackColor = Color.LightSlateGray;
            trackNotesListBox.BorderStyle = BorderStyle.None;
            trackNotesListBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            trackNotesListBox.ForeColor = Color.Black;
            trackNotesListBox.FormattingEnabled = true;
            trackNotesListBox.ItemHeight = 23;
            trackNotesListBox.Location = new Point(902, 69);
            trackNotesListBox.MultiColumn = true;
            trackNotesListBox.Name = "trackNotesListBox";
            trackNotesListBox.SelectionMode = SelectionMode.None;
            trackNotesListBox.Size = new Size(295, 713);
            trackNotesListBox.TabIndex = 15;
            // 
            // deleteNoteButtton
            // 
            deleteNoteButtton.Location = new Point(343, 118);
            deleteNoteButtton.Name = "deleteNoteButtton";
            deleteNoteButtton.Size = new Size(94, 29);
            deleteNoteButtton.TabIndex = 16;
            deleteNoteButtton.Text = "Delete";
            deleteNoteButtton.UseVisualStyleBackColor = true;
            deleteNoteButtton.Click += deleteNoteButton_Click;
            // 
            // playButton
            // 
            playButton.Cursor = Cursors.Hand;
            playButton.Location = new Point(3, 722);
            playButton.Name = "playButton";
            playButton.Size = new Size(75, 75);
            playButton.TabIndex = 17;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            stopButton.Cursor = Cursors.Hand;
            stopButton.Location = new Point(3, 722);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(75, 75);
            stopButton.TabIndex = 18;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            // 
            // ComposeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(deleteNoteButtton);
            Controls.Add(trackNotesListBox);
            Controls.Add(nextNoteButton);
            Controls.Add(previousNoteButton);
            Controls.Add(addNoteButton);
            Controls.Add(playNoteButton);
            Controls.Add(durationDown);
            Controls.Add(durationUp);
            Controls.Add(noteDown);
            Controls.Add(noteUp);
            Controls.Add(durationLabel);
            Controls.Add(noteLabel);
            Controls.Add(noteCount);
            Controls.Add(toMenuButton);
            Controls.Add(position);
            Controls.Add(noteCountLabel);
            Controls.Add(positionLabel);
            Name = "ComposeControl";
            Size = new Size(1200, 800);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label positionLabel;
        private Label noteCountLabel;
        private Label position;
        private Button toMenuButton;
        private Label noteCount;
        private Label noteLabel;
        private Label durationLabel;
        private Button noteUp;
        private Button noteDown;
        private Button durationUp;
        private Button durationDown;
        private Button playNoteButton;
        private Button addNoteButton;
        private Button previousNoteButton;
        private Button nextNoteButton;
        private ListBox trackNotesListBox;
        private Button deleteNoteButtton;
        private Button playButton;
        private Button stopButton;
    }
}
