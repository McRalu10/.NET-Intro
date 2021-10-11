using System;
using System.Collections.Generic;
using Models;

namespace Utils
{
    public static class Utilities
    {

        public static Model getSmallestDifference(List<Model> data)
        {
            int minimum = int.MaxValue;
            Model result = new Model();
            foreach (Model item in data)
            {
                int difference = item.getDataDifference();
                if (difference < minimum)
                {
                    minimum = difference;
                    result = item;
                }
            }
            return result;
        }
    }
}