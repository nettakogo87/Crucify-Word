using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/**
 * Класс Card представляет собой карточку которая содержит иностранное слово и перевод к ниму с другой стороны.
 * Так же карточка хронит прогресс которого добился пользоватьель в изученнии данного слова.
 * И конечно же номер колоды в которой на данный момент находится карточка.
 * Дата предидущего повторения, и следующего повторения добавленны для того что бы было удобно определить,
 * кодгда нужно повторить карточку.
 */
namespace Crucify_Word
{
    public class Card
    {
        public const int PACKS_COUNT = 7; // колод повторения всего 7, не считая колоды изьятия
        public const int PROGRESS_MAX = 6; // максимальный прогресс при котором слово считается изученным

        public Card()
        {
            this.id = 0;
            this.packNumber = 0;
            this.cardWord = new ForeignWord();
            this.selectTranslation = "";
            this.progress = 0;
            this.lastRepeating = DateTime.Now;
            this.newRepeating = DateTime.Now;
        }
        public Card(ForeignWord cardWord, string selectTranslation)
        {
            this.id = fake_id++; // придумать как получать новые айдишники.
            this.packNumber = Convert.ToInt16(DateTime.Now.DayOfWeek) + 1; // номера колод соответствуют дням недели
            this.cardWord = cardWord;
            this.selectTranslation = selectTranslation;
            this.cardWord.Translations.AddTranslationByWord(selectTranslation);
            this.progress = 1;
            this.lastRepeating = DateTime.Now;
            this.newRepeating = DateTime.Now;
        }
        private static int fake_id;
        private Int64 id;
        private int packNumber;
        private ForeignWord cardWord;
        private string selectTranslation;
        private int progress;
        private DateTime lastRepeating;
        private DateTime newRepeating;

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
            if (PROGRESS_MAX > this.progress)
            {
                this.progress++;
                this.packNumber += this.progress;
                if (PACKS_COUNT < this.packNumber)
                {
                    this.packNumber -= PACKS_COUNT;
                }
                this.lastRepeating = DateTime.Now;
                this.newRepeating = DateTime.Now.AddDays(this.progress);
            }
        }
        public void DecrementProgress()
        {
            if (0 < this.progress)
            {
                this.packNumber -= this.progress;
                if (0 > this.packNumber)
                {
                    this.packNumber += PACKS_COUNT;
                }
                this.progress--;
                this.lastRepeating = DateTime.Now;
                this.newRepeating = DateTime.Now.AddDays(this.progress);
            }
        }
        public void toExplore()
        {
            this.packNumber = Convert.ToInt16(DateTime.Now.DayOfWeek) + 1; // номера колод соответствуют дням недели;
            this.progress = 1;
        }
        public void markAsLearned()
        {
            this.packNumber = PACKS_COUNT + 1; // в колоду изьятия
            this.progress = PROGRESS_MAX;
        }
        public int PackNumber
        {
            get { return this.packNumber; }
            set { this.packNumber = value; }
        }
        public void initCard()
        {
            if (this.newRepeating < DateTime.Now)
            {
                this.newRepeating = DateTime.Now;
                this.packNumber = Convert.ToInt16(DateTime.Now.DayOfWeek) + 1; // номера колод соответствуют дням недели;
            }
        }

        public void save()
        {
            FileInfo newWordDoc = new FileInfo(@"voc\cards\" + this.cardWord.Word + this.id + ".txt");
            StreamWriter sw = newWordDoc.CreateText();
            sw.WriteLine(this.id);
            sw.WriteLine(this.packNumber);
            sw.WriteLine(this.selectTranslation);
            sw.WriteLine(this.progress);
            sw.WriteLine(this.lastRepeating);
            sw.WriteLine(this.newRepeating);
            sw.WriteLine(this.cardWord.Id);
            this.cardWord.save();
            sw.Close();
        }
        public void load(string wordAndId)
        {
            FileInfo newWordDoc = new FileInfo(wordAndId);
            StreamReader sw = newWordDoc.OpenText();
            this.id = Convert.ToInt16(sw.ReadLine());
            this.packNumber = Convert.ToInt16(sw.ReadLine());
            this.selectTranslation = sw.ReadLine();
            this.progress = Convert.ToInt16(sw.ReadLine());
            this.lastRepeating = Convert.ToDateTime(sw.ReadLine());
            this.newRepeating = Convert.ToDateTime(sw.ReadLine());
            sw.Close();
            this.cardWord = new ForeignWord();
            this.cardWord.load(sw.ReadLine());
        }
    }
}
