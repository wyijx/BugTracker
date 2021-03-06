﻿using BugFixer.Domain;
using BugFixer.Services.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BugFixer.Infrastructure {
    public class BugRepository : GenericRepository<Bug> {

        public BugRepository(DbContext db) : base(db) { }

        public IQueryable<Bug>ListBugs(){
            return List();
        }
    }
}