﻿namespace Problem6_RawData
{
    public class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public Engine(int engineSpeed, int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }

        public int Power
        {
            get { return this.enginePower; }
            private set { }
        }
    }
}
