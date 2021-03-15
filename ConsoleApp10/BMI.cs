using System;

namespace individual_project
{
    class BMI : Data
    {
        private float bmi;
        private float normalWeightLow;
        private float normalWeightHigh;

        public BMI()
        {

        }

        public float Bmi
        {
            get
            {
                return bmi;
            }
            set
            {
                bmi = value;
            }
        }

        public float NormalWeightLow
        {
            get
            {
                return normalWeightLow;
            }
            set
            {
                normalWeightLow = value;
            }
        }

        public float NormalWeightHigh
        {
            get
            {
                return normalWeightHigh;
            }
            set
            {
                normalWeightHigh = value;
            }
        }

    }
}