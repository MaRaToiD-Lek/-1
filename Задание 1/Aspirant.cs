using System;

namespace Задание_1
{
    class Aspirant : Person
    {
        string thesis;       
        public Aspirant(string name, string surname, byte course, byte bookNumber, string _thesis)
            : base(name, surname, course, bookNumber)
        {
            this.thesis = _thesis;
            Display();
        }

        public override void Display()
        {
            Console.WriteLine($"\tАСПИРАНТ! \nИмя: {name} \nФамилия: {surname} \nКурс: {Course} \nНомер.книжки: {bookNumber} \nДиссертация: {thesis}");
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
