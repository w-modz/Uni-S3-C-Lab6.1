namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string output_path;
        public Form1()
        {
            InitializeComponent();
            //output_path = "C:\\Users\\vitom\\OneDrive\\Pulpit\\Copies";
        }

        private void SelectButtom_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.ShowDialog();
            DirectoryTextbox.Text = FolderBrowserDialog.SelectedPath;
            DirectorySearch(DirectoryTextbox.Text);
            LabelTextbox.Text = "Finished copying!";

        }
        public static void DirectorySearch(string directory)
        {
            foreach (string dir in Directory.GetDirectories(directory))
            {
                string directory_name = Path.GetFileName(dir);
                foreach (string file in Directory.GetFiles(dir, "*.jpg"))
                {
                    string new_name = File.GetCreationTime(file).ToString("yyyyMMddHHmmss") + "_" + directory_name + "_" + Path.GetFileName(file);
                    string full_name = Path.Combine("C:\\Users\\vitom\\OneDrive\\Pulpit\\Copies", new_name);
                    if (!File.Exists(full_name))
                    {
                        File.Copy(Path.GetFullPath(file), full_name);
                    }
                }
                DirectorySearch(dir);
            }
        }
    }
}