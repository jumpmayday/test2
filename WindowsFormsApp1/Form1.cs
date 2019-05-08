using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Spire.Pdf;
using System.Drawing.Imaging;
using Spire.Pdf.Graphics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String[] files = new String[] { @"F:\360Downloads\22.pdf", @"F:\360Downloads\11.pdf" };
            string outputFile = "result.pdf";
            PdfDocumentBase doc = PdfDocument.MergeFiles(files);
            doc.Save(outputFile, FileFormat.PDF);

           
            //save text
            
            //PdfReader pdfReader = new PdfReader(@"F:\360Downloads\100个最著名的标题 杰亚伯拉罕.pdf");
            //int numberOfPages = pdfReader.NumberOfPages;
            //StringBuilder text = new StringBuilder();
            //for (int i = 1; i <= numberOfPages; ++i)
            //{
            //    text.Append(iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(pdfReader, i));
            //}
            //pdfReader.Close();
            //PDFOperation pdf = new PDFOperation();
            //pdf.Open(new FileStream(@"F:\360Downloads\11.pdf", FileMode.Append, FileAccess.Write));
            ////pdf.AddParagraph(text.ToString(), 15);
            //pdf.AddParagraph("测试文档（生成时间：" + DateTime.Now + "）", 15);
            //pdf.AddImage(@"C:\Users\Mayo\Pictures\timg.jpg",1,100,100);
            //pdf.Close();
        }
    }
}
