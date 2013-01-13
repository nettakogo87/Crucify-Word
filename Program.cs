using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Crucify_Word.BusinessLayer;
using Crucify_Word.DomainLayer;
using Crucify_Word.PresentationLayer;

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
            view.Visible = false;
            List<Card> cards = new List<Card>();
            CardsController cardsController = new CardsController(view, cards);
            cardsController.CreateVocabulary();
            cardsController.LoadAllCards();
            cardsController.LoadView();
            Application.Run(view);
        }
    }
}
