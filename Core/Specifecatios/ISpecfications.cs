using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifecatios
{
    public class Specfications<TEntity>
    {
        public Expression<Fun<TEntity,bool>> Criteria { get; set; }
        public Expression<Fun<TEntity, Object>> Include { get; set; }
    }
}
