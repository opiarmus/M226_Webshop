﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoeppli.Model
{
    public abstract class Person
    {
        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public string Adresse { get; set; }
        public string PLZ { get; set; }

        public Person(int id, string vorname, string nachname, DateTime geburtsdatum, string adresse, string plz)
        {
            ID = id;
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = geburtsdatum;
            Adresse = adresse;
            PLZ = plz;
        }

    }
}
