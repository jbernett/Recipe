using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecipeDomain.Models.ModelInterfaces
{
    interface IHaveGuid
    {
        public Guid Guid { get; set; }
    }
}
