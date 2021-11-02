using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class Journal
    {
        public readonly List<string> entries = new List<string>();
        private static int count = 0;
        public int AddEntry(string text)
        {
            this.entries.Add($"{++count}: {text}");
            return count;
        }
        public void RemoveEntry(int index)
        {
            this.entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.entries);
        }
    }
}
