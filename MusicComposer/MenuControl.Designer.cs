namespace MusicComposer {
    partial class MenuControl {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuControl));
            exitButton = new Button();
            composeButton = new Button();
            tracksButton = new Button();
            titleLabel = new Label();
            authorLabel = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 173, 94);
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(exitButton, "exitButton");
            exitButton.Name = "exitButton";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // composeButton
            // 
            composeButton.BackColor = Color.FromArgb(255, 173, 94);
            composeButton.Cursor = Cursors.Hand;
            composeButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(composeButton, "composeButton");
            composeButton.Name = "composeButton";
            composeButton.UseVisualStyleBackColor = false;
            composeButton.Click += composeButton_Click;
            // 
            // tracksButton
            // 
            tracksButton.BackColor = Color.FromArgb(255, 173, 94);
            tracksButton.Cursor = Cursors.Hand;
            tracksButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(tracksButton, "tracksButton");
            tracksButton.Name = "tracksButton";
            tracksButton.UseVisualStyleBackColor = false;
            tracksButton.Click += tracksButton_Click;
            // 
            // titleLabel
            // 
            resources.ApplyResources(titleLabel, "titleLabel");
            titleLabel.ForeColor = Color.FromArgb(255, 209, 115);
            titleLabel.Name = "titleLabel";
            // 
            // authorLabel
            // 
            resources.ApplyResources(authorLabel, "authorLabel");
            authorLabel.ForeColor = Color.FromArgb(23, 144, 201);
            authorLabel.Name = "authorLabel";
            // 
            // MenuControl
            // 
            BackColor = Color.Transparent;
            Controls.Add(authorLabel);
            Controls.Add(titleLabel);
            Controls.Add(tracksButton);
            Controls.Add(composeButton);
            Controls.Add(exitButton);
            Name = "MenuControl";
            resources.ApplyResources(this, "$this");
            ResumeLayout(false);
            PerformLayout();
        }

        private Button exitButton;
        private Button composeButton;
        private Button tracksButton;
        private Label authorLabel;
        private Label titleLabel;

        #endregion
    }
}
