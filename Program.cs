using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Crucify_Word.BusinessLayer;
using Crucify_Word.DomainLayer;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow view = new MainWindow();
            Application.Run(view);
        }
    }
}
