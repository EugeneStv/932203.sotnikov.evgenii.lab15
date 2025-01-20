using System;

namespace WebApplication4.Models
{
    public class Doctors
    {
        public int Id { get; set; } // Первичный ключ
        public string Name { get; set; } // Имя врача
        public string Surname { get; set; } // Имя врача
        public string Specialty { get; set; } // Специализация
        public string Phones { get; set; } // Адрес больницы

    }
}
