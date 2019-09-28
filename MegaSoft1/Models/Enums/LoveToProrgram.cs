using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MegaSoft1.Models.Enums
{

    //Люибте вы программировать 1-да 2-нет ()
    public enum LoveToProrgram
    {
        //Да
        [Display(Name = "Да")]
        Yes = 1,
        //Нет
        [Display(Name = "Нет")]
        No,
    }
}