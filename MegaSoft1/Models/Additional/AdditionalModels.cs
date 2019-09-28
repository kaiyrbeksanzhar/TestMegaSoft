using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MegaSoft1.Models.Enums;

namespace MegaSoft1.Models.Additional
{
    //Добавить персонала 
    public class PersonalDateCreateMdl
    {
        //Имя персонала
        [Required]
        public string Name { get; set; }
        //Возраст персонала
        [Required]
        public int Age { get; set; }
        //Пол персонала
        [Required]
        public Gender Gender { get; set; }
        //День рождения персонала
        [Required]
        public DateTime Birthday { get; set; }
        //Семейное положения персонала
        [Required]
        public MartialStatus MaritalStatus { get; set; }
        //Любите вы программировать
        [Required]
        public LoveToProrgram LoveToProgram { get; set; }
    }

    //Модель персонала лист 
    public class PersonalViewListMdl
    {
        //Id персонала
        public int Id { get; set; }
        //Имя персонала
        public string Name { get; set; }
        //День рожденияперсонала
        public DateTime Birthday { get; set; }
    }

    public class PersonalDetailsViewMdl
    {
        //Id персонала
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