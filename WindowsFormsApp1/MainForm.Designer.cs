namespace WindowsFormsApp1 {
    partial class MainForm {
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
            this._loadButton = new System.Windows.Forms.Button();
            this._newButton = new System.Windows.Forms.Button();
            this._outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _loadButton
            // 
            this._loadButton.Location = new System.Drawing.Point(12, 12);
            this._loadButton.Name = "_loadButton";
            this._loadButton.Size = new System.Drawing.Size(75, 23);
            this._loadButton.TabIndex = 0;
            this._loadButton.Text = "Load";
            this._loadButton.UseVisualStyleBackColor = true;
            this._loadButton.Click += new System.EventHandler(this._loadButton_Click);
            // 
            // _newButton
            // 
            this._newButton.Location = new System.Drawing.Point(93, 12);
            this._newButton.Name = "_newButton";
            this._newButton.Size = new System.Drawing.Size(75, 23);
            this._newButton.TabIndex = 1;
            this._newButton.Text = "New";
            this._newButton.UseVisualStyleBackColor = true;
            this._newButton.Click += new System.EventHandler(this._newButton_Click);
            // 
            // _outputRichTextBox
            // 
            this._outputRichTextBox.Location = new System.Drawing.Point(12, 41);
            this._outputRichTextBox.Name = "_outputRichTextBox";
            this._outputRichTextBox.Size = new System.Drawing.Size(498, 711);
            this._outputRichTextBox.TabIndex = 2;
            this._outputRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 764);
            this.Controls.Add(this._outputRichTextBox);
            this.Controls.Add(this._newButton);
            this.Controls.Add(this._loadButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _loadButton;
        private System.Windows.Forms.Button _newButton;
        private System.Windows.Forms.RichTextBox _outputRichTextBox;
    }
}

