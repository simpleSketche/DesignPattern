using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace SingleResponsibilityPrinciple
{
    class Actions
    {
        public string selectEntry(Journal j, int idx, bool overwrie = false)
        {
            string result = "nothing is selected";
            if(idx < j.entries.Count)
            {
                result = j.entries[idx];
            }
            return result;

        }
    }
}
