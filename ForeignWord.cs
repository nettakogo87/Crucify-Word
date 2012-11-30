using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/**
 * Класс Иностранное слово. Содержит уникальный ID и уникальное слово. 
 * В данный момент содержит только один перевод. Но в будуйщем переводы можно будет добавлять.
 */
namespace Crucify_Word
{
    public class ForeignWord
    {
        public const int VERB = 1; // глагол
        public const int NOUN = 2; // существительные
        public const int ARTICLE = 3; // артикл
        public const int ADJECTIVE = 4; // прилагательные
        public const int PRONOUN = 5; // местоимения
        public const int NUMERAL = 6; // числительные
        public const int ADVERB = 7; // наречия
        public const int PREPOSITION = 8; // предлоги
        public const int CONJUNCTION = 9; // союзы
        public const int NOT_KNOW = 10; // в случае если человек затрудняется выбрать

        public ForeignWord()
        {
            this.id = 0; // придумать очень сложный способ вычисления нового id
            this.word = "";
            this.transcription = "";
            this.translations = new TranslationList();
            this.partOfSpeech = 10;
        }
        public ForeignWord(string word, string translation) : this(word, translation, String.Empty, ForeignWord.NOT_KNOW) { }
        public ForeignWord(string word, string translation, int partOfSpeech) : this(word, translation, String.Empty, partOfSpeech) { }
        public ForeignWord(string word, string translation, string transcription) : this(word, translation, transcription, ForeignWord.NOT_KNOW) { }
        public ForeignWord(string word, string translation, string transcription, int partOfSpeech)
        {
            this.id = 0; // придумать очень сложный способ вычисления нового id
            this.word = word;
            this.transcription = transcription;
            Translation translationOfCard = new Translation(translation);
            this.translations = new TranslationList(translationOfCard);
            this.partOfSpeech = partOfSpeech;
        }

        private Int64 id;
        private string word;
        private string transcription;
        private TranslationList translations;
        private int partOfSpeech;

        public Int64 Id
        {
            get { return id; }
        }
        public string Word
        {
            get { return word; }
        }
        public string Transcription
        {
            get { return transcription; }
        }
        public TranslationList Translations
        {
            get { return translations; }
        }
        public int PartOfSpeech
        {
            get { return partOfSpeech; }
        }
        public void save()
        {
            FileInfo newWordDoc = new FileInfo(@"voc\foreign_words\" + this.id + ".txt");
            StreamWriter sw = newWordDoc.CreateText();
            sw.WriteLine(this.id);
            sw.WriteLine(this.word);
            sw.WriteLine(this.transcription);
            sw.WriteLine(this.partOfSpeech);
            sw.Close();
            this.translations.save();
            
        }
        public void load(string Id)
        {
            FileInfo newWordDoc = new FileInfo(Id);
            StreamReader sw = newWordDoc.OpenText();
            this.id = Convert.ToInt16(sw.ReadLine());
            this.word = sw.ReadLine();
            this.transcription = sw.ReadLine();
            this.partOfSpeech = Convert.ToInt16(sw.ReadLine());
            sw.Close();
            this.translations.load();
        }
    }
}
