using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FormApp
{
    public partial class WikiFormApp : Form
    {
        public WikiFormApp()
        {
            InitializeComponent();
        }
        static int rowSize = 12;
        static int columnSize = 4;
        static string[,] wikiArray = new string[rowSize, columnSize];
        string defaultFileName = "definitions.bin";
        static int rowCount = 0;

        private void DisplayArray()
        {
            ListBoxArray.Items.Clear();
            ListBoxArray.ClearSelected();
            for (int i = 0; i < wikiArray.GetLength(0); i++)
            {
                //ListBoxArray.Items.Add(" ");
                string oneLine = "";
                //oneLine = oneLine + "" + rowCount + " " + wikiArray[i,0] + " " + wikiArray[i, 1];
                oneLine = $"{wikiArray[i, 0],-20}" + " " + wikiArray[i, 1];
                ListBoxArray.Items.Add(oneLine);
            }            
        }

        private void WikiFormApp_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    wikiArray[i, j] = "";
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text.Equals("") ||
                TextBoxCategory.Text.Equals(""))
            {
                MessageBox.Show("Empty record can't be added.", "INPUT ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (rowCount < rowSize)
                {                    
                    var result = MessageBox.Show("Proceed with new Record?", "Add New Record",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        wikiArray[rowCount, 0] = TextBoxName.Text.ToString();
                        wikiArray[rowCount, 1] = TextBoxCategory.Text.ToString();
                        wikiArray[rowCount, 2] = TextBoxStructure.Text.ToString();
                        wikiArray[rowCount, 3] = TextBoxDefinition.Text.ToString();
                        rowCount++;
                        ClearTextBox();
                        DisplayArray();
                    }
                }
                else
                {
                    MessageBox.Show("Max record is 12 and can't be exceeded.", "INPUT ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (ListBoxArray.SelectedIndex == -1)
            {
                MessageBox.Show("No record seleted.", "UPDATE ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextBoxName.Text.Equals("") && TextBoxCategory.Text.Equals(""))
            {
                MessageBox.Show("Empty record can't be updated.", "UPDATE ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = MessageBox.Show("Proceed with update?", "Edit Record",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    wikiArray[ListBoxArray.SelectedIndex, 0] = TextBoxName.Text.ToString();
                    wikiArray[ListBoxArray.SelectedIndex, 1] = TextBoxCategory.Text.ToString();
                    wikiArray[ListBoxArray.SelectedIndex, 2] = TextBoxStructure.Text.ToString();
                    wikiArray[ListBoxArray.SelectedIndex, 3] = TextBoxDefinition.Text.ToString();
                    DisplayArray();
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxArray.SelectedIndex == -1)
            {
                MessageBox.Show("No record seleted.", "DELETE ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (wikiArray[ListBoxArray.SelectedIndex, 0].Equals(""))
            {
                MessageBox.Show("Empty record can't be deleted.", "DELETE ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult delName = MessageBox.Show("Do you wish to delete this Name?",
                 "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delName == DialogResult.Yes)
                {
                    wikiArray[ListBoxArray.SelectedIndex, 0] = "";
                    wikiArray[ListBoxArray.SelectedIndex, 1] = "";
                    wikiArray[ListBoxArray.SelectedIndex, 2] = "";
                    wikiArray[ListBoxArray.SelectedIndex, 3] = "";
                    for (int i = ListBoxArray.SelectedIndex; i < rowSize - 1; i++)
                    {
                        for (int j = 0; j < columnSize; j++)
                        {
                            wikiArray[i, j] = wikiArray[i + 1, j];
                        }
                    }
                    rowCount--;
                    for (int i = rowCount; i < rowSize; i++)
                    {
                        for (int j = 0; j < columnSize; j++)
                        {
                            wikiArray[i, j] = "";
                        }
                    }
                    ClearTextBox();
                    DisplayArray();
                    ListBoxArray.SelectedIndex = 0;
                    ListBoxArray.Focus();
                }
            }
        }

        #region FileIO
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogVG = new OpenFileDialog();
            openFileDialogVG.InitialDirectory = Application.StartupPath;
            openFileDialogVG.Filter = "BIN Files|*.bin";
            openFileDialogVG.Title = "Select a BIN File";
            if (openFileDialogVG.ShowDialog() == DialogResult.OK)
            {
                OpenRecord(openFileDialogVG.FileName);
            }
        }

        private void OpenRecord(string openFileName)
        {
            rowCount = 0;
            try
            {
                using (Stream stream = File.Open(openFileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    {
                        for (int y = 0; y < columnSize; y++)
                        {
                            for (int x = 0; x < rowSize; x++)
                            {
                                wikiArray[x, y] = (string)bin.Deserialize(stream);
                            }
                        }
                    }
                    for (int i = 0; i < rowSize; i++)
                    {
                        if (!wikiArray[i, 0].Equals(""))
                        {
                            rowCount++;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            TextBoxSearch.Clear();
            ClearTextBox();
            DisplayArray();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogVG = new SaveFileDialog();
            saveFileDialogVG.Filter = "bin file|*.bin";
            saveFileDialogVG.Title = "Save a BIN File";
            saveFileDialogVG.InitialDirectory = Application.StartupPath;
            saveFileDialogVG.DefaultExt = "bin";
            saveFileDialogVG.ShowDialog();

            string fileName = saveFileDialogVG.FileName;
            if (saveFileDialogVG.FileName != "")
            {
                SaveRecord(fileName);
            }
            else
            {
                SaveRecord(defaultFileName);
            }
        }

        private void SaveRecord(string saveFileName)
        {
            try
            {
                using (Stream stream = File.Open(saveFileName, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    {
                        for (int y = 0; y < columnSize; y++)
                        {
                            for (int x = 0; x < rowSize; x++)
                            {
                                bin.Serialize(stream, wikiArray[x, y]);
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            TextBoxSearch.Clear();
            ClearTextBox();
            ClearArray();
        }
        #endregion FileIO

        #region Search
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            BinarySearch();
        }

        private void SequentialSearch ()
        {
            Boolean found = false;
            for (int i = 0; i < rowSize; i++)
            {
                if (wikiArray[i, 0].Equals(TextBoxSearch.Text))
                {
                    TextBoxName.Text = wikiArray[i, 0];
                    TextBoxCategory.Text = wikiArray[i, 1];
                    TextBoxStructure.Text = wikiArray[i, 2];
                    TextBoxDefinition.Text = wikiArray[i, 3];
                    TextBoxSearch.Focus();
                    found = true;
                    break;
                }
            }
            if (!found)
            {                
                ClearTextBox();
                MessageBox.Show("Name search not found", "Not found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TextBoxSearch.Clear();
        }

        private void BinarySearch()
        {
            int first = 0;
            int mid = 0;
            int last = rowSize - 1;
            bool isFound = false;
            while (first <= last)
            {
                mid = (first + last) / 2;
                //if (target == myArray[mid])
                if (wikiArray[mid, 0].Equals(TextBoxSearch.Text))
                {
                    TextBoxName.Text = wikiArray[mid, 0];
                    TextBoxCategory.Text = wikiArray[mid, 1];
                    TextBoxStructure.Text = wikiArray[mid, 2];
                    TextBoxDefinition.Text = wikiArray[mid, 3];
                    TextBoxSearch.Focus();
                    ListBoxArray.SelectedIndex = mid;
                    //ListBoxArray.ForeColor = Color.Blue ;
                    isFound = true;
                    break;
                }
                //else if (target < myArray[mid])
                else if ((wikiArray[mid, 0].CompareTo(TextBoxSearch.Text) > 0) ||
                    wikiArray[mid, 0].Equals(""))
                    last = mid - 1;
                else
                    first = mid + 1;
            }
            if (!isFound)
            {                
                ClearTextBox();
                MessageBox.Show("Name search not found", "Not found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TextBoxSearch.Clear();
        }
        #endregion Search

        private void ListBoxArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxName.Text = wikiArray[ListBoxArray.SelectedIndex,0];
            TextBoxCategory.Text = wikiArray[ListBoxArray.SelectedIndex, 1];
            TextBoxStructure.Text = wikiArray[ListBoxArray.SelectedIndex, 2];
            TextBoxDefinition.Text = wikiArray[ListBoxArray.SelectedIndex, 3];
        }

        private void TextBoxSearch_DoubleClick(object sender, EventArgs e)
        {
            TextBoxSearch.Clear();
            ClearTextBox();
        }

        private void ButtonClearArray_Click(object sender, EventArgs e)
        {
            ClearArray();
        }
        
        private void ClearArray()
        {
            rowCount = 0;
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    wikiArray[i, j] = "";
                }
            }
            DisplayArray();
        }

        #region Sort
        private void ButtonSort_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = i+1; j < rowSize; j++)
                {
                    if (wikiArray[j,0].Equals(""))
                    {
                        continue;
                    } else if (wikiArray[j,0].CompareTo(wikiArray[i,0]) < 0)
                    {
                        Swap(i,j);                        
                    }
                }
            }
            TextBoxSearch.Clear();
            ClearTextBox();
            DisplayArray();
        }

        private void Swap(int current, int next)
        {
            string[] tempArray = new string[columnSize];
            for (int k = 0; k < columnSize; k++)
            {
                tempArray[k] = wikiArray[current, k];
                wikiArray[current, k] = wikiArray[next, k];
                wikiArray[next, k] = tempArray[k];
            }
        }
        #endregion Sort

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            TextBoxName.Text = "";
            TextBoxCategory.Text = "";
            TextBoxStructure.Text = "";
            TextBoxDefinition.Text = "";
        }
    }
}
