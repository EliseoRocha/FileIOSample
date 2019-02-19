using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            string data = dataTextBox.Text;

            //Get path to AppData folder
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            //File.WriteAllText(@"test.txt", data);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text File (*.txt) | *.txt";
            dialog.FileName = "example";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                //The file name includes the full path
                string fileName = dialog.FileName;

                File.WriteAllText(fileName, data);
                MessageBox.Show("Data Saved");
            }


            
        }
    }
}
