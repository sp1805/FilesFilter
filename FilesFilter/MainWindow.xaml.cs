using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using SWH =  System.Web.HttpContext;
using System.Threading;

namespace FilesFilter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BrowseButtonClick(object sender, RoutedEventArgs e)
        {
            string spath = null;
            // OpenFileDialog openFileDialog = new OpenFileDialog();
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.ShowNewFolderButton = false;
            openFileDialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = openFileDialog.ShowDialog();
            if (result.ToString().Equals("OK"))
            {
                spath = openFileDialog.SelectedPath;
                FolderNameTB.Text = spath;

                //Properties.Settings.Default.Folder_Path = sPath;
            }
            //  FolderNameTB.Text = openFileDialo

        }

        private void FolderNameTB_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
        public static void OnCopyingMethod()
        {
            System.Windows.MessageBox.Show("Copying.... Wait....","Wait",MessageBoxButton.OK,MessageBoxImage.Information);
        }
        private void Filterbutton_Click(object sender, RoutedEventArgs e)
        {
            string path = null;
            path = FolderNameTB.Text;
            string[] pathToCopys = null;
            List<string> fileName = new List<string>();
            List<string> newFolderName = new List<string>();
            string pathToCopy = null;
            int folderCount = 0;
            Thread th = new Thread(OnCopyingMethod);
            th.IsBackground = true;
            if (path.CompareTo("Browse for Folder") != 0)
            {
                try
                {
                    pathToCopys = Directory.GetFiles(path);
                    foreach (var files in Directory.GetFiles(path))
                    {
                        string singleFileName = System.IO.Path.GetFileName(files);
                        FileInfo info = new FileInfo(files);
                        fileName.Add(singleFileName);
                        if(!newFolderName.Contains(singleFileName.Substring(0,3)))
                        {
                            newFolderName.Add(singleFileName.Substring(0,3));
                            folderCount++;
                        }
                    }
                    if (System.Windows.MessageBox.Show("Do you want to filter all your files?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        th.Start();
                        IEnumerable<string> filesToCopy = null;
                        foreach(string files in newFolderName)
                        {
                            pathToCopy = path + "\\" + files;
                            bool exist = System.IO.Directory.Exists(pathToCopy);
                            if (!exist)
                                System.IO.Directory.CreateDirectory(pathToCopy);
                            filesToCopy = Directory.GetFiles(path).Where(f => f.Contains(files));
                            foreach(var fileToCopy in filesToCopy)
                            {
                                string filenameToCopy = fileToCopy.ToString();
                                FileInfo fInfo = new FileInfo(filenameToCopy);
                                string destFileName = System.IO.Path.Combine(pathToCopy,fInfo.Name);
                                File.Copy(filenameToCopy, destFileName,true);
                            }
                        }
                        
                    }
                }
                catch(Exception ex)
                {
                    System.Windows.MessageBox.Show($"Folder Doesnot esist: {ex.Message}");
                }
            }
            else
            {
               
            }
        }
    }
}
