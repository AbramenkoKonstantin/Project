using System;

namespace individual_project
{
    class GetInfo : BMI
    {
        public void GetInformation()
        {
            Console.WriteLine("Программа определения индекса массы вашего тела");
            Console.WriteLine("Выполнил Абраменко Константин");
            Console.WriteLine("Студент группы ПИ-203");
            Console.Write("Введите свой вес(например 60 или 60,5): ");
            float Weight = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите свой рост(например 170 или 172,5): ");
            float Growth = Convert.ToSingle(Console.ReadLine());
            Bmi = 10000 * Weight / (Growth * Growth);
            NormalWeightLow = 20F * (Growth * Growth) / 10000;
            NormalWeightHigh = 23F * (Growth * Growth) / 10000;
            if (Bmi < 16.0)
            {
                Console.WriteLine($"Индекс массы вашего тела равен = {Bmi} - Выраженный дефицит веса");
                Console.WriteLine("Необходима срочная консультация специалиста");
                Console.WriteLine($"Ваш идеальный вес должен составлять от {NormalWeightLow} до {NormalWeightHigh}");
            }
            else if (Bmi >= 16.0 && Bmi < 18.5)
            {
                Console.WriteLine($"Индекс массы вашего тела равен = {Bmi} - Недостаток веса");
                Console.WriteLine($"Ваш идеальный вес должен составлять от {NormalWeightLow} до {NormalWeightHigh}");
            }
            else if (Bmi >= 18.5 && Bmi < 25.0)
            {
                Console.WriteLine($"Индекс массы вашего тела равен = {Bmi} - Норма");
                Console.WriteLine($"Ваш идеальный вес должен составлять от {NormalWeightLow} до {NormalWeightHigh}");
            }
            else if (Bmi >= 25.0 && Bmi < 30.0)
            {
                Console.WriteLine($"Индекс массы вашего тела равен = {Bmi} - Избыточная масса тела");
                Console.WriteLine($"Ваш идеальный вес должен составлять от {NormalWeightLow} до {NormalWeightHigh}");
            }
            else if (Bmi >= 30.0 && Bmi < 35.0)
            {
                Console.WriteLine($"Индекс массы вашего тела равен = {Bmi} - Ожирение 1 степени");
                Console.WriteLine("Необходима консультация специалиста");
                Console.WriteLine($"Ваш идеальный вес должен составлять от {NormalWeightLow} до {NormalWeightHigh}");
            }
            else if (Bmi >= 35.0 && Bmi < 40.0)
            {
                Console.WriteLine($"Индекс массы вашего тела равен = {Bmi} - Ожирение 2 степени");
                Console.WriteLine("Необходима консультация специалиста");
                Console.WriteLine($"Ваш идеальный вес должен составлять от {NormalWeightLow} до {NormalWeightHigh}");
            }
            else if (Bmi >= 40.0)
            {
                Console.WriteLine($"Индекс массы вашего тела равен = {Bmi} - Ожирение 3 степени");
                Console.WriteLine("Необходима срочная консультация специалиста");
                Console.WriteLine($"Ваш идеальный вес должен составлять от {NormalWeightLow} до {NormalWeightHigh}");
            }
        }
    }
}