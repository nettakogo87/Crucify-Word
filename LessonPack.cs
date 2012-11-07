using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс учебной колоды который наследует от обычной колоды, будет хранить еще и номера следующих уроков
 */
namespace Crucify_Word
{
    public class LessonPack: Pack
    {
        public LessonPack(int packNumber, int l1, int l2, int l3)
            : base(packNumber)
        {
            this.lesson1 = l1;
            this.lesson2 = l2;
            this.lesson3 = l3;
        }

        private int lesson1;
        private int lesson2;
        private int lesson3;
        public int Lesson1
        {
            get { return this.lesson1; }
        }
        public int Lesson2
        {
            get { return this.lesson2; }
        }
        public int Lesson3
        {
            get { return this.lesson3; }
        }
    }
}
