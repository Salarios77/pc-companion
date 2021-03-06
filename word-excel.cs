﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Office;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;

namespace CompanionApp
{
    class WordApp
    {
        //INSERT FIELDS AS NECESSARY 
        public void wordCommand(String s)
        {
            Word.Application myWordApp = null;
            try
            {
                myWordApp =
                  System.Runtime.InteropServices.Marshal.GetActiveObject(
                  "Word.Application") as Word.Application;
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Console.WriteLine(
                  String.Format("Word application was not running: {0}",
                  e.Message));
                return;
            }

            if (myWordApp != null)
            {
                Console.WriteLine(
                  "Successfully attached to running instance of Word.");

                try
                {
                    Word.Document myWordDocument = myWordApp.ActiveDocument;
                    //EXCECUTE COMMAND
                    myWordApp.Selection.Font.Bold = 1;
                }
                catch (Exception e)
                {
                    Console.WriteLine("No document open");
                }
            }
        }
    }
    class excelApp
    {
        public void ExcelCommand(String s)
        {
            Excel.Application myExcelApp = null;
            try
            {
                myExcelApp =
                  System.Runtime.InteropServices.Marshal.GetActiveObject(
                  "Excel.Application") as Excel.Application;
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Console.WriteLine(
                  String.Format("Excel application was not running: {0}",
                  e.Message));
                return;
            }

            if (myExcelApp != null)
            {
                Console.WriteLine(
                  "Successfully attached to running instance of Excel.");
                try
                {
                    Excel.Workbook myWordDocument = myExcelApp.ActiveWorkbook;
                    //EXCECUTE COMMAND
                    myExcelApp.Selection.Font.Bold = 1;
                }
                catch (Exception e)
                {
                    Console.WriteLine("No workbook open");
                }
            }
        }
    }
}
