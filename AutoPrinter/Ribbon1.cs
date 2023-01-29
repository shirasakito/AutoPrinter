using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace AutoPrinter
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            int target_cell_x = 0;
            int target_cell_y = 0;
            int for_start = 0;
            int for_end = 0;
            int for_step = 0;
            int print_sheet_id = -2;

            target_cell_x = Int32.Parse(editBox1.Text);
            target_cell_y = Int32.Parse(editBox5.Text);
            for_start = Int32.Parse(editBox2.Text);
            for_end = Int32.Parse(editBox3.Text);
            for_step = Int32.Parse(editBox4.Text);

            Globals.ThisAddIn.autoprint("print", target_cell_x, target_cell_y, for_start, for_end, for_step, print_sheet_id);
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            int target_cell_x = 0;
            int target_cell_y = 0;
            int for_start = 0;
            int for_end = 0;
            int for_step = 0;
            int print_sheet_id = -2;

            target_cell_x = Int32.Parse(editBox1.Text);
            target_cell_y = Int32.Parse(editBox5.Text);
            for_start = Int32.Parse(editBox2.Text);
            for_end = Int32.Parse(editBox3.Text);
            for_step = Int32.Parse(editBox4.Text);

            Globals.ThisAddIn.autoprint("preview", target_cell_x, target_cell_y, for_start, for_end, for_step, print_sheet_id);
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            Range rng = Globals.ThisAddIn.setTargetCell();
            editBox5.Text = Convert.ToString(rng.Row);
            editBox1.Text = Convert.ToString(rng.Column);
        }

        private void toggleButton1_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void checkBox1_Click(object sender, RibbonControlEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = false;
            }
            if (checkBox1.Checked == false)
            {
                comboBox1.Enabled = true;

                int i = Globals.ThisAddIn.getAllSheetsNumber();
                //label1.Label = i.ToString();
                for (int j = 1; j <= i; j++)
                {
                    RibbonDropDownItem rd2 = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                    rd2.Label = j.ToString();
                    comboBox1.Items.Add(rd2);
                }
            }
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            editBox2.Text = "1";
            editBox3.Text = "1";
            editBox4.Text = "1";
        }

        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            editBox2.Text = "";
            editBox3.Text = "";
        }
    }
}
