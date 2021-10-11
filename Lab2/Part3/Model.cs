using System;

namespace Models
{
    public class Model
    {
        private string info;
        private int data1;
        private int data2;

        public Model()
        {

        }

        public Model(string info, int data1, int data2)
        {
            this.info = info;
            this.data1 = data1;
            this.data2 = data2;
        }

        public string getInfo() {
            return info;
        }

        public int getDataDifference()
        {
            if(data1 < data2)
            {
                return data2 - data1;
            } else
            {
                return data1 - data2;
            }
        }
    }
}