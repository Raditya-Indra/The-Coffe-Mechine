﻿using System;

namespace The_Coffe_Mechine
{
    class CoffePowder
    {
        private int netto = 0;
        private int oneCupCoffe = 25;

        public CoffePowder(int netto)
        {
            this.netto = netto;
        }
        public Boolean isAvailable()
        {
            return this.netto >= this.oneCupCoffe;
        }
        public void makeOneCup()
        {
            this.netto = this.netto - oneCupCoffe;
        }
        public int getNetto()
        {
            return this.netto;
        }
    }
}
