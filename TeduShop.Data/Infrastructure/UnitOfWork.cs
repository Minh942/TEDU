﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private TeduShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
           this._dbFactory = dbFactory;
        }

        public TeduShopDbContext DbContext { get { return dbContext ?? (dbContext = _dbFactory.Init()); } }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
