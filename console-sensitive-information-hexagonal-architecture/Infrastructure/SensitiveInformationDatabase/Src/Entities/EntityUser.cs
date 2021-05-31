using System.ComponentModel.DataAnnotations.Schema;

namespace SensitiveInformationDatabase.Src.Entities
{
    [Table("users")]
    public class EntityUser
    {
        [Column("id")]
        public int id;

        [Column("uuid")]
        public string uuid;

        [Column("username")]
        public string username;

        [Column("password")]
        public string password;
    }
}
