using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace AutoPrinter
{

    public partial class ThisAddIn
    {
        public int getAllSheetsNumber()
        {
            Excel.Sheets sheets = ((Excel.Sheets)Application.Sheets);
            return sheets.Count;
        }

        public List<string> getAllSheetsName()
        {
            // todo: sheet 名の取得
            Excel.Sheets sheets = ((Excel.Sheets)Application.Sheets);

            List<string> all_sheets_name_list = new List<string>();
            return all_sheets_name_list;
        }

        public Range setTargetCell()
        {
            Range rng = (Range)Globals.ThisAddIn.Application.Selection;
            return rng;
        }

        public void autoprint(string args, int arg_target_cell_x, int arg_target_cell_y, int arg_for_start, int arg_for_end, int arg_for_step, int print_sheet_id)
        {
            
            Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Application.ActiveSheet);

            // 取得したセルのレンジ
            Range rng2 = (Range)Globals.ThisAddIn.Application.ActiveSheet.Cells[arg_target_cell_y, arg_target_cell_x];

            // 現在選択中のセルのレンジ
            //Range rng = (Range)Globals.ThisAddIn.Application.Selection;
            

            for (int i = arg_for_start; i <= arg_for_end; i = i + arg_for_step)
            {
                rng2[1, 1] = i;

                if (print_sheet_id != -2)
                {

                }

                if (args == "print")
                {
                    activeWorksheet.PrintOut();
                }

                if (args == "preview")
                {

                }

                if (print_sheet_id != -2)
                {

                }
            }
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
