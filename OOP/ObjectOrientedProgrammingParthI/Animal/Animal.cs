using System;


namespace Animal
{
    public class Animal : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Sound { get; set; }

        //This empty constructor allows different constructors to be adde in child classes
        public Animal()
            {}

        //For average age calculation other parameters except age are not needed
        public Animal(int age)
        {
            this.Age = age;
        }
        
        public Animal(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public static void Average(Animal[] array)
        {
            decimal sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i].Age;
            }
            
            sum = sum / array.Length;
            Console.WriteLine("The average age of {0} is {1} years.", array.GetType(), sum);
        }

        public override string ToString()
        {
            Console.WriteLine("The {0} is {1}, {2} years old, {3} and emmit sound: {4}", this.Name, this.GetType(), this.Age, this.Sex, this.Sound);
            return base.ToString();
        }
    }
    
}
