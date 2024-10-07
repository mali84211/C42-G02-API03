using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifecatios
{
    public class BaseSpecfications<TEntity,Tkey> : ISpecifcations<TEntity,TKey> where TEntity : BaseEntity<Tkey>
    {
        public Expression<Fun<TEntity, bool>> Criteria { get; set; }
        public Expression<Fun<TEntity, Object>> Include { get; set; }
        public BaseSpecfications(Expression<Fun<TEntity, bool> Expression)
        {
            Criteria = Expression;
            Include = new List<Expression<Fun<TEntity, bool>>();
        }
    }
}
