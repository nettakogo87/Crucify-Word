using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс Card представляет собой карточку которая содержит иностранное слово и перевод к ниму с другой стороны.
 * Так же карточка хронит прогресс которого добился пользоватьель в изученнии данного слова.
 */
namespace Crucify_Word
{
    public class Card
    {
        public Card(ForeignWord cardWord, string selectTranslation)
        {
            this.id = 0; // придумать как получать новые айдишники.
            this.cardWord = cardWord;
            this.selectTranslation = selectTranslation;
            this.cardWord.Translations.AddTranslationByWord(selectTranslation);
        }

        private Int64 id;
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
    }
}
