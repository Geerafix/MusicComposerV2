namespace MusicComposer
{
    partial class EditControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditControl));
            positionLabel = new Label();
            noteCountLabel = new Label();
            position = new Label();
            toTracksButton = new Button();
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
            editingLabel = new Label();
            trackNameLabel = new Label();
            saveButton = new Button();
            SuspendLayout();
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            positionLabel.ForeColor = Color.Snow;
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
            noteCountLabel.ForeColor = Color.Snow;
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
            position.ForeColor = SystemColors.Control;
            position.Location = new Point(885, 16);
            position.Name = "position";
            position.Size = new Size(38, 41);
            position.TabIndex = 2;
            position.Text = "1";
            // 
            // toTracksButton
            // 
            toTracksButton.Cursor = Cursors.Hand;
            toTracksButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toTracksButton.Location = new Point(3, 3);
            toTracksButton.Name = "toTracksButton";
            toTracksButton.Size = new Size(60, 60);
            toTracksButton.TabIndex = 3;
            toTracksButton.Text = "Back";
            toTracksButton.UseVisualStyleBackColor = true;
            toTracksButton.Click += toTracksButton_Click;
            // 
            // noteCount
            // 
            noteCount.AutoSize = true;
            noteCount.Font = new Font("Century Gothic", 21F, FontStyle.Bold, GraphicsUnit.Point);
            noteCount.ForeColor = SystemColors.Control;
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
            noteLabel.ForeColor = Color.MintCream;
            noteLabel.Location = new Point(133, 359);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(261, 168);
            noteLabel.TabIndex = 5;
            noteLabel.Text = "C1";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Century Gothic", 85F, FontStyle.Bold, GraphicsUnit.Point);
            durationLabel.ForeColor = Color.MintCream;
            durationLabel.Location = new Point(495, 359);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(310, 168);
            durationLabel.TabIndex = 6;
            durationLabel.Text = "500";
            // 
            // noteUp
            // 
            noteUp.BackColor = Color.Transparent;
            noteUp.Cursor = Cursors.Hand;
            noteUp.ForeColor = Color.Transparent;
            noteUp.Image = (Image)resources.GetObject("noteUp.Image");
            noteUp.Location = new Point(167, 226);
            noteUp.Name = "noteUp";
            noteUp.Size = new Size(94, 132);
            noteUp.TabIndex = 7;
            noteUp.UseVisualStyleBackColor = false;
            noteUp.Click += noteUp_Click;
            // 
            // noteDown
            // 
            noteDown.BackColor = Color.Transparent;
            noteDown.BackgroundImage = (Image)resources.GetObject("noteDown.BackgroundImage");
            noteDown.Cursor = Cursors.Hand;
            noteDown.Location = new Point(167, 529);
            noteDown.Name = "noteDown";
            noteDown.Size = new Size(94, 132);
            noteDown.TabIndex = 8;
            noteDown.UseVisualStyleBackColor = false;
            noteDown.Click += noteDown_Click;
            // 
            // durationUp
            // 
            durationUp.BackgroundImage = (Image)resources.GetObject("durationUp.BackgroundImage");
            durationUp.Cursor = Cursors.Hand;
            durationUp.ForeColor = Color.Cornsilk;
            durationUp.Location = new Point(524, 226);
            durationUp.Name = "durationUp";
            durationUp.Size = new Size(94, 132);
            durationUp.TabIndex = 9;
            durationUp.UseVisualStyleBackColor = true;
            durationUp.Click += durationUp_Click;
            // 
            // durationDown
            // 
            durationDown.BackgroundImage = (Image)resources.GetObject("durationDown.BackgroundImage");
            durationDown.Cursor = Cursors.Hand;
            durationDown.Location = new Point(524, 529);
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
            playNoteButton.Location = new Point(44, 332);
            playNoteButton.Name = "playNoteButton";
            playNoteButton.Size = new Size(80, 80);
            playNoteButton.TabIndex = 11;
            playNoteButton.Text = ">";
            playNoteButton.UseVisualStyleBackColor = true;
            playNoteButton.Click += playNoteButton_Click;
            // 
            // addNoteButton
            // 
            addNoteButton.Cursor = Cursors.Hand;
            addNoteButton.FlatStyle = FlatStyle.System;
            addNoteButton.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point);
            addNoteButton.Location = new Point(44, 418);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Size = new Size(80, 80);
            addNoteButton.TabIndex = 12;
            addNoteButton.Text = "+";
            addNoteButton.UseVisualStyleBackColor = true;
            addNoteButton.Click += addNoteButton_Click;
            // 
            // previousNoteButton
            // 
            previousNoteButton.Cursor = Cursors.Hand;
            previousNoteButton.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            previousNoteButton.Location = new Point(167, 191);
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
            nextNoteButton.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            nextNoteButton.Location = new Point(524, 191);
            nextNoteButton.Name = "nextNoteButton";
            nextNoteButton.Size = new Size(94, 29);
            nextNoteButton.TabIndex = 14;
            nextNoteButton.Text = ">";
            nextNoteButton.UseVisualStyleBackColor = true;
            nextNoteButton.Click += nextNoteButton_Click;
            // 
            // trackNotesListBox
            // 
            trackNotesListBox.BackColor = Color.FromArgb(23, 28, 39);
            trackNotesListBox.BorderStyle = BorderStyle.None;
            trackNotesListBox.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            trackNotesListBox.ForeColor = Color.Snow;
            trackNotesListBox.FormattingEnabled = true;
            trackNotesListBox.ItemHeight = 27;
            trackNotesListBox.Location = new Point(898, 64);
            trackNotesListBox.MultiColumn = true;
            trackNotesListBox.Name = "trackNotesListBox";
            trackNotesListBox.SelectionMode = SelectionMode.None;
            trackNotesListBox.Size = new Size(295, 729);
            trackNotesListBox.TabIndex = 15;
            // 
            // deleteNoteButtton
            // 
            deleteNoteButtton.Cursor = Cursors.Hand;
            deleteNoteButtton.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            deleteNoteButtton.Location = new Point(44, 504);
            deleteNoteButtton.Name = "deleteNoteButtton";
            deleteNoteButtton.Size = new Size(80, 80);
            deleteNoteButtton.TabIndex = 16;
            deleteNoteButtton.Text = "X";
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
            playButton.Click += playNoteButton_Click;
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
            // editingLabel
            // 
            editingLabel.AutoSize = true;
            editingLabel.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            editingLabel.ForeColor = Color.Gainsboro;
            editingLabel.Location = new Point(140, 14);
            editingLabel.Name = "editingLabel";
            editingLabel.Size = new Size(124, 37);
            editingLabel.TabIndex = 17;
            editingLabel.Text = "Editing:";
            // 
            // trackNameLabel
            // 
            trackNameLabel.AutoSize = true;
            trackNameLabel.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            trackNameLabel.ForeColor = Color.FromArgb(255, 209, 115);
            trackNameLabel.Location = new Point(254, 14);
            trackNameLabel.Name = "trackNameLabel";
            trackNameLabel.Size = new Size(207, 38);
            trackNameLabel.TabIndex = 18;
            trackNameLabel.Text = "(track name)";
            trackNameLabel.Click += label1_Click;
            // 
            // saveButton
            // 
            saveButton.Cursor = Cursors.Hand;
            saveButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(71, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(60, 60);
            saveButton.TabIndex = 19;
            saveButton.Text = "✓";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // EditControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(saveButton);
            Controls.Add(trackNameLabel);
            Controls.Add(editingLabel);
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
            Controls.Add(toTracksButton);
            Controls.Add(position);
            Controls.Add(noteCountLabel);
            Controls.Add(positionLabel);
            Name = "EditControl";
            Size = new Size(1200, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        private void PlayNoteButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private Label positionLabel;
        private Label noteCountLabel;
        private Label position;
        private Button toTracksButton;
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
        private Label editingLabel;
        private Label trackNameLabel;
        private Button saveButton;
    }
}
