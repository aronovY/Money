using System;
using System.Runtime.Serialization;

namespace Money.Money
{
    [Serializable]
    public class Bankruptcy : ApplicationException
    {
        public Bankruptcy() { }
        public Bankruptcy(string message) : base(message) {  }
        public Bankruptcy(string message, Exception inner) : base(message, inner) { }

        protected Bankruptcy(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

