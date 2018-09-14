using System;
using System.Collections.Generic;

namespace msapp
{
    public class User
    {
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string JobTitle {get; set;}

        public List<Obligation> Obligations {get; set;}
    }
}