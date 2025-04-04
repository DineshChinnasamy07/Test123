using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridTask
{
    public  class LedgerEntry
    {
        private static int nextId = 1;


        public int Id { get; private set; }

        public string Code { get; private set; }

        public string Name { get; private set; }

        public DateTime Date { get; private set; }

        public string Nature { get; private set; }

        public LedgerEntry(string code, string name, DateTime date, string nature)
        {
            Id = nextId++;  // Increment the ID for each new entry
            Code = code;
            Name = name;
            Date = date;
            Nature = nature;
        }

    }
}
