using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel1 = Microsoft.Office.Interop.Excel;


namespace Loja_de_Eletronicos
{
    internal class Excel
    {
        public void ExcelAdd(int id, string nome, double valor, string df, int quantidade)
        {

            Excel1.Application excelApp = new Excel1.Application();
            Excel1.Workbook excelWorkbook = null;
            Excel1.Worksheet excelWorksheet = null;


            try
            {
                // Abra o arquivo Excel
                excelWorkbook = excelApp.Workbooks.Open(@"C:\Users\Duda\Downloads\Loja_Eletronica-main\Loja de Eletronicos\Banco Dados\Estoque.xlsx");

                // Escolha a planilha que você deseja ler (neste caso, a primeira planilha)
                excelWorksheet = excelWorkbook.Sheets[1];

                // Encontre a última linha preenchida na coluna "A"
                int lastRow = excelWorksheet.Cells[excelWorksheet.Rows.Count, 1].End[Excel1.XlDirection.xlUp].Row;

                // Calcule a próxima linha disponível para adicionar os novos dados
                int newRow = lastRow + 1;

                // Adicione os dados à próxima linha disponível
                excelWorksheet.Cells[newRow, 1].Value2 = id;
                excelWorksheet.Cells[newRow, 2].Value2 = nome;
                excelWorksheet.Cells[newRow, 3].Value2 = valor;
                excelWorksheet.Cells[newRow, 4].Value2 = df;
                excelWorksheet.Cells[newRow, 5].Value2 = quantidade;
                //COLUNAS
                excelWorksheet.Cells[1, 1].Value2 = "Id";
                excelWorksheet.Cells[1, 2].Value2 = "Produto";
                excelWorksheet.Cells[1, 3].Value2 = "Valor";
                excelWorksheet.Cells[1, 4].Value2 = "DataFabricação";
                excelWorksheet.Cells[1, 5].Value2 = "Quantidade";

                // Salve as alterações no arquivo
                excelWorkbook.Save();

                excelWorkbook.Close(true);
                Marshal.ReleaseComObject(excelWorkbook);
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado");
            }

        }
    }
}
