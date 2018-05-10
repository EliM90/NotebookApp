using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotebookApp;

namespace WindowsFormsApp1 {
    public partial class LoadForm : Form {
        public List<string> Notes { get; set; }
        private readonly Notebook _notebook = new Notebook();

        public LoadForm() {
            InitializeComponent();
        }

        private void getNoteByName() {
            Notes = new List<string>();
            var pageData = new PageData {
                Tiltle = _titleTextBox.Text,
                Author = _nameTextBox.Text
            };
            Notes.Add(_notebook.GetByPageData(pageData));
        }

        private void getAllNotes() {
            Notes = _notebook.GetAllByAuthor(_nameTextBox.Text);
        }

        private void _fetchComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (_fetchComboBox.SelectedItem.ToString() == "All") return;
            _titleLabel.Visible = true;
            _titleTextBox.Visible = true;
        }

        private void _acceptButton_Click(object sender, EventArgs e) {
            if (_fetchComboBox.SelectedItem.ToString() == "All") {
                getAllNotes();
            } else {
                getNoteByName();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
