using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] files, path;


        private void button_add_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames;// Get all selected files names
                path = openFileDialog.FileNames;

                //Add file names into the list box
                for (int i = 0; i < files.Length; i++)
                {
                    listBox_files.Items.Add(files[i]);
                }
            }
        }

        //Play the file double clicked in the list box

        private void listBox_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = path[listBox_files.SelectedIndex];
            axWindowsMediaPlayer.Ctlcontrols.play();

        }
    }
}
