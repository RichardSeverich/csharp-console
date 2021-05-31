using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationDatabase.Src.Utils;

namespace SensitiveInformationDatabase.Src.MappingTables
{
    internal class EntityMappingSensitiveInformation : IEntityMapping<EntitySensitiveInformation>
    {
        public List<EntitySensitiveInformation> Map(SqlDataReader reader)
        {
            List<EntitySensitiveInformation> sensitiveInformationList = new List<EntitySensitiveInformation>();

            while (reader.Read())
            {
                EntitySensitiveInformation sensitiveInformation = new EntitySensitiveInformation();
                Dictionary<string, string> columns = AnnotationsColumnName<EntitySensitiveInformation>.GetColumnsNames();
                sensitiveInformation.id = reader.GetInt32(columns["id"]);
                sensitiveInformation.uuid = reader.GetGuid(columns["uuid"]);
                sensitiveInformation.type = reader.GetString(columns["type"]);
                sensitiveInformation.informationName = reader.GetString(columns["informationName"]);
                sensitiveInformation.containerName = reader.GetString(columns["containerName"]);
                sensitiveInformation.notes = reader.GetString(columns["notes"]);
                sensitiveInformation.username = reader.GetString(columns["username"]);
                sensitiveInformation.password = reader.GetString(columns["password"]);
                sensitiveInformation.urlsList = reader.GetString(columns["urlsList"]);
                sensitiveInformation.cardName = reader.GetString(columns["cardName"]);
                sensitiveInformation.cardEntity = reader.GetString(columns["cardEntity"]);
                sensitiveInformation.cardNumber = reader.GetString(columns["cardNumber"]);
                sensitiveInformation.cardExpirationDate = reader.GetDateTime(columns["cardExpirationDate"]);
                sensitiveInformation.cardSecurityNumber = reader.GetInt32(columns["cardSecurityNumber"]);
                sensitiveInformation.contactName = reader.GetString(columns["contactName"]);
                sensitiveInformation.contactLastname = reader.GetString(columns["contactLastname"]);
                sensitiveInformation.businessName = reader.GetString(columns["businessName"]);
                sensitiveInformation.emailsList = reader.GetString(columns["emailsList"]);
                sensitiveInformation.phoneNumbersList = reader.GetString(columns["phoneNumbersList"]);
                sensitiveInformation.addressesList = reader.GetString(columns["addressesList"]);
                sensitiveInformation.postalCode = reader.GetInt32(columns["postalCode"]);
                sensitiveInformation.country = reader.GetString(columns["country"]);
                sensitiveInformation.state = reader.GetString(columns["state"]);
                sensitiveInformation.birthday = reader.GetDateTime(columns["birthday"]);
                sensitiveInformation.tagsList = reader.GetString(columns["tagsList"]);
                sensitiveInformation.favorite = reader.GetBoolean(columns["favorite"]);
                sensitiveInformation.contentKey = reader.GetString(columns["contentKey"]);
                sensitiveInformationList.Add(sensitiveInformation);
            }

            return sensitiveInformationList;
        }
    }
}
