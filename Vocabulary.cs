using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/**
 * Хранит все карточки пользователя
 * Пока можно добавить карточку или удалить, а еще получить список карточек.
 * Но я думаю что в будуйщем через словарь можно будет добавлять новые слова не посредственно в "Хранилище слов"
 */
namespace Crucify_Word
{
    public class Vocabulary
    {
        public Vocabulary(string vocabularyName)
        {
            this.vocabularyName = vocabularyName;
            this.cards = new List<Card>();
        }
        private List<Card> cards;
        private string vocabularyName;

        public string VocabularyName
        {
            set { this.vocabularyName = value; }
            get { return this.vocabularyName; }
        }
        public List<Card> GetAllCards()
        {
            return this.cards.GetRange(0, this.cards.Count);
        }
        public List<Card> GetCardsForLesson()
        {
            List<Card> cardsForLesson = new List<Card>();
            foreach (Card card in this.cards)
            {
                if (card.NewRepeating.Date == DateTime.Now.Date)
                {
                    cardsForLesson.Add(card);
                }
            }
            return cardsForLesson;
        }


        public void AddCardToVocabulary(Card newCard)
        {
            if (!this.ExistCard(newCard))
            {
                cards.Add(newCard);
            }
        }
        public void RemoveCardFromVocabulary(Card badCard)
        {
            if (this.ExistCard(badCard))
            {
                cards.Remove(badCard);
            }
        }
        public int GetCardsCount()
        {
            return this.cards.Count;
        }

        public void saveCardById(int id)
        {
            foreach (Card card in this.cards)
            {
                if (card.Id == id)
                {
                    FileInfo saveWord = new FileInfo(@"vocabulary\cards\" + id + ".txt");
                    StreamWriter sw = saveWord.CreateText();
                    sw.WriteLine(card.ForeignWord);
                    sw.WriteLine(card.Transcription);
                    sw.WriteLine(card.Translation);
                    sw.WriteLine(card.PackNumber);
                    sw.WriteLine(card.Progress);
                    sw.WriteLine(card.Id);
                    sw.WriteLine(card.LastRepeating);
                    sw.WriteLine(card.NewRepeating);
                    sw.Close();
                    break;
                }
            }
        }

        public void InitVocabulary()
        {
            DirectoryInfo vocabularyDir = new DirectoryInfo(@"vocabulary\cards");
            if (vocabularyDir.Exists)
            {
                this.cards.RemoveRange(0, this.cards.Count);
                this.loadAllCards();
                foreach (Card card in this.cards)
                {
                    card.initCard();
                }
            }
            else
            {
                vocabularyDir.Create();
            }
        }
        // приватные методы 

        private void loadAllCards()
        {
            DirectoryInfo vocabularyDir = new DirectoryInfo(@"vocabulary\cards");
            for (int i = 0; i < vocabularyDir.GetFiles().Length; i++)
            {
                FileInfo loadWord = new FileInfo(@"vocabulary\cards\" + vocabularyDir.GetFiles()[i].Name);
                StreamReader sr = loadWord.OpenText();
                Card newCard = new Card(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
                sr.Close();
                this.AddCardToVocabulary(newCard);
            }
            Card.inc_id = this.GetCardMaxId();
        }

        private bool ExistCard(Card newCard)
        {
            return this.cards.Exists(
                delegate(Card card)
                {
                    return card.ForeignWord == newCard.ForeignWord && card.Translation == newCard.Translation;
                }
            );
        }
        private bool ExistCard(string word, string translation)
        {
            return this.cards.Exists(
                delegate(Card card)
                {
                    return card.ForeignWord == word && card.Translation == translation;
                }
            );
        }
        private int GetCardMaxId()
        {
            int maxId = 0;
            foreach (Card card in this.cards)
            {
                if (maxId < card.Id)
                {
                    maxId = card.Id;
                }
            }
            return maxId;
        }
    }
}
