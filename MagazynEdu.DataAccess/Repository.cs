﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagazynEdu.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using MagazynEdu.DataAccess;

namespace MagazynEdu.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MagazynEdu.DataAccess.Entities;
    using Microsoft.EntityFrameworkCore;

    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        protected readonly WarehouseStorageContext context;
        private DbSet<T> entities;

        public Repository(WarehouseStorageContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(int id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            T entity = entities.SingleOrDefault(s => s.Id == id);
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}