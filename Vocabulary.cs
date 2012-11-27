using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс словаря, в нем хранятся калоды с карточками слов, которые изучает пользователь.
 * Пока можно добавить карточку или удалить, а еще получить список карточек по пренадлежности к колоде.
 * Но я думаю что в будуйщем через словарь можно будет добавлять новые слова не посредственно в "Хранилище слов"
 */
namespace Crucify_Word
{
    public class Vocabulary
    {
        public const int NUMBER_OF_REPEATED_PACK = 0;
        public const int NUMBER_OF_REMOVAL_PACK = 11;
        public const int COUNT_OF_LESSONS = 10;
        public Vocabulary(string vocabularyName)
        {
            this.id = 0; // ну как всегда придумать инкрементатор
            this.vocabularyName = vocabularyName;
            this.lessonPacks = new LessonPack[Vocabulary.COUNT_OF_LESSONS];
            // по простому заполняю номера занятий в конструкторе
            this.lessonPacks[0] = new LessonPack(1, 3, 6, 10);
            this.lessonPacks[1] = new LessonPack(2, 4, 7, 1);
            this.lessonPacks[2] = new LessonPack(3, 5, 8, 2);
            this.lessonPacks[3] = new LessonPack(4, 6, 9, 3);
            this.lessonPacks[4] = new LessonPack(5, 7, 10, 4);
            this.lessonPacks[5] = new LessonPack(6, 8, 1, 5);
            this.lessonPacks[6] = new LessonPack(7, 9, 2, 6);
            this.lessonPacks[7] = new LessonPack(8, 10, 3, 7);
            this.lessonPacks[8] = new LessonPack(9, 1, 4, 8);
            this.lessonPacks[9] = new LessonPack(10, 2, 5, 9);

            this.repeatedPack = new Pack(Vocabulary.NUMBER_OF_REPEATED_PACK);
            this.removalPack = new Pack(Vocabulary.NUMBER_OF_REMOVAL_PACK);
        }

        private Int64 id;
        private string vocabularyName;
        private Pack repeatedPack;
        private Pack removalPack;
        private LessonPack[] lessonPacks;

        public Int64 Id
        {
            get { return this.id; }
        }
        public string VocabularyName
        {
            set { this.vocabularyName = value;}
            get { return this.vocabularyName; }
        }
        public void AddCardToVocabulary(Card newCard)
        {
            this.repeatedPack.AddCard(newCard);
        }
        public void DelCardFromVocabulary(Card badCard)
        {

        }
        public List<Card> GetRepeatedCards()
        {
            return this.repeatedPack.GetCards();
        }
        public List<Card> GetRemovalCards()
        {
            return this.removalPack.GetCards();
        }
        public List<Card> GetCarsByLessonNumber(int lessonNumber)
        {
            return this.lessonPacks[lessonNumber].GetCards();
        }
        public UInt64 GetCardsCount()
        {
            UInt64 cardsCount = (UInt64)this.repeatedPack.GetCards().Count;
            cardsCount += (UInt64)this.removalPack.GetCards().Count;
            for (int i = 0; i < Vocabulary.COUNT_OF_LESSONS; i++)
            {
                cardsCount += (UInt64)this.lessonPacks[i].GetCards().Count;
            }
            return cardsCount;
        }
    }
}
