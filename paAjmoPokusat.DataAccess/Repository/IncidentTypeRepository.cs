﻿using paAjmoPokusat.DataAccess.Data;
using paAjmoPokusat.DataAccess.Repository.IRepository;
using paAjmoPokusat.Models;

namespace paAjmoPokusat.DataAccess.Repository
{
    public class IncidentTypeRepository : Repository<IncidentType>, IIncidentTypeRepository
    {
        private ApplicationDbContext _db;
        public IncidentTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(IncidentType obj)
        {
            _db.IncidentTypes.Update(obj);
        }
    }
}
