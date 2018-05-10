using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void _loadButton_Click(object sender, EventArgs e) {
            var loadForm = new LoadForm();
            loadForm.ShowDialog();
            var sb = new StringBuilder(loadForm.Notes.Count);
            foreach (var note in loadForm.Notes) {
                sb.AppendLine(note);
            }
            _outputRichTextBox.Text = sb.ToString();
        }

        private void _newButton_Click(object sender, EventArgs e) {
            var newForm = new NewForm();
            newForm.ShowDialog();
        }
    }
}
