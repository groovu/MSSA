using System;
using Word = Microsoft.Office.Interop.Word;

namespace UseWordConsoleApp
{
    internal class UseWord : IDisposable
    {
        private dynamic word, doc;

        public void InvokeWord()
        {
            //            try
            //            {
            //                string path = "C:\\scratch\\demo.docx";
            //                word = new Word.Application { Visible = false };
            //
            //                //doc.Write();
            //                doc = word.Documents.Add();
            //                doc.Activate();
            //
            //                dynamic currentLocation = word.ActiveDocument.Range(word.ActiveDocument.Content.End - 1);
            //
            //                currentLocation.InsertAfter("Hi there");
            //                dynamic currentDocument = word.ActiveDocument;
            //
            //                currentDocument.Save();
            //                currentDocument.Close();
            //                Console.WriteLine("Done");
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            string path = "C:\\scratch\\demo.docx";
            word = new Word.Application { Visible = false };

            //doc.Write();
            doc = word.Documents.Add();
            doc.Activate();

            dynamic currentLocation = word.ActiveDocument.Range(word.ActiveDocument.Content.End - 1);

            currentLocation.InsertAfter("Hi there");
            dynamic currentDocument = word.ActiveDocument;

            currentDocument.SaveAs();
            currentDocument.Close();
            Console.WriteLine("Done");
        }
        ~UseWord()
        {
            word = null;
            doc = null;
            Console.WriteLine("Disposed in destructor");
            Console.ReadLine();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            doc = null;
            word = null;
            Console.WriteLine("Disposed!");
        }
        public UseWord()
        {

        }
    }
}
