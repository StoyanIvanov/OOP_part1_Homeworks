﻿using System;
using System.ComponentModel;

namespace Problem1_ClassBox
{
    public class Box
    {
        private double width;
        private double height;
        private double lenght;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double Lenght
        {
            get { return this.lenght; }
            private set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Length cannot be zero or negative.");
                }
                this.lenght = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Width cannot be zero or negative.");
                }
                this.width = value; 
            }
        }


        public double SurfaceArea()
        {
            double area = (width * height) * 2 + (lenght * height) * 2 + (width * lenght) * 2;
            return area;
        }

        public double LateralArea()
        {
            double area = (width * height) * 2 + (lenght * height) * 2;
            return area;
        }

        public double Volume()
        {
            double volume = width * lenght * height;
            return volume;
        }
    }
}
