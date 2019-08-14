using System.Collections.Generic;
using System.Linq;

namespace EFCoreMigration.Core.Data
{
    /// <summary>
    /// 表示实体存储库接口
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    public partial interface IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Methods

        /// <summary>
        /// 根据标识符id获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(object id);

        /// <summary>
        /// 插入实体
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// 插入多个实体
        /// </summary>
        /// <param name="entities"></param>
        void Insert(IEnumerable<TEntity> entities);

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// 更新多个实体
        /// </summary>
        /// <param name="entities"></param>
        void Update(IEnumerable<TEntity> entities);

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity"></param>
        void Delete(TEntity entity);

        /// <summary>
        /// 删除多个实体
        /// </summary>
        /// <param name="entities"></param>
        void Delete(IEnumerable<TEntity> entities);


        #endregion

        #region Properties

        /// <summary>
        /// 获取一个表结构
        /// </summary>
        IQueryable<TEntity> Table { get; }

        /// <summary>
        /// 获取启用了"无跟踪"(EF 功能)的表 仅当您加载记录时才用于只读操作
        /// 有时我们的实体只需要显示，无需更新，所以为了提高性能，我们不需要实体被EF context追踪。
        /// 此时可以使用NoTracking的查询来得到实体，这样实体的状态会是Detached状态。
        /// </summary>
        IQueryable<TEntity> TableNoTracking { get; }

        #endregion
    }
}
