using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.History
{
    public class RansomNote
    {
        public void checkMagazine(string[] magazine, string[] note)
        {
            magazine = magazine.OrderBy(o => o).ToArray();
            note = note.OrderBy(o => o).ToArray();

            int endNote = note.Length;
            int endMagazine = magazine.Length;

            int n = 0;
            int m = 0;
            int pointer = 0;

            int result = 0;
            string response = "";

            while (n < endNote)
            {
                m = pointer;
                result = 0;

                while (m < endMagazine)
                {
                    if (magazine[m] == note[n])
                    {
                        result = 1;
                        pointer = m + 1;
                        m = endMagazine;
                    }
                    else
                    {
                        m++;
                    }
                }

                if (result == 0)
                {
                    n = endNote;
                }

                n++;
            }

            if (result == 1)
            {
                response = "Yes";
            }
            else
            {
                response = "No";
            }

            Console.WriteLine(response);
        }

        public void executeRansomNote()
        {
            RansomNote ransomNote = new RansomNote();

            string[] magazine = { "give", "me", "one", "grand", "today", "night" };
            string[] note = { "give", "one", "grand", "today" };

            ransomNote.checkMagazine(magazine, note);
        }
    }
}
