using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using ClosedXML.Excel;
using Microsoft.Win32;
using ROCAD.Model;

namespace ROCAD.Controller
{
    public class ExportationHandler
    {
        public static void exportAsCsv(List<Student> studentList, string path)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2]
            {
                new DataColumn("ID", typeof(string)), new DataColumn("GRADE", typeof(double))
            });
            foreach (Student s in studentList)
            {
                dt.Rows.Add(s.id(), s.grade());
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Results");
                wb.SaveAs(path);
            }
        }
    }
}
