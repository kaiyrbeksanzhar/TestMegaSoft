using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MegaSoft1.Models.Enums
{
    //Семейное положение персонала 
    public enum MartialStatus
    {
        //Женат замужем
        [Display(Name = "Женат/Замужем")]
        Married = 1,
        //Холост Незамужем
        [Display(Name = "Холост/Незамужем")]
        NotMarried,
    }
}