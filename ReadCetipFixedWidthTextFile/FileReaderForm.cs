using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReadCetipFixedWidthTextFile
{
    public partial class FileReaderForm : Form
    {
        FileHelpers.FileHelperEngine fileEngine = null;

        public FileReaderForm()
        {
            InitializeComponent();

            gridHeader.Visible = false;
            gridConteudo.Visible = false;
            grpHeader.Visible = false;
            grpConteudo.Visible = false;

            gridHeader.AutoGenerateColumns = true;
            gridConteudo.AutoGenerateColumns = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpHeader.Visible = true;
            grpConteudo.Visible = true;

            DialogResult result = openFileDialog.ShowDialog();

            ReadFileHeader(openFileDialog.FileName);
            ReadFileContent(openFileDialog.FileName);

            foreach (DataGridViewColumn col in gridConteudo.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void ReadFileHeader(string fileName)
        {
            fileEngine = new FileHelpers.FileHelperEngine(typeof(CetipFileHeader));

            CetipFileHeader[] headerContent = fileEngine.ReadFile(fileName, 1) as CetipFileHeader[];

            if (headerContent != null)
            {
                gridHeader.Visible = true;
                gridHeader.DataSource = headerContent;
            }
        }

        private void ReadFileContent(string fileName)
        {
            CetipFileRecord[] content = null;
            fileEngine = new FileHelpers.FileHelperEngine(typeof(CetipFileRecord));

            fileEngine.Options.IgnoreFirstLines = 1;
            fileEngine.Options.IgnoreEmptyLines = true;

            content = fileEngine.ReadFile(fileName) as CetipFileRecord[];

            if (content != null)
            {
                gridConteudo.Visible = true;
                gridConteudo.DataSource = content;
            }
        }
    }
}
