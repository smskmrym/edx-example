using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace proje.Models.ViewModels
{
    public class AgeViewModel : Controller
    {
        public int age { get; set; }
        public AgeViewModel()
        {
            age = new Random().Next(0,90);
            
        }
    }
}
