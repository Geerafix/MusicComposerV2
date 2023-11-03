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
            exitButton.Cursor = Cursors.Hand;
            resources.ApplyResources(exitButton, "exitButton");
            exitButton.Name = "exitButton";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // composeButton
            // 
            composeButton.Cursor = Cursors.Hand;
            resources.ApplyResources(composeButton, "composeButton");
            composeButton.Name = "composeButton";
            composeButton.UseVisualStyleBackColor = true;
            composeButton.Click += composeButton_Click;
            // 
            // tracksButton
            // 
            tracksButton.Cursor = Cursors.Hand;
            resources.ApplyResources(tracksButton, "tracksButton");
            tracksButton.Name = "tracksButton";
            tracksButton.UseVisualStyleBackColor = true;
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
