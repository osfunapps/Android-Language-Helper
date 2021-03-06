﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Android_Language_Helper.resources.makers;
using Android_Language_Helper.resources.requests;
using LayoutProject;
using Remotes_App_Translation_Project.tools;

namespace Android_Language_Helper
{
    public partial class TranslatorForm : Form, FileMadeCallback
    {
        private string FILE_MADE = "file made!";
        private static string inputExtension;
        private bool isExcelInput;
        private bool xmlInput;
        private HintsCreator hintsCreator;

        public TranslatorForm()
        {
            InitializeComponent();
            DisableFields();
        }

        private void DisableFields()
        {
            appDetailsGB.Enabled = false;
            saveGB.Enabled = false;
        }


        private void DragEnterHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void InputFileDropHandler(object sender, DragEventArgs e)
        {
            inputPathTB.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
        }

        private void inputPathTB_TextChange(object sender, EventArgs e)
        {
            string inputPath = inputPathTB.Text;
            outputPathTB.Text = "";
            //            string dos = senderStirng.Substring(sender.LastIndexOf("."));

            if (inputPath != null && !inputPath.Equals("") && inputPath.Contains("."))
            {
                inputExtension = inputPath.Substring(inputPath.LastIndexOf(".") + 1);
                Console.WriteLine("ext: " + inputExtension);
                if (inputExtension.Contains(ErrorBank.XLS_EXCEL_EXT) || inputExtension.Contains(ErrorBank.XLSX_EXCEL_EXT)) inputExcel();
                else if (inputExtension.Equals(ErrorBank.XML_EXT)) inputXML();
                else
                {
                    inputPathTB.Clear();
                    MessageBox.Show(ErrorBank.BAD_INPUT_MSG);
                    return;
                }
            }
        }

        private void inputXML()
        {
            isExcelInput = false;
            xmlInput = true;
        }

        private void inputExcel()
        {
            isExcelInput = true;
            appDetailsGB.Enabled = false;
        }


        private void GoBtn_Click(object sender, EventArgs e)
        {
            //todo: so far, not yelling if ALL fields not empty!
            if (inputPathTB.Text.Equals(""))
            {
                MessageBox.Show(ErrorBank.SELECT_A_FILE);
                return;
            }
            else if (!isExcelInput && languageTB.Text.Equals(""))
            {
                MessageBox.Show(ErrorBank.SELECT_A_LANGUAGE);
                return;
            }

            prepareCoordinator();
        }

        private void prepareCoordinator()
        {
            FilesCoordinator filesCoordinator = new FilesCoordinator(this);
            if (isExcelInput)
            {
                XmlRequest xmlRequest = new XmlRequest(inputPathTB.Text, outputPathTB.Text);
                filesCoordinator.coordinateFiles(xmlRequest);
            }

            else
            {
                XlsxRequest xlsxRequest = new XlsxRequest(inputPathTB.Text, outputPathTB.Text);
                xlsxRequest.Language = languageTB.Text;
                xlsxRequest.AppSummary = appSummaryTB.Text;
                xlsxRequest.AppName = appNameTB.Text;
                xlsxRequest.AppDescription = appDescriptionRTB.Text;
                filesCoordinator.coordinateFiles(xlsxRequest);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            inputPathTB.Text = TitleExporter(sender.ToString());
            saveGB.Enabled = true;
        }

        private string TitleExporter(string fileLongStr)
        {
            return fileLongStr.ToString().Substring(fileLongStr.ToString().IndexOf("FileName: ") + 10);

        }

        private void inputBrowseBtn_Click(object sender, EventArgs e)
        {
            inputPathDialog.ShowDialog();
        }


        private void saveAsBtn_Click(object sender, EventArgs e)
        {

            if (inputPathTB.Text.Equals(""))
            {
                MessageBox.Show(ErrorBank.NO_INPUT);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (inputExtension.Equals(ErrorBank.XML_EXT))
                saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
            else
                saveFileDialog.Filter = "xml File (*.xml)|*.xml";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputPathTB.Text = saveFileDialog.FileName;
            }

            if (xmlInput) { 
                appDetailsGB.Enabled = true;
                setHints();
            }
        }

        private void setHints()
        {
            hintsCreator = new HintsCreator();
            appNameTB.Enter += hintsCreator.OnTBHint_Enter;
            appNameTB.Leave += hintsCreator.OnTBHint_Leave;
            hintsCreator.OnTBHint_Leave(appNameTB, null);
            appSummaryTB.Enter += hintsCreator.OnTBHint_Enter;
            appSummaryTB.Leave += hintsCreator.OnTBHint_Leave;
            hintsCreator.OnTBHint_Leave(appSummaryTB, null);
            languageTB.Enter += hintsCreator.OnTBHint_Enter;
            languageTB.Leave += hintsCreator.OnTBHint_Leave;
            hintsCreator.OnTBHint_Leave(languageTB, null);

            appDescriptionRTB.Enter += hintsCreator.OnRTBHint_Enter;
            appDescriptionRTB.Leave += hintsCreator.OnRTBHint_Leave;
            hintsCreator.OnRTBHint_Leave(appDescriptionRTB, null);

        }

        public void onXlsxFileMade()
        {
            MessageBox.Show(FILE_MADE);
        }

        public void onXmlFileMade(XmlRequest xmlRequest)
        {
            appNameTB.Text = xmlRequest.TranslatedAppName;
            appDescriptionRTB.Text = xmlRequest.TranslatedAppDescription;
            appSummaryTB.Text = xmlRequest.TranslatedAppSummary;
            languageTB.Text = xmlRequest.Translation;
            appDetailsGB.Enabled = true;
        }

        private void logBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Logger.GetTxt());

        }

    }
}
