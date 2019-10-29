using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Encartage
{
    class Excel
    {
        /* @Variables */
        string path;
        _Application excel;
        Workbooks wbs;
        Workbook wb;
        Worksheet ws;



        /* @Constructor : Constructeur de la classe */
        public Excel(string path, int sheet)
        {
            this.path = path;
            excel = new _Excel.Application();
            wbs = excel.Workbooks;
            wb = wbs.Open(path);
            ws = wb.Worksheets[sheet];
        }



        /* @Method : Lit un cellule et renvoie son contenu */
        public string readCell(int row, int column)    
        {
            row++;
            column++;

            return ws.Cells[row, column].Text != null ? ws.Cells[row, column].Text : "";
        }

        /* @Method : Renvoie les coordonnées d'une cellulle nommée */
        public string readCellByName(string name)
        {
            return wb.Names.Item(name).RefersToRange.Text;
        }

        /* @Method : Écrit sur le document Excel sur une cellule précise */
        public void writeToCell(int row, int column, string txt)
        {
            row++;
            column++;
            ws.Cells[row, column].Text = txt;
        }

        /* @Method : Écrit sur le document Excel sur une portée de cellules */
        public void writeToRange(int[] start, int[] end, object data)
        {
            var startCell = (Range)ws.Cells[start[0] + 1, start[1] + 1];
            var endCell = (Range)ws.Cells[end[0] + 1, end[1] + 1];
            var writeRange = ws.Range[startCell, endCell];
            writeRange.Value2 = data;
        }

        /* @Method : Écrit sur le document Excel sur une portée de cellules nommée */
        public void writeToRangeNamed(string name, string[,] data)
        {
            Range r = wb.Names.Item(name).RefersToRange;
            Range firstCell = r[1, 1];
            Range lastCell = r[data.GetLength(0), data.GetLength(1)];
            Range writeRange = ws.Range[firstCell, lastCell];
            writeRange.Value2 = data;
        }

        /* @Method : Écrit sur le document Excel sur une cellule nommée */
        public void writeToCellNamed(string name, string txt)
        {
            Range r = wb.Names.Item(name).RefersToRange;
            r.Value2 = txt;
        }

        /* @Method : Supprime une ligne du fichier excel */
        public void deleteRow(int[] start, int[]end)
        {
            var startCell = (Range)ws.Cells[start[0] + 1, start[1] + 1];
            var endCell = (Range)ws.Cells[end[0] + 1, end[1] + 1];
            var cell = ws.Range[startCell, endCell];
            cell.Delete();
        }

        /* @Method : Sauvegarde le fichier la ou il est */
        public void save()
        {
            wb.Save();
        }

        /* @Method : Sauvegarde le fichier à l'endroit rentré en paramètre */
        public void saveAs(string path)
        {
            wb.SaveAs(path);
        }

        /* @Method : Ferme le document */
        public void close()
        {
            wb.Close();
            excel.Quit();
            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(wbs);
            Marshal.ReleaseComObject(excel);

            ws = null;
            wb = null;
            wbs = null;
            excel = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        /* @Method : Print le document */
        public void print(int copies, int selectedPrinter)
        {
            var printers = System.Drawing.Printing.PrinterSettings.InstalledPrinters;
            wb.PrintOut(Type.Missing, Type.Missing, copies, Type.Missing, printers[selectedPrinter]);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.FinalReleaseComObject(ws);
            wb.Close(false, Type.Missing, Type.Missing);
            Marshal.FinalReleaseComObject(wb);

            excel.Quit();
            Marshal.FinalReleaseComObject(excel);
        }

    }
}
