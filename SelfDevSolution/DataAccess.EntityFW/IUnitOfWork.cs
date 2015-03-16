using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFW
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Returns a IQueriable of all data objects of the specified type.
        /// </summary>
        IQueryable<T> Get<T>()
            where T : class;

        /// <summary>
        /// Marks object as added in the unit of work.
        /// </summary>
        void Add<T>(T entity)
            where T : class;

        /// <summary>
        /// Marks object as removed in the unit of work.
        /// </summary>
        void Remove<T>(T entity)
            where T : class;

        /// <summary>
        /// Commits current changes.
        /// </summary>
        void Commit();
    }
}
