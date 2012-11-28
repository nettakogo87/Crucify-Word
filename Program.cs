using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Crucify_Word
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DirectoryInfo voc = new DirectoryInfo(@"voc");
            if (!voc.Exists)
            {
                voc.Create();
            }
            DirectoryInfo translations = new DirectoryInfo(@"voc\translations");
            if (!translations.Exists)
            {
                translations.Create();
            }
            DirectoryInfo cards = new DirectoryInfo(@"voc\cards");
            if (!cards.Exists)
            {
                cards.Create();
            }
            DirectoryInfo foreignWords = new DirectoryInfo(@"voc\foreign_words");
            if (!foreignWords.Exists)
            {
                foreignWords.Create();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
