namespace WindowsFormsApp1 {
    partial class LoadForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this._nameLabel = new System.Windows.Forms.Label();
            this._fetchLabel = new System.Windows.Forms.Label();
            this._titleLabel = new System.Windows.Forms.Label();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._titleTextBox = new System.Windows.Forms.TextBox();
            this._fetchComboBox = new System.Windows.Forms.ComboBox();
            this._acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(0, 0);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(35, 13);
            this._nameLabel.TabIndex = 0;
            this._nameLabel.Text = "Name";
            // 
            // _fetchLabel
            // 
            this._fetchLabel.AutoSize = true;
            this._fetchLabel.Location = new System.Drawing.Point(0, 25);
            this._fetchLabel.Name = "_fetchLabel";
            this._fetchLabel.Size = new System.Drawing.Size(34, 13);
            this._fetchLabel.TabIndex = 1;
            this._fetchLabel.Text = "Fetch";
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Location = new System.Drawing.Point(0, 51);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(27, 13);
            this._titleLabel.TabIndex = 2;
            this._titleLabel.Text = "Title";
            this._titleLabel.Visible = false;
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(62, 0);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(100, 20);
            this._nameTextBox.TabIndex = 3;
            // 
            // _titleTextBox
            // 
            this._titleTextBox.Location = new System.Drawing.Point(62, 51);
            this._titleTextBox.Name = "_titleTextBox";
            this._titleTextBox.Size = new System.Drawing.Size(100, 20);
            this._titleTextBox.TabIndex = 3;
            this._titleTextBox.Visible = false;
            // 
            // _fetchComboBox
            // 
            this._fetchComboBox.FormattingEnabled = true;
            this._fetchComboBox.Items.AddRange(new object[] {
            "All",
            "ByTitle"});
            this._fetchComboBox.Location = new System.Drawing.Point(62, 25);
            this._fetchComboBox.Name = "_fetchComboBox";
            this._fetchComboBox.Size = new System.Drawing.Size(100, 21);
            this._fetchComboBox.TabIndex = 4;
            this._fetchComboBox.SelectedIndexChanged += new System.EventHandler(this._fetchComboBox_SelectedIndexChanged);
            // 
            // _acceptButton
            // 
            this._acceptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._acceptButton.Location = new System.Drawing.Point(0, 83);
            this._acceptButton.Name = "_acceptButton";
            this._acceptButton.Size = new System.Drawing.Size(169, 23);
            this._acceptButton.TabIndex = 5;
            this._acceptButton.Text = "Accept";
            this._acceptButton.UseVisualStyleBackColor = true;
            this._acceptButton.Click += new System.EventHandler(this._acceptButton_Click);
            // 
            // LoadForm
            // 
            this.AcceptButton = this._acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 106);
            this.Controls.Add(this._acceptButton);
            this.Controls.Add(this._fetchComboBox);
            this.Controls.Add(this._titleTextBox);
            this.Controls.Add(this._nameTextBox);
            this.Controls.Add(this._titleLabel);
            this.Controls.Add(this._fetchLabel);
            this.Controls.Add(this._nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Label _fetchLabel;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _titleTextBox;
        private System.Windows.Forms.ComboBox _fetchComboBox;
        private System.Windows.Forms.Button _acceptButton;
    }
}