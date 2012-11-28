using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/**
 * Класс представляетс собой Русское слово - перевод Английского. 
 * В последующем предполагается что будет хранить идентификатор популярности данного перевода.
 */
namespace Crucify_Word
{
    public class Translation
    {
        public Translation(string word)
        {
            this.word = word;
            this.save();
        }
        private string word;
        public string Word
        {
            get { return word; }
            set { word = value; this.save(); }
        }
        public void save()
        {
            FileInfo newWord = new FileInfo(@"voc\translations\"+this.word);
            StreamWriter sw = newWord.CreateText();
            sw.WriteLine(this.word);
            sw.Close();
        }
        public void load()
        {
            FileInfo newWord = new FileInfo(this.word);
            StreamReader sw = newWord.OpenText();
            this.word = sw.ReadLine();
            sw.Close();
        }
    }
}
