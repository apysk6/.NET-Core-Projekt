using GuitarProjectWebsite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GuitarProjectWebsite.Validation
{
    public class WebsiteExistsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            bool isError = false;
            Producer producer = (Producer)validationContext.ObjectInstance;

            WebRequest webRequest = WebRequest.Create(producer.Website);
            WebResponse webResponse;
            try
            {
                webResponse = webRequest.GetResponse();
            }
            catch 
            {
                isError = true;
            }

            if (isError)
                return new ValidationResult(GetErrorMessage());

            return ValidationResult.Success;
        }

        private string GetErrorMessage()
        {
            return $"This website doesn't exists.";
        }
    }
}
