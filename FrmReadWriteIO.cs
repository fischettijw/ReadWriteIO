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
            fileIO = new ReadWriteCSV("Data.txt", ",");
            //fileIO = new ReadWriteCSV(@"D:\Documents\Visual Studio 2019\Projects\ReadWriteIO\bin\Debug\Data.txt", ",");
            TxtFirstName.Select();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            fileIO.ReadDelimitedStrings();
            LbxRows.Items.Clear();

            foreach (string person in fileIO.DelimitedLines)
            {
                LbxRows.Items.Add(person);
            }
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            fileIO.WriteDelimitedString(TxtFirstName.Text, TxtLastName.Text, TxtMI.Text, TxtAge.Text);
            LbxRows.Items.Clear();
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

    public string FullFilePath
    {
        get { return fullFilePath; }
        set { fullFilePath = value; }
    }

    public string Delimiter
    {
        get { return delimiter; }
        set { delimiter = value; }
    }


    public ReadWriteCSV(string filePath, string delimiterChr)
    {
        FullFilePath = filePath;
        Delimiter = delimiterChr;
    }

    public string CreateDelimitedString(params string[] strings)
    {
        string delimitedString = "";
        foreach (string param in strings)
        {
            delimitedString += param + $"{Delimiter} ";
        }
        delimitedString = delimitedString.Remove(delimitedString.Length - 2);
        return delimitedString;
    }


    public Boolean WriteDelimitedString(params string[] strings)
    {
        string delimitedString = "";
        foreach (string param in strings)
        {
            delimitedString += param + $"{Delimiter} ";
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
