using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OAuth_SSFR_API.Models.ManageViewModels
{
    public class GenerateRecoveryCodesViewModel
    {
        public string[] RecoveryCodes { get; set; }
    }
}
