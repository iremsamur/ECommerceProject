﻿using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
            //_unitOfWorkDal.Save();

        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
            //_unitOfWorkDal.Save();

        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
            //_unitOfWorkDal.Save();
        }

        //şartlı listeleme
        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            
            return _context.Set<T>().Where(filter).ToList();
        }
    }
}
