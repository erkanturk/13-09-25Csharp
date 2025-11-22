using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_OOP_Interface_Abstract
{
    internal class Aslan : Canli,IEtcil
    {
        public string Renk {  get; set; }
        public override string Ad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Tur { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Kilo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Boy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SaldırganMi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
