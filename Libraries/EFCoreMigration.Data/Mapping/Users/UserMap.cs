﻿using EFCoreMigration.Core.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreMigration.Data.Mapping.Users
{
    /// <summary>
    /// 代表User的Mapping配置
    /// </summary>
    public partial class UserMap : EfCoreMigrationEntityTypeConfiguration<User>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.HasKey(user => user.Id);

            builder.Property(user => user.UserName).HasMaxLength(1000);
            builder.Property(user => user.Email).HasMaxLength(1000);
            builder.Property(user => user.Description).HasMaxLength(1000);

            base.Configure(builder);
        }

        #endregion

    }
}
