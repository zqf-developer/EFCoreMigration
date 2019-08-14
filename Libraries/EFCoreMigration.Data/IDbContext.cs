using EFCoreMigration.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreMigration.Data
{
    /// <summary>
    /// 表示数据库上下文
    /// </summary>
    public partial interface IDbContext
    {
        #region Methods

        /// <summary>
        /// 创建可用于查询和保存实体实例的DbSet
        /// </summary>
        /// <typeparam name="TEntity">实体类型</typeparam>
        /// <returns>给定实体类型的集合</returns>
        DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

        /// <summary>
        /// 将在此上下文中所做的所有更改保存到数据库中
        /// </summary>
        /// <returns>写入数据库的状态条目数</returns>
        int SaveChanges();
        #endregion
    }
}
