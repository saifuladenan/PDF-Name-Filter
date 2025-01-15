using System.Diagnostics;
using iTextSharp.text.pdf;
using Image = System.Drawing.Image;
using Rectangle = iTextSharp.text.Rectangle;
using System.IO;


namespace PDF_Name_Filter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDGV_FileName();
            string startupDirectory = Application.StartupPath;
            string imagePath = System.IO.Path.Combine(startupDirectory, "logo.PNG");

            if (System.IO.File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void InitializeDGV_FileName()
        {
            DGV_FileName.DataSource = null;
            DGV_FileName.Rows.Clear();

            if (DGV_FileName.Columns.Count == 0)
            {
                DGV_FileName.Columns.Add("PDFNAME", "PDF Name");

            }
            ResizeDataGridView(DGV_FileName);
        }
        private void ResizeDataGridView(DataGridView dgv)
        {
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            int totalWidth = dgv.Columns.Cast<DataGridViewColumn>().Sum(col => col.Width);
            int availableWidth = dgv.ClientSize.Width;
            if (availableWidth > totalWidth)
            {
                float scaleFactor = (float)availableWidth / totalWidth;
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.Width = (int)(column.Width * scaleFactor);
                }
            }
        }
        private void Txtbx_SDir_TextChanged(object sender, EventArgs e)
        {
            InitializeDGV_FileName();
            LoadDGV_FileName();
        }
        private void LoadDGV_FileName()
        {
            string sourcePath = Txtbx_SDir.Text;
            string ResultPath = Path.Combine(sourcePath, "Result");
            string filePath = "";
            string fileName = "";
            string fileDir ="";
            if (Directory.Exists(ResultPath))
            {
                DeleteFolderContents(ResultPath);
            }
            DGV_FileName.Rows.Clear();
            if (Directory.Exists(sourcePath))
            {
                string[] pdfFiles = Directory.GetFiles(sourcePath, "*.txt", SearchOption.AllDirectories);
                if (pdfFiles.Length > 0)
                {
                     filePath = pdfFiles[0];  
                     fileName = Path.GetFileName(filePath);
                    lbl_FileName.Text = fileName;
                     fileDir = Path.Combine(sourcePath, fileName);
                }
                try
                {
                    using (StreamReader sr = new StreamReader(fileDir))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split("|");
                            foreach (string part in parts)
                            {
                                if (part.Trim().EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                                {
                                  
                                        DGV_FileName.Rows.Add(part.Trim());
                                   
                                }
                            }
                        }
                    }
                    ResizeDataGridView(DGV_FileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading the file: {ex.Message}");
                }
            }
        }
        private void DeleteFolderContents(string folderPath)
        {
            try
            {
                if (Directory.Exists(folderPath))
                {
                    foreach (string filePath in Directory.GetFiles(folderPath))
                    {
                        File.Delete(filePath);
                    }
                    foreach (string subDirPath in Directory.GetDirectories(folderPath))
                    {
                        DeleteFolderContents(subDirPath); // Recursive call
                        Directory.Delete(subDirPath);
                    }

                    Debug.WriteLine($"Contents of folder '{folderPath}' deleted successfully.");
                }
                else
                {
                    Debug.WriteLine($"Folder '{folderPath}' does not exist.");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Debug.WriteLine($"UnauthorizedAccessException: {ex.Message}. Check permissions or file locking issues.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error deleting contents of folder '{folderPath}': {ex.Message}");
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (RB_Cut.Checked || RB_Copy.Checked)
            {
                string sourcePath = Txtbx_SDir.Text;
                string ResultPath = Path.Combine(sourcePath, "Result");
                string[] pdfFiles;
                if (!Directory.Exists(ResultPath))
                {
                    Directory.CreateDirectory(ResultPath);
                }
                if (DGV_FileName.Rows.Count > 0)
                {
                    for (int i = 0; i  < DGV_FileName.Rows.Count-1; i++)
                    {
                        var fileName = DGV_FileName.Rows[i].Cells[0].Value.ToString();
                        string sourceFilePath = Path.Combine(sourcePath, fileName); 
                        string destinationFilePath = Path.Combine(ResultPath, fileName);   
                        if(File.Exists(sourceFilePath))   
                        {
                            if (RB_Cut.Checked)
                            {
                                File.Move(sourceFilePath, destinationFilePath);
                            }
                            else if (RB_Copy.Checked) 
                            {
                                File.Copy(sourceFilePath, destinationFilePath); 
                            }
                                
                        }      
                    }   
                }   
            }
        }
    }
}
