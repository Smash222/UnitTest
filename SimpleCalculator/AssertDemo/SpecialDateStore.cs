using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertDemo
{
    public class SpecialDateStore
    {
        public DateTime DateOf(SpecialDates specialDate)
        {
            switch (specialDate)
            {
                case SpecialDate.NewMillenium:
                    return new DateTime(2000,1,1,0,0,0,0)
            }
        }
    }
}
