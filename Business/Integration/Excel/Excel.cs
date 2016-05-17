using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Drawing.Printing;
using ClassLibrary;
using System.IO;

namespace Buisness.Integration.Excel
{
    using ClassLibrary;
    using Business.Calculations;
    public class Excel
    {

        // årsförsäljningsstatistik exportering till excelapp.
        public void ÅrStatistik(string År, string användarnamn)
        {

            using (var unitOfWork = new Business.UnitOfWork(new Data.DataModel()))
            {
                Anställd an = unitOfWork.Anställda.Get_Anställd_With_Användarnamn(användarnamn);
            

            List<List<string>> AnställdaResultat = YearlyReport.YearStatistics(År);

            try
            {

                Application xla = new Application();
                Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = xla.ActiveSheet;

                xla.Visible = true;

                ws.Cells[1, 1] = "År";
                ws.Cells[2, 1] = "Säljare";

                ws.Cells[1, 2] = "Januari";
                ws.Cells[2, 2] = "Barnförsäkringar";
                ws.Cells[2, 3] = "Vuxenförsäkringar";
                ws.Cells[2, 4] = "Försäkringar";

                ws.Cells[1, 5] = "Februari";
                ws.Cells[2, 5] = "Barnförsäkringar";
                ws.Cells[2, 6] = "Vuxenförsäkringar";
                ws.Cells[2, 7] = "Försäkringar";

                ws.Cells[1, 8] = "Mars";
                ws.Cells[2, 8] = "Barnförsäkringar";
                ws.Cells[2, 9] = "Vuxenförsäkringar";
                ws.Cells[2, 10] = "Försäkringar";

                ws.Cells[1, 11] = "April";
                ws.Cells[2, 11] = "Barnförsäkringar";
                ws.Cells[2, 12] = "Vuxenförsäkringar";
                ws.Cells[2, 13] = "Försäkringar";

                ws.Cells[1, 14] = "Maj";
                ws.Cells[2, 14] = "Barnförsäkringar";
                ws.Cells[2, 15] = "Vuxenförsäkringar";
                ws.Cells[2, 16] = "Försäkringar";

                ws.Cells[1, 17] = "Juni";
                ws.Cells[2, 17] = "Barnförsäkringar";
                ws.Cells[2, 18] = "Vuxenförsäkringar";
                ws.Cells[2, 19] = "Försäkringar";

                ws.Cells[1, 20] = "Juli";
                ws.Cells[2, 20] = "Barnförsäkringar";
                ws.Cells[2, 21] = "Vuxenförsäkringar";
                ws.Cells[2, 22] = "Försäkringar";

                ws.Cells[1, 23] = "Augusti";
                ws.Cells[2, 23] = "Barnförsäkringar";
                ws.Cells[2, 24] = "Vuxenförsäkringar";
                ws.Cells[2, 25] = "Försäkringar";

                ws.Cells[1, 26] = "September";
                ws.Cells[2, 26] = "Barnförsäkringar";
                ws.Cells[2, 27] = "Vuxenförsäkringar";
                ws.Cells[2, 28] = "Försäkringar";

                ws.Cells[1, 29] = "Oktober";
                ws.Cells[2, 29] = "Barnförsäkringar";
                ws.Cells[2, 30] = "Vuxenförsäkringar";
                ws.Cells[2, 31] = "Försäkringar";

                ws.Cells[1, 32] = "November";
                ws.Cells[2, 32] = "Barnförsäkringar";
                ws.Cells[2, 33] = "Vuxenförsäkringar";
                ws.Cells[2, 34] = "Försäkringar";

                ws.Cells[1, 35] = "December";
                ws.Cells[2, 35] = "Barnförsäkringar";
                ws.Cells[2, 36] = "Vuxenförsäkringar";
                ws.Cells[2, 37] = "Försäkringar";

                ws.Cells[2, 38] = "Medel";
                ws.Cells[2, 39] = "Total";

                int sum;
                int sumSum = 0;
                int rad = 3;



                int antalFörsäkringar = 0;
                int antalFörsäkringarAnställd;
                foreach (List<string> AnställdÅr in AnställdaResultat)
                {
                    sum = 0;
                    antalFörsäkringarAnställd = 0;

                    ws.Cells[rad, 1] = AnställdÅr[0]; // säljares namn
                    for (int cell = 2; cell < 38; cell += 3)// vaje månad
                    {
                        for (int typ = 0; typ < 3; typ++) //  typ försäljning
                        {
                            if (typ == 0) ws.Cells[rad, cell + typ] = AnställdÅr[cell - 1]; // barn
                            else if (typ == 1) ws.Cells[rad, cell + typ] = AnställdÅr[cell + 0]; // vuxen
                            else if (typ == 2) // summerings typ
                            {
                                ws.Cells[rad, cell + typ] = AnställdÅr[cell + 1];
                                if (AnställdÅr[cell + 1] != "0")
                                {
                                    sum += Convert.ToInt32((AnställdÅr[cell + 1]));// total
                                    antalFörsäkringarAnställd++; // för att beräkna medel
                                }
                            }

                        }
                    }
                    sumSum += sum; //total för alla säljare

                    if (sum != 0) ws.Cells[rad, 38] = sum / antalFörsäkringarAnställd;
                    ws.Cells[rad, 39] = sum.ToString();
                    rad++; // nästa säljare
                    antalFörsäkringar += antalFörsäkringarAnställd;
                }

                if (sumSum != 0) ws.Cells[1, 38] = sumSum / antalFörsäkringar; // medelvärdet
                ws.Cells[1, 39] = sumSum.ToString();

                ws.Columns.AutoFit();

                Range chartRange;
                ChartObjects xlCharts = (ChartObjects)ws.ChartObjects(Type.Missing);
                ChartObject myChart = (ChartObject)xlCharts.Add(10, 80, 300, 250);
                Chart chartPage = myChart.Chart;
                //chartPage.ChartTitle = "Säljarens namn";

                chartRange = ws.get_Range("A1", "d5");
                chartPage.SetSourceData(chartRange, System.Reflection.Missing.Value);
                chartPage.ChartType = XlChartType.xlColumnClustered;


            }
            catch (Exception ex)
            {
                throw new Exception("Couldn't create Excel file Exception: " + ex.Message);

            }
        }
    }
 
    }
}
