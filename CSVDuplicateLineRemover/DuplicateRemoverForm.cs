using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AchFindInvalidChars
{
    public partial class DuplicateRemoverForm : Form
    {
        public DuplicateRemoverForm()
        {
            InitializeComponent();
        }

        private void btnBrowseFileRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            DialogResult result = ofd.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = ofd.FileName;
                this.inpFileRead.Text = file;
            }
        }

        private void btnBrowseFileWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\";
            DialogResult result = sfd.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = sfd.FileName;
                this.inpFileWrite.Text = file;
            }
        }

        private void btnCheckFile_Click(object sender, EventArgs e)
        {
            string readFilePath = this.inpFileRead.Text;
            string writeFilePath = this.inpFileWrite.Text;

            this.lblResult.Visible = false;

            try
            {
                this.RemoveDuplicates(readFilePath, writeFilePath);
                this.lblResult.Text = "Done";
            }
            catch (FileNotFoundException ex)
            {
                this.lblResult.Text = ex.Message.Trim();
            }
            this.lblResult.Visible = true;
        }

        private void RemoveDuplicates(string input, string output)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(output))
                throw new FileNotFoundException("File names cannot be empty");

            if (input == @"C:\" || output == @"C:\")
                throw new FileNotFoundException(@"File must have a name after 'C:\'");

            if (!File.Exists(input))
                throw new FileNotFoundException("File to be read does not exist.");

            List<string> inputLines = File.ReadAllLines(input).Distinct().ToList();

            if (File.Exists(output))
                File.Delete(output);

            File.WriteAllLines(output, inputLines);
        }
    }
}
