using System.Collections.Generic;
using System.Text;

using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationDatabase.Src.Utils;

namespace SensitiveInformationDatabase.Src.BuildersColumnsValues
{
    internal class BuilderColumnsValuesSensitiveInformation
    {
        private static Dictionary<string, string> columnsNames = AnnotationsColumnName<EntitySensitiveInformation>.GetColumnsNames();
        
        internal static string GetColumnsToCreate()
        {
            StringBuilder columns = new StringBuilder();
            columns.Append($"{columnsNames["type"]},");
            columns.Append($"{columnsNames["informationName"]},");
            columns.Append($"{columnsNames["containerName"]},");
            columns.Append($"{columnsNames["notes"]},");
            columns.Append($"{columnsNames["username"]},");
            columns.Append($"{columnsNames["password"]},");
            columns.Append($"{columnsNames["urlsList"]},");
            columns.Append($"{columnsNames["cardName"]},");
            columns.Append($"{columnsNames["cardEntity"]},");
            columns.Append($"{columnsNames["cardNumber"]},");
            columns.Append($"{columnsNames["cardExpirationDate"]},");
            columns.Append($"{columnsNames["cardSecurityNumber"]},");
            columns.Append($"{columnsNames["contactName"]},");
            columns.Append($"{columnsNames["contactLastname"]},");
            columns.Append($"{columnsNames["businessName"]},");
            columns.Append($"{columnsNames["emailsList"]},");
            columns.Append($"{columnsNames["phoneNumbersList"]},");
            columns.Append($"{columnsNames["addressesList"]},");
            columns.Append($"{columnsNames["postalCode"]},");
            columns.Append($"{columnsNames["country"]},");
            columns.Append($"{columnsNames["state"]},");
            columns.Append($"{columnsNames["birthday"]},");
            columns.Append($"{columnsNames["tagsList"]},");
            columns.Append($"{columnsNames["favorite"]},");
            columns.Append($"{columnsNames["contentKey"]}");

            return columns.ToString();
        }

        internal static string GetValuesToCreate(EntitySensitiveInformation sensitiveInformation)
        {
            StringBuilder values = new StringBuilder();
            values.Append($"'{ sensitiveInformation.type }',");
            values.Append($"'{ sensitiveInformation.informationName }',");
            values.Append($"'{ sensitiveInformation.containerName }',");
            values.Append($"'{ sensitiveInformation.notes }',");
            values.Append($"'{ sensitiveInformation.username }',");
            values.Append($"'{ sensitiveInformation.password }',");
            values.Append($"'{ sensitiveInformation.urlsList }',");
            values.Append($"'{ sensitiveInformation.cardName }',");
            values.Append($"'{ sensitiveInformation.cardEntity }',");
            values.Append($"'{ sensitiveInformation.cardNumber }',");
            values.Append($"'{ sensitiveInformation.cardExpirationDate }',");
            values.Append($"'{ sensitiveInformation.cardSecurityNumber }',");
            values.Append($"'{ sensitiveInformation.contactName }',");
            values.Append($"'{ sensitiveInformation.contactLastname }',");
            values.Append($"'{ sensitiveInformation.businessName }',");
            values.Append($"'{ sensitiveInformation.emailsList }',");
            values.Append($"'{ sensitiveInformation.phoneNumbersList }',");
            values.Append($"'{ sensitiveInformation.addressesList }',");
            values.Append($"'{ sensitiveInformation.postalCode }',");
            values.Append($"'{ sensitiveInformation.country }',");
            values.Append($"'{ sensitiveInformation.state }',");
            values.Append($"'{ sensitiveInformation.birthday }',");
            values.Append($"'{ sensitiveInformation.tagsList }',");
            values.Append($"'{ sensitiveInformation.favorite }',");
            values.Append($"'{ sensitiveInformation.contentKey }'");

            return values.ToString();
        }

        internal static string GetValuesAndColumnsToUpdate(EntitySensitiveInformation sensitiveInformation)
        {
            StringBuilder columnsAndValues = new StringBuilder();
            columnsAndValues.Append($"{columnsNames["type"]}='{sensitiveInformation.type}',");
            columnsAndValues.Append($"{columnsNames["informationName"]}='{sensitiveInformation.informationName}',");
            columnsAndValues.Append($"{columnsNames["containerName"]}='{sensitiveInformation.containerName}',");
            columnsAndValues.Append($"{columnsNames["notes"]}='{sensitiveInformation.notes}',");
            columnsAndValues.Append($"{columnsNames["username"]}='{sensitiveInformation.username}',");
            columnsAndValues.Append($"{columnsNames["password"]}='{sensitiveInformation.password}',");
            columnsAndValues.Append($"{columnsNames["urlsList"]}='{sensitiveInformation.urlsList}',");
            columnsAndValues.Append($"{columnsNames["cardName"]}='{sensitiveInformation.cardName}',");
            columnsAndValues.Append($"{columnsNames["cardEntity"]}='{sensitiveInformation.cardEntity}',");
            columnsAndValues.Append($"{columnsNames["cardNumber"]}='{sensitiveInformation.cardNumber}',");
            columnsAndValues.Append($"{columnsNames["cardExpirationDate"]}='{sensitiveInformation.cardExpirationDate}',");
            columnsAndValues.Append($"{columnsNames["cardSecurityNumber"]}='{sensitiveInformation.cardSecurityNumber}',");
            columnsAndValues.Append($"{columnsNames["contactName"]}='{sensitiveInformation.contactName}',");
            columnsAndValues.Append($"{columnsNames["contactLastname"]}='{sensitiveInformation.contactLastname}',");
            columnsAndValues.Append($"{columnsNames["businessName"]}='{sensitiveInformation.businessName}',");
            columnsAndValues.Append($"{columnsNames["emailsList"]}='{sensitiveInformation.emailsList}',");
            columnsAndValues.Append($"{columnsNames["phoneNumbersList"]}='{sensitiveInformation.phoneNumbersList}',");
            columnsAndValues.Append($"{columnsNames["addressesList"]}='{sensitiveInformation.addressesList}',");
            columnsAndValues.Append($"{columnsNames["postalCode"]}='{sensitiveInformation.postalCode}',");
            columnsAndValues.Append($"{columnsNames["country"]}='{sensitiveInformation.country}',");
            columnsAndValues.Append($"{columnsNames["state"]}='{sensitiveInformation.state}',");
            columnsAndValues.Append($"{columnsNames["birthday"]}='{sensitiveInformation.birthday}',");
            columnsAndValues.Append($"{columnsNames["tagsList"]}='{sensitiveInformation.tagsList}',");
            columnsAndValues.Append($"{columnsNames["favorite"]}='{sensitiveInformation.favorite}',");
            columnsAndValues.Append($"{columnsNames["contentKey"]}='{sensitiveInformation.contentKey}'");

            return columnsAndValues.ToString();
        }
    }
}
