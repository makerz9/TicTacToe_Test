using System;
using System.Collections.Generic;
using System.Text;

namespace CH20_Q03
{
    internal class Booklet : PageDocument
    {
        public int Copies { get; }

        public int Sheet => ((Pages + 1) / 2) * Copies;

        public Booklet(int pages) : this(pages, 1)
        {
            Copies = 1;
        }
        public Booklet(int pages, int copies) : base(pages)
        {
            Copies = Math.Clamp(copies, 1, 5);
        }
    }
}
