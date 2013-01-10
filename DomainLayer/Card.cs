using System;

/**
 * Класс Card представляет собой карточку которая содержит иностранное слово и перевод к ниму с другой стороны.
 * Так же карточка хронит прогресс которого добился пользоватьель в изученнии данного слова.
 * И конечно же номер колоды в которой на данный момент находится карточка.
 * Дата предидущего повторения, и следующего повторения добавленны для того что бы было удобно определить,
 * кодгда нужно повторить карточку.
 */
namespace Crucify_Word.DomainLayer
{
    public class Card
    {
        public const int PROGRESS_MAX = 6; // максимальный прогресс при котором слово считается изученным

        public Card(int id, string foreignWord, string transcription, string translation)
        {
            this.Id = id;
            this.ForeignWord = foreignWord;
            this.Transcription = transcription;
            this.Translation = translation;
            this.Progress = 0;
        }
        public int Id { get; set; }

        public string ForeignWord { get; set; }

        public string Transcription { get; set; }

        public string Translation { get; set; }

        public int Progress { get; set; }
    }
}
