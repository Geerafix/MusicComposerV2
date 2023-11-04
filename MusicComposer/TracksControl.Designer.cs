using System.Windows.Forms;

namespace MusicComposer {
    partial class TracksControl {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        private void InitializeComponent() {
            menuButton = new Button();
            tracksLabel = new Label();
            tracksListBox = new ListBox();
            deleteTrackButton = new Button();
            modifyTrackButton = new Button();
            playTrackButton = new Button();
            SuspendLayout();
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            menuButton.Location = new Point(800, 440);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(200, 100);
            menuButton.TabIndex = 2;
            menuButton.Text = "Main menu";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.BackColor = ColorTranslator.FromHtml("#ffad5e");
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Click += menuButton_Click;
            // 
            // tracksLabel
            // 
            tracksLabel.AutoSize = true;
            tracksLabel.Font = new Font("Chopin Script", 100.200005F, FontStyle.Regular, GraphicsUnit.Point);
            tracksLabel.ForeColor = Color.FromArgb(255, 209, 115);
            tracksLabel.Location = new Point(71, 108);
            tracksLabel.Name = "tracksLabel";
            tracksLabel.Size = new Size(546, 227);
            tracksLabel.TabIndex = 4;
            tracksLabel.Text = "Tracks";
            // 
            // tracksListBox
            // 
            tracksListBox.BackColor = Color.FromArgb(23, 28, 39);
            tracksListBox.Cursor = Cursors.Hand;
            tracksListBox.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            tracksListBox.ForeColor = Color.White;
            tracksListBox.FormattingEnabled = true;
            tracksListBox.ItemHeight = 26;
            tracksListBox.Location = new Point(175, 302);
            tracksListBox.Name = "tracksListBox";
            tracksListBox.Size = new Size(361, 420);
            tracksListBox.TabIndex = 5;
            tracksListBox.SelectedIndexChanged += tracksListBox_SelectedIndexChanged;
            // 
            // deleteTrackButton
            // 
            deleteTrackButton.Cursor = Cursors.Hand;
            deleteTrackButton.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteTrackButton.Location = new Point(231, 728);
            deleteTrackButton.Name = "deleteTrackButton";
            deleteTrackButton.RightToLeft = RightToLeft.Yes;
            deleteTrackButton.Size = new Size(50, 50);
            deleteTrackButton.TabIndex = 6;
            deleteTrackButton.Text = "X";
            deleteTrackButton.UseVisualStyleBackColor = false;
            deleteTrackButton.Visible = false;
            deleteTrackButton.BackColor = ColorTranslator.FromHtml("#ffad5e");
            deleteTrackButton.FlatAppearance.BorderSize = 0;
            deleteTrackButton.FlatStyle = FlatStyle.Flat;
            deleteTrackButton.Click += deleteButton_Click;
            // 
            // modifyTrackButton
            // 
            modifyTrackButton.Cursor = Cursors.Hand;
            modifyTrackButton.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            modifyTrackButton.Location = new Point(175, 728);
            modifyTrackButton.Name = "modifyTrackButton";
            modifyTrackButton.RightToLeft = RightToLeft.Yes;
            modifyTrackButton.Size = new Size(50, 50);
            modifyTrackButton.TabIndex = 7;
            modifyTrackButton.Text = "✎";
            modifyTrackButton.UseVisualStyleBackColor = true;
            modifyTrackButton.Visible = false;
            modifyTrackButton.BackColor = ColorTranslator.FromHtml("#ffad5e");
            modifyTrackButton.FlatAppearance.BorderSize = 0;
            modifyTrackButton.FlatStyle = FlatStyle.Flat;
            modifyTrackButton.Click += modifyTrackButton_Click;
            // 
            // playTrackButton
            // 
            playTrackButton.Cursor = Cursors.Hand;
            playTrackButton.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            playTrackButton.Location = new Point(287, 728);
            playTrackButton.Name = "playTrackButton";
            playTrackButton.RightToLeft = RightToLeft.No;
            playTrackButton.Size = new Size(50, 50);
            playTrackButton.TabIndex = 8;
            playTrackButton.Text = ">";
            playTrackButton.UseVisualStyleBackColor = false;
            playTrackButton.Visible = false;
            playTrackButton.BackColor = ColorTranslator.FromHtml("#ffad5e");
            playTrackButton.FlatAppearance.BorderSize = 0;
            playTrackButton.FlatStyle = FlatStyle.Flat;
            playTrackButton.Click += playTrackButton_Click;
            // 
            // TracksControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tracksListBox);
            Controls.Add(tracksLabel);
            Controls.Add(playTrackButton);
            Controls.Add(modifyTrackButton);
            Controls.Add(deleteTrackButton);
            Controls.Add(menuButton);
            Name = "TracksControl";
            Size = new Size(1200, 800);
            Load += TracksControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuButton;
        private Label tracksLabel;
        private ListBox tracksListBox;
        private Button deleteTrackButton;
        private Button modifyTrackButton;
        private Button playTrackButton;
    }
}
