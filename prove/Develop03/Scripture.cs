using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyScripture
{
    class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void Display()
        {
            Console.WriteLine($"{_reference}:");
            foreach (Word word in _words)
            {
                Console.Write(word.IsHidden() ? new string('_', word.GetText().Length) + " " : word.GetText() + " ");
            }
            Console.WriteLine();
        }

        public bool HideRandomWords(int count)
        {
            List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
            if (visibleWords.Count < count)
                return false;

            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
            return true;
        }
    }
}
