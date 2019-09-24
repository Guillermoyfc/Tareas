using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace tarea1._2
{
    public class WordClase
    {

        public void WriteToWordDoc(string filepath, string txt)
        {
            // Open a WordprocessingDocument for editing using the filepath.
            using (WordprocessingDocument wordprocessingDocument =
                 WordprocessingDocument.Open(filepath, true))
            {
                // Assign a reference to the existing document body.
                Body body = wordprocessingDocument.MainDocumentPart.Document.Body;

                // Add a paragraph with some text.
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text(txt));
                run.AppendChild(new Text(txt));
                run.AppendChild(new Text(txt));
            }
        }


        public void CreateWordDoc(string filepath, string msg)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Create(filepath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                // Add a main document part. 
                MainDocumentPart mainPart = doc.AddMainDocumentPart();

                // Create the document structure and add some text.
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());

                // String msg contains the text, "Hello, Word!"
                run.AppendChild(new Text(msg));
            }
        }


        public void InsertTableInDoc(string filepath, string texto1, string texto2)
        {
            using (WordprocessingDocument wordprocessingDocument =
                 WordprocessingDocument.Create(filepath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {

                MainDocumentPart mainPart = wordprocessingDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                // Create a table.
                Table tbl = new Table();

                // Set the style and width for the table.
                TableProperties tableProp = new TableProperties();
                TableStyle tableStyle = new TableStyle() { Val = "TableGrid" };

                // Make the table width 100% of the page width.
                TableWidth tableWidth = new TableWidth() { Width = "5000", Type = TableWidthUnitValues.Pct };

                // Apply
                tableProp.Append(tableStyle, tableWidth);
                tbl.AppendChild(tableProp);

                // Add 3 columns to the table.
                TableGrid tg = new TableGrid(new GridColumn(), new GridColumn(), new GridColumn());
                tbl.AppendChild(tg);

                // Create 1 row to the table.
                TableRow tr1 = new TableRow();

                // Add a cell to each column in the row.
                TableCell tc1 = new TableCell(new Paragraph(new Run(new Text(texto1))));
                TableCell tc2 = new TableCell(new Paragraph(new Run(new Text(texto2))));
                tr1.Append(tc1, tc2);

                // Add row to the table.
                tbl.AppendChild(tr1);

                // Add the table to the document
                body.AppendChild(tbl);
                
            }
        }
    }
}
