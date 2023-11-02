namespace MusicComposer
{
    partial class TracksControl
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

        #region Kod wygenerowany przez Projektanta składników

        private void InitializeComponent()
        {
            menuButton = new Button();
            tracksLabel = new Label();
            SuspendLayout();
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            menuButton.Location = new Point(800, 440);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(200, 100);
            menuButton.TabIndex = 2;
            menuButton.Text = "Main menu";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // tracksLabel
            // 
            tracksLabel.AutoSize = true;
            tracksLabel.Font = new Font("Century Gothic", 75F, FontStyle.Bold, GraphicsUnit.Point);
            tracksLabel.ForeColor = Color.Teal;
            tracksLabel.Location = new Point(80, 125);
            tracksLabel.Name = "tracksLabel";
            tracksLabel.Size = new Size(445, 147);
            tracksLabel.TabIndex = 4;
            tracksLabel.Text = "Tracks";
            // 
            // TracksControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            Controls.Add(tracksLabel);
            Controls.Add(menuButton);
            Name = "TracksControl";
            Size = new Size(1200, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuButton;
        private Label tracksLabel;
    }
}
