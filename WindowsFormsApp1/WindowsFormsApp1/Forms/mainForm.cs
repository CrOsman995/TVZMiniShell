using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WindowsFormsApp1.Forms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        

        private void btnOpenFile_Click(object sender, EventArgs e)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                if(fbd.ShowDialog()==DialogResult.OK)
                {
                    lbShow.Items.Clear();
                    string[] files = FindFileDir(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
                string[] dirs = Directory.GetFiles(fbd.SelectedPath);

                    foreach (string file in files)
                    {
                          lbShow.Items.Add(file);


                    }
                    /*
                    foreach(string dir in dirs)
                    {
                        lbShow.Items.Add(dir);
                    }*/
        }
        }
        private static string[] FindFileDir(string beginpath)
        {
            List<string> findlist = new List<string>();

            /* I begin a recursion, following the order:
             * - Insert all the files in the current directory with the recursion
             * - Insert all subdirectories in the list and rebegin the recursion from there until the end
             */
            RecurseFind(beginpath, findlist);

            return findlist.ToArray();
        }
        private static void RecurseFind(string path, List<string> list)
        {
            string[] fl = Directory.GetFiles(path);
            string[] dl = Directory.GetDirectories(path);
            if (fl.Length > 0 || dl.Length > 0)
            {
                //I begin with the files, and store all of them in the list
                foreach (string s in fl)
                    list.Add(s);
                //I then add the directory and recurse that directory, the process will repeat until there are no more files and directories to recurse
                foreach (string s in dl)
                {
                    list.Add(s);
                    RecurseFind(s, list);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbShow.Items.Clear();
        }
    }
}
