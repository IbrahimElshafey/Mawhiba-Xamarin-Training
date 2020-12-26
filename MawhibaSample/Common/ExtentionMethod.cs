using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.Results;

namespace MawhibaSample.Common
{
    public static class ExtensionMethod
    {
        public static string GetErrors(this ValidationResult validationResult)
        {
            if (validationResult != null && !validationResult.IsValid)
            {
                var sb = new StringBuilder();
                sb.AppendLine();
                foreach (var validationResultError in validationResult.Errors)
                {
                    sb.Append("* ");
                    sb.Append(validationResultError.ErrorMessage);
                    sb.AppendLine();
                }

                return sb.ToString();
            }

            return null;
        }
    }
}
