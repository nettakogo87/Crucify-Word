using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс Card представляет собой карточку которая содержит иностранное слово и перевод к ниму с другой стороны.
 * Так же карточка хронит прогресс которого добился пользоватьель в изученнии данного слова.
 * И конечно же номер колоды в которой на данный момент находится карточка.
 */
namespace Crucify_Word
{
    public class Card
    {
        public Card(ForeignWord cardWord, string selectTranslation)
        {
            this.id = fake_id++; // придумать как получать новые айдишники.
            this.packNumber = 0;
            this.cardWord = cardWord;
            this.selectTranslation = selectTranslation;
            this.cardWord.Translations.AddTranslationByWord(selectTranslation);
            this.progress = 0;
        }
        private static int fake_id;
        private Int64 id;
        private int packNumber;
        private ForeignWord cardWord;
        private string selectTranslation;
        private int progress;

        public ForeignWord CardWord
        {
            get { return this.cardWord; }
        }
        public string SelectTranslation
        {
            get { return this.selectTranslation; }
            set { this.selectTranslation = value; }
        }
        public int Progress
        {
            get { return this.progress; }
        }
        public void IncrementProgress()
        {
            if (5 > this.progress)
            {
                this.progress++;
            }
        }
        public void DecrementProgress()
        {
            if (0 < this.progress)
            {
                this.progress--;
            }
        }
        public void toExplore()
        {
            this.packNumber = 0;
            this.progress = 0;
        }
        public void markAsLearned()
        {
            this.packNumber = 11;
            this.progress = 5;
        }
        public int PackNumber
        {
            get { return this.packNumber; }
            set { this.packNumber = value; }
        }
    }
}
