using System.Collections.Generic;

namespace SensitiveInformationConsole.Src.Validators
{
    internal class ValidatorIsNull
    {
        private ValidatorIsNull()
        {
        }

        internal static void Validate(object ob)
        {
            if (ob == null)
            {
                throw new KeyNotFoundException("Not found key");
            }
        }
    }
}
