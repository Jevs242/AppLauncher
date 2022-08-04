//Jose Velazquez
//App Launcher

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AppLauncher
{
    public partial class Form1 : Form
    {
        //List of program url
        List<string> urlList = new List<string>();
        //Path to where will go the file and name of txt
        string path = "Data\\saved.txt";

        public Form1()
        {
            InitializeComponent();
            CreateFile(false);
            ReadFile();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            //Create the file dialog to search the program and get the url
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.exe*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                //For when you put OPEN button in the file Dialog
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get URL
                    filePath = openFileDialog.FileName;

                    Stream fileSteam = openFileDialog.OpenFile();
                    //Add URL to the list
                    urlList.Add(filePath.ToString());

                    AddTextBox();

                    WriteFile(filePath);
                }
            }
        }

        private void btn_RunApps_Click(object sender, EventArgs e)
        {
            //Open all the programs that are in the list
            for(int i=0; i < urlList.Count; i++)
            {
                Process.Start(urlList[i]);
            }
        }

        private void CreateFile(bool delete)
        {
            //Condition to know if there some file with the same path
            //if is to delete file must ignore the first condisional
            if (!File.Exists(path) || delete)
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
            }
        }

        private void WriteFile(string newUrl)
        {
            //Rewrite the file with the new list
            TextWriter sw = File.CreateText(path);
            for (int i = 0; i < urlList.Count; i++)
            {
                sw.Write(urlList[i]);
                sw.Write("\n");
            }   
            sw.Close();
        }

        private void ReadFile()
        {
            StreamReader sr = new StreamReader(path);
            //Puts the file information in filedata
            string filedata = sr.ReadToEnd();

            int numUrl = 0;
            string url = string.Empty;
            
            //Divide the file string to List through Enter
            for(int i = 0; i < filedata.Length; i++)
            {
                if (filedata[i] == '\n')
                {
                    numUrl++;
                    urlList.Add(url);
                    url = string.Empty;
                    continue;
                }   
                url += filedata[i];
            }

            AddTextBox();

            sr.Close();
        }

        private void AddTextBox()
        {
            //Clear and put new information in Box List
            lbx_ProgramBox.Items.Clear();
            for (int i = 0; i < urlList.Count; i++)
            {
                lbx_ProgramBox.Items.Add(urlList[i]);
            }
        }

        private void btn_DeleteFile_Click(object sender, EventArgs e)
        {
            //Delete the List and Rewrite the file for delete information
            urlList.Clear();
            CreateFile(true);
            AddTextBox();
        }
    }
}
