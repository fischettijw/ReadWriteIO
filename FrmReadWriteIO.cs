using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteIO
{
    public partial class FrmReadWriteIO : Form
    {
        ReadWriteCSV fileIO;
        public FrmReadWriteIO()
        {
            InitializeComponent();
        }

        private void FrmReadWriteIO_Load(object sender, EventArgs e)
        {
            BtnRead.Enabled = false;
            BtnWrite.Enabled = false;
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            TxtFirstName.Select();
            fileIO.ReadDelimitedStrings();
            LbxRows.Items.Clear();

            foreach (string person in fileIO.DelimitedLines)
            {
                LbxRows.Items.Add(person);
            }
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            if (TxtFirstName.Text + TxtLastName.Text + TxtMI.Text + TxtAge.Text == "") return;
            fileIO.WriteDelimitedString(TxtFirstName.Text, TxtLastName.Text, TxtMI.Text, TxtAge.Text);
            LbxRows.Items.Clear();
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            fileIO = new ReadWriteCSV();
            LblFilePath.Text = fileIO.FullFilePath;
            BtnRead.Enabled = true;
            BtnWrite.Enabled = true;
            BtnSelectFile.Enabled = false;
            BtnRead.PerformClick();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


public class ReadWriteCSV
{
    private string fullFilePath;
    private string delimiter;
    private List<string> delimitedLines;

    public List<string> DelimitedLines
    {
        get { return delimitedLines; }
    }

    public readonly string FullFilePath;




    public ReadWriteCSV(string delimiterChr = ",")
    {
        fullFilePath = null;
        OpenFileDialog fileInfo = new OpenFileDialog();
        fileInfo.Filter = "Text Files|*.txt; *.csv";

        while (fileInfo.ShowDialog() != DialogResult.OK) { }
        //if (fileInfo.ShowDialog() == DialogResult.OK) fullFilePath = fileInfo.FileName;
        fullFilePath = fileInfo.FileName;
        FullFilePath = fullFilePath;
        delimiter = delimiterChr;
    }

    public string CreateDelimitedString(params string[] strings)
    {
        string delimitedString = "";
        foreach (string param in strings)
        {
            delimitedString += param + $"{delimiter} ";
        }
        delimitedString = delimitedString.Remove(delimitedString.Length - 2);
        return delimitedString;
    }


    public Boolean WriteDelimitedString(params string[] strings)
    {
        string delimitedString = "";
        foreach (string param in strings)
        {
            delimitedString += param + $"{delimiter} ";
        }
        delimitedString = delimitedString.Remove(delimitedString.Length - 2);

        try
        {
            delimitedLines.Add(delimitedString);
            File.WriteAllLines(fullFilePath, delimitedLines);
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public Boolean ReadDelimitedStrings()
    {
        try
        {
            delimitedLines = File.ReadAllLines(fullFilePath).ToList();
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }


}
