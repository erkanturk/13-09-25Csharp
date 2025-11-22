using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_OOP_Interface_Abstract
{
    internal class Insan : Canli, IEtcil, IOtcul
    {
        public string Tc {  get; set; }
        public bool VahsiMi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SaldırganMi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Ad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Tur { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Kilo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Boy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
