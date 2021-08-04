using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sp2019B5.BLL
{
    class Corporation
    {
        int corpno;
        string corpName;
        string street;
        int regionNo;

        public Corporation()
        {
        }

        public Corporation(int corpno, string corpName, string street, int regionNo)
        {
            this.Corpno = corpno;
            this.CorpName = corpName;
            this.Street = street;
            this.RegionNo = regionNo;
        }

        public int Corpno { get => corpno; set => corpno = value; }
        public string CorpName { get => corpName; set => corpName = value; }
        public string Street { get => street; set => street = value; }
        public int RegionNo { get => regionNo; set => regionNo = value; }
    }
}
