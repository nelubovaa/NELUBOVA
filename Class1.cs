using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Нелюбова_34
{
    public class Driver//Выполнила Нелюбова
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public List<Auto> Autos = new List<Auto>();
        public Driver(string nm, string cl)
        {
            Name = nm;
            Class = cl;
        }
        public void ShowAll()
        {
            Console.WriteLine($"Водитель: ФИО = {Name}, квалификация = {Class}");
        }
    }
    public class Auto//Выполнила Нелюбова
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public Auto(string tit, string nu)
        {
            Title = tit;
            Number = nu;
        }
        public void Show()
        {

            Console.WriteLine( $"(Автомобиль: название = {Title}, гос-номер = {Number}");//Выполнила Нелюбова

        }
    }
}