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

        public Card(string foreignWord, string translation)
            : this(foreignWord, String.Empty, translation)
        {
        }
        public Card(string foreignWord, string transcription, string translation)
        {
            this.id = fake_id++;
            this.packNumber = Convert.ToInt16(DateTime.Now.DayOfWeek) + 1; // номера колод соответствуют дням недели
            this.foreignWord = foreignWord;
            this.transcription = transcription;
            this.translation = translation;
            this.progress = 1;
            this.lastRepeating = DateTime.Now;
            this.newRepeating = DateTime.Now;
        }
        // Этот конструктор мне потребуется когда я буду загружать данные карточек и создавать по ним сами карточки
        public Card(string foreignWord, string transcription, string translation, int id)
        {
            this.id = id;
            this.packNumber = Convert.ToInt16(DateTime.Now.DayOfWeek) + 1; // номера колод соответствуют дням недели
            this.foreignWord = foreignWord;
            this.transcription = transcription;
            this.translation = translation;
            this.progress = 1;
            this.lastRepeating = DateTime.Now;
            this.newRepeating = DateTime.Now;
        }
        private static int fake_id;
        private int id;
        private int packNumber;
        private string foreignWord;
        private string transcription;
        private string translation;
        private int progress;
        private DateTime lastRepeating;
        private DateTime newRepeating;

        public int Id
        {
            get { return this.id; }
        }
        public string ForeignWord
        {
            get { return this.foreignWord; }
        }
        public string Transcription
        {
            get { return this.transcription; }
            set { this.transcription = value; }
        }
        public string Translation
        {
            get { return this.translation; }
            set { this.translation = value; }
        }
        public int Progress 
        {
            get { return this.progress; }
        }
        public DateTime LastRepeating
        {
            get { return this.lastRepeating; }
        }
        public DateTime NewRepeating
        {
            get { return this.newRepeating; }
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
    }
}
