using System;

using SensitiveInformationConsole.Src.Exceptions;
using SensitiveInformationCore.Src.Main.Models;

namespace SensitiveInformationConsole.Src.Validators
{
    internal class ValidatorEnumSIType
    {
        private ValidatorEnumSIType()
        {
        }

        internal static void Valid(string enumValue)
        {
            if (!Enum.IsDefined(typeof(EnumSIType), enumValue))  
            {
                string message = "Bad information type, Information type should be: "
                    + "note, credential, key, creditcard, contact";
                throw new InvalidCommandException(message);
            }            
        }
    }
}
