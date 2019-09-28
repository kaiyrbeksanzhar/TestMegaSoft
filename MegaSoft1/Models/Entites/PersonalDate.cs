using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MegaSoft1.Models.Enums;

namespace MegaSoft1.Models.Entites
{
    public class PersonalDate
    {
        //Id таблицы
        public int Id { get; set; }
        //Имя персонала
        public string Name { get; set; }
        //Возраст персонала
        public int Age { get; set; }
        //Пол персонала
        public Gender Gender { get; set; }
        //День рождения персонала
        public DateTime Birthday { get; set; }
        //Семейное положения персонала
        public MartialStatus MaritalStatus { get; set; }
        //Любите вы программировать
        public LoveToProrgram LoveToProgram { get; set; }
    }
}