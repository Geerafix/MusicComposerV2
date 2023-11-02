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
            SuspendLayout();
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new Font("Avatarock", 25F, FontStyle.Regular, GraphicsUnit.Point);
            positionLabel.Location = new Point(867, 18);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(101, 34);
            positionLabel.TabIndex = 0;
            positionLabel.Text = "Position:";
            // 
            // noteCountLabel
            // 
            noteCountLabel.AutoSize = true;
            noteCountLabel.Font = new Font("Avatarock", 25F, FontStyle.Regular, GraphicsUnit.Point);
            noteCountLabel.Location = new Point(1027, 18);
            noteCountLabel.Name = "noteCountLabel";
            noteCountLabel.Size = new Size(131, 34);
            noteCountLabel.TabIndex = 1;
            noteCountLabel.Text = "Note count:";
            // 
            // position
            // 
            position.AutoSize = true;
            position.BackColor = Color.Transparent;
            position.Font = new Font("Avatarock", 25F, FontStyle.Regular, GraphicsUnit.Point);
            position.Location = new Point(959, 17);
            position.Name = "position";
            position.Size = new Size(24, 34);
            position.TabIndex = 2;
            position.Text = "1";
            // 
            // toMenuButton
            // 
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
            noteCount.Font = new Font("Avatarock", 25F, FontStyle.Regular, GraphicsUnit.Point);
            noteCount.Location = new Point(1149, 18);
            noteCount.Name = "noteCount";
            noteCount.Size = new Size(29, 34);
            noteCount.TabIndex = 4;
            noteCount.Text = "0";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new Font("Avatarock", 120F, FontStyle.Regular, GraphicsUnit.Point);
            noteLabel.Location = new Point(161, 334);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(179, 158);
            noteLabel.TabIndex = 5;
            noteLabel.Text = "C1";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Avatarock", 120F, FontStyle.Regular, GraphicsUnit.Point);
            durationLabel.Location = new Point(482, 334);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(269, 158);
            durationLabel.TabIndex = 6;
            durationLabel.Text = "500";
            // 
            // noteUp
            // 
            noteUp.Location = new Point(192, 163);
            noteUp.Name = "noteUp";
            noteUp.Size = new Size(94, 132);
            noteUp.TabIndex = 7;
            noteUp.Text = "Up";
            noteUp.UseVisualStyleBackColor = true;
            noteUp.Click += noteUp_Click;
            // 
            // noteDown
            // 
            noteDown.Location = new Point(192, 523);
            noteDown.Name = "noteDown";
            noteDown.Size = new Size(94, 132);
            noteDown.TabIndex = 8;
            noteDown.Text = "Down";
            noteDown.UseVisualStyleBackColor = true;
            noteDown.Click += noteDown_Click;
            // 
            // durationUp
            // 
            durationUp.Location = new Point(513, 163);
            durationUp.Name = "durationUp";
            durationUp.Size = new Size(94, 132);
            durationUp.TabIndex = 9;
            durationUp.Text = "Up";
            durationUp.UseVisualStyleBackColor = true;
            durationUp.Click += durationUp_Click;
            // 
            // durationDown
            // 
            durationDown.Location = new Point(513, 523);
            durationDown.Name = "durationDown";
            durationDown.Size = new Size(94, 132);
            durationDown.TabIndex = 10;
            durationDown.Text = "Down";
            durationDown.UseVisualStyleBackColor = true;
            durationDown.Click += durationDown_Click;
            // 
            // playNoteButton
            // 
            playNoteButton.Location = new Point(37, 334);
            playNoteButton.Name = "playNoteButton";
            playNoteButton.Size = new Size(94, 158);
            playNoteButton.TabIndex = 11;
            playNoteButton.Text = "Play";
            playNoteButton.UseVisualStyleBackColor = true;
            playNoteButton.Click += playNoteButton_Click;
            // 
            // ComposeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
