﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Antd.Demo.Presenters.Validations
{
    public class ModelDataValidation
    {
        public void Validate(object model)
        {
            string errorMessage = string.Empty;
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if (!isValid)
            {
                results.ForEach(itm => errorMessage += "- " + itm.ErrorMessage + "\n");
                throw new Exception(errorMessage);
            }
        }
    }
}
