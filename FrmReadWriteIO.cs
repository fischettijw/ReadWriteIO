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
            BtnReadRecord.Enabled = false;
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
            BtnReadRecord.Enabled = true;
            BtnSelectFile.Enabled = false;
            BtnRead.PerformClick();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReadRecord_Click(object sender, EventArgs e)
        {
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtMI.Text = "";
            TxtAge.Text = "";
            if (TxtRecordNumber.Text == "" || Int32.Parse(TxtRecordNumber.Text) < 0) TxtRecordNumber.Text = "0";

            if (Int32.Parse(TxtRecordNumber.Text) > fileIO.DelimitedLines.Count - 1)
            {
                MessageBox.Show($"Record Number was TOO High --- MAX record number is {fileIO.DelimitedLines.Count - 1}");
                return;
            }

            string[] fields = ReadWriteCSV.ReadRecord(Int32.Parse(TxtRecordNumber.Text));

            TxtFirstName.Text = fields[0];
            TxtLastName.Text = fields[1];
            TxtMI.Text = fields[2];
            TxtAge.Text = fields[3];
        }
    }
}


public class ReadWriteCSV
{
    private string fullFilePath;
    private static string delimiter;
    private static List<string> delimitedLines;

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

    public static string[] ReadRecord(int recordNumber)
    {
        if (recordNumber > delimitedLines.Count - 1 || recordNumber < 0) return null;

        string record = delimitedLines.ElementAt(recordNumber);
        return record.Split(Convert.ToChar(delimiter));
    }

}
