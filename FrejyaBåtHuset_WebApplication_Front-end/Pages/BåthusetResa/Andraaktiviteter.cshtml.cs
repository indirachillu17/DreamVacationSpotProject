﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrejyaBåtHuset_WebAPI_Backend.Models;
using FrejyaBåtHuset_WebApplication_Front_end.HelperClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FrejyaBåtHuset_WebApplication_Front_end.Pages.BåthusetResa
{
    public class AndraaktiviteterModel : PageModel
    {
        private ApiHelper apiHelper = new ApiHelper();

        [BindProperty]
        public BåtHusetBokning båtHusetBokning { get; set; }
        [BindProperty]
        public IList<Andraaktiviteter> listofactivitities { get; set; }

        public async Task OnGet()
        {
            listofactivitities = new List<Andraaktiviteter>();

            listofactivitities = await apiHelper.GetCallApiAsync<IList<Andraaktiviteter>>(GlobalValue.ApiPath + "/Andraaktiviteter");
        }
    }
}