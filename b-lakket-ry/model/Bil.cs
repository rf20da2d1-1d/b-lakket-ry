﻿using System;
using System.Collections.Generic;
using System.Text;

namespace b_lakket_ry.model
{
    public class Bil
    {
        private static int nextId = 0;

        private int _id;
        private string _farve;
        private string _registreringsNr;
        private double _pris;


        public Bil():this("dummy", "dummy", 0)
        {
        }

        public Bil(string farve, string registreringsNr, double pris)
        {
            _id = ++nextId;
            _farve = farve;
            _registreringsNr = registreringsNr;
            _pris = pris;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Farve
        {
            get => _farve;
            set => _farve = value;
        }

        public string RegistreringsNr
        {
            get => _registreringsNr;
            set => _registreringsNr = value;
        }

        public double Pris
        {
            get => _pris;
            set => _pris = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Farve)}: {Farve}, {nameof(RegistreringsNr)}: {RegistreringsNr}, {nameof(Pris)}: {Pris}";
        }

        /*
         * TIL HASH SET - benytter kun ID
         */
        protected bool Equals(Bil other)
        {
            return _id == other._id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Bil) obj);
        }

        public override int GetHashCode()
        {
            return _id;
        }
    }
}
