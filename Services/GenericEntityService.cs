using System;
using System.Collections.Generic;
using System.Linq;
using breath_app_core.Model.BaseEntities;
using breath_app_core.Services;
using BreathApp.Models;
using Microsoft.EntityFrameworkCore;

public class GenericEntityService<TEntity> : IGenericEntityService<TEntity> where TEntity : ServiceEntity {
    private readonly BreathContext _context;
    public readonly DbSet<TEntity> _dbSet;

    public GenericEntityService(BreathContext context) {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public TEntity? GetById(int id) {
        return _dbSet.Find(id);
    }

    public List<TEntity> GetAll() {
        return _dbSet.ToList();
    }

    public void Add(TEntity entity) {
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void Update(TEntity entity) {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id) {
        var entity = _dbSet.Find(id);
        if (entity != null) {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}