﻿using System.Collections.Generic;
using System.Linq;
using Wrc.Domain.Models;

namespace Wrc.Domain.Dal.Repositories
{
    public class GenericDictionaryItemRepository<TEntity>
        : GenericRepository<TEntity>, IGenericDictionaryItemRepository<TEntity> where TEntity : GenericDictionaryItem
    {
        public GenericDictionaryItemRepository(ICrudRepository<TEntity> crud) : base(crud)
        {
        }

        public TEntity GetByPublicCode(string publicCode)
        {
            return _crud.Get().SingleOrDefault(x => x.DateEnd == null && x.PublicCode == publicCode);
        }

        public IList<TEntity> GetActual()
        {
            return _crud.Get().Where(x => x.DateEnd == null).ToList();
        }
    }
}