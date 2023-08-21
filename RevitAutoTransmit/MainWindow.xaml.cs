using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace RevitAutoTransmit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> ExportVariants = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            string copyFrom = "D:\\TemporaryDirectory\\CopyFrom";
            ExportVariantsTree.Items.Clear();
            PopulateTreeView(copyFrom, ExportVariantsTree.Items);


            string copyTo = "D:\\TemporaryDirectory\\CopyTo"; //TODO - сделать получение из интерфейса
            if (!Directory.Exists(copyTo))
            {
                Directory.CreateDirectory(copyTo);
            }
            string rootFolderName = $"{DateTime.Now.ToString("yyyy.MM.dd")}_Выгрузка";
            string currentExportPath = Path.Combine(copyTo, rootFolderName);
            Directory.CreateDirectory(currentExportPath);
            List<string> subFolders = new List<string> { "К2", "К3", "К4" };
            foreach (string folder in subFolders)
            {
                Directory.CreateDirectory(Path.Combine(currentExportPath,folder));
            }
        }
        private void PopulateTreeView(string folderPath, ItemCollection items)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);

           
            foreach (var subDirectory in directoryInfo.GetDirectories())
            {
                TreeViewItem subDirectoryItem = new TreeViewItem();
                subDirectoryItem.Header = subDirectory.Name;
                items.Add(subDirectoryItem);

                PopulateTreeView(subDirectory.FullName, subDirectoryItem.Items);
            }

            foreach (var file in directoryInfo.GetFiles("*.rvt"))
            {
                TreeViewItem fileItem = new TreeViewItem();
                fileItem.Header = file.Name;
                items.Add(fileItem);
            }
        }

    }
}
