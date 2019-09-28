using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MegaSoft1.Models.Enums
{
    //это Enum списки "ПОЛ"- персонала 
    public enum Gender
    {
        //Мужской 
        [Display(Name = "Мужской")]
        Male = 1,
        //Женский
        [Display(Name = "Женский")]
        Female,
        //Другие
        [Display(Name = "Другое")]
        Other, 
    }
}