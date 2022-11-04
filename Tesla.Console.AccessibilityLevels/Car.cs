using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.Console.AccessibilityLevels
{
    abstract class Bai
    {
        protected Bai()
        {

        }
    }

    public class Car
    {
        public Car()
        { 
            
        }

        public int Model { get; set; }

        int Price { get; set; }

        private int PriceInfo { get; set; }

        internal int Buyer { get; set; }

        protected int Mo { get; set; }

        class ModelHeight
        {

        }

        protected class ModelInfo
        {

        }

        private class ModelSize
        {

        }

        internal class ModelWidth
        {

        }

        protected internal class PriceWidth
        {

        }

        protected private class PriceSize
        {

        }
    }

    internal class House
    {
        public int Model { get; set; }
    }

    internal interface IHouse
    {
        public int MyProperty { get; set; }
    }

    internal abstract class HouseHub
    {
        public int MyProperty { get; set; } = 0;
    }
}
