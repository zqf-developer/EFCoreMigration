using System;

namespace EFCoreMigration.Core.Domain.Users
{
    public partial class User : BaseEntity
    {

        public User()
        {
            this.UserGuid = Guid.NewGuid();
        }

        /// <summary>
        /// Gets or sets the User GUID
        /// </summary>
        public Guid UserGuid { get; set; }

        /// <summary>
        ///  Gets or sets the UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Age
        /// </summary>
        public int Age { get; set; }

    }
}
