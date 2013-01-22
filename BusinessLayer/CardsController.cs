using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Crucify_Word.DomainLayer;
using Crucify_Word.PresentationLayer;

namespace Crucify_Word.BusinessLayer
{
    public class CardsController : Crucify_Word.BusinessLayer.ICardsController
    {
        private IView _cardsView;
        private List<Card> _cards;
        public CardsController(IView view)
        {
            _cardsView = view;
            CreateVocabulary();
            _cards = new List<Card>();
            LoadAllCards();
        }
        public void CreateCard(string foreignWord, string transcription, string translation)
        {
            int id = CreateID();
            Card newCard = new Card(id, foreignWord, transcription, translation);
            _cards.Add(newCard);
            SaveCardById(id);
        }

        public void LoadAllCards()
        {
            string[] files = Directory.GetFiles(@"vocabulary\cards");

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo loadWord = new FileInfo(files[i]);
                StreamReader sr = loadWord.OpenText();
                Card newCard = new Card(Convert.ToInt32(sr.ReadLine()), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
                _cards.Add(newCard);
                sr.Close();
            }
        }

        public void SaveCardById(int id)
        {
            foreach (Card card in _cards)
            {
                if (card.Id == id)
                {
                    FileInfo saveWord = new FileInfo(@"vocabulary\cards\" + id + ".txt");
                    StreamWriter sw = saveWord.CreateText();
                    sw.WriteLine(card.Id);
                    sw.WriteLine(card.ForeignWord);
                    sw.WriteLine(card.Transcription);
                    sw.WriteLine(card.Translation);
                    sw.Close();
                    break;
                }
            }
        }

        public void RemoveCardById(int id)
        {
            foreach (Card card in _cards)
            {
                if (card.Id == id)
                {
                    FileInfo saveWord = new FileInfo(@"vocabulary\cards\" + id + ".txt");
                    if (saveWord.Exists)
                    {
                        saveWord.Delete();
                    }
                    _cards.Remove(card);
                    break;
                }
            }
        }

        public List<Card> GetAllCards()
        {
            return _cards;
        }

        public int CreateID()
        {
            int maxID = 0;
            foreach (var card in _cards)
            {
                if (card.Id > maxID)
                {
                    maxID = card.Id;
                }
            }
            return maxID + 1;
        }
        public void CreateVocabulary()
        {
            DirectoryInfo vocabulary = new DirectoryInfo(@"vocabulary\cards\");
            if (!vocabulary.Exists)
            {
                vocabulary.Create();
            }
        }
    }
}
