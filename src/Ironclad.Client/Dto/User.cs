﻿// Copyright (c) Lykke Corp.
// See the LICENSE file in the project root for more information.

namespace Ironclad.Client
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the subject identifier for this user.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the username for this user.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password for this user.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the email address for this user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether to send a confirmation email to the new user.
        /// </summary>
        public bool? SendConfirmationEmail { get; set; }

        /// <summary>
        /// Gets or sets a telephone number for the user.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the external login provider for the user.
        /// </summary>
        public string ExternalLoginProvider { get; set; }

        /// <summary>
        /// Gets or sets the registration link for this user.
        /// </summary>
        public string RegistrationLink { get; set; }

        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        /// <value>The roles.</value>
#pragma warning disable CA2227
        public ICollection<string> Roles { get; set; }
#if CLIENT
            = new HashSet<string>();
#endif
    }
}