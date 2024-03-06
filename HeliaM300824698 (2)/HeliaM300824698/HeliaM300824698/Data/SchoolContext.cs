﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HeliaM_300824698.Models;


namespace HeliaM_300824698.Data
{
    public class SchoolContext : DbContext
    {

            public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
            {
            }

            public DbSet<Course> Courses { get; set; }
            public DbSet<Faculty> Faculties { get; set; }
            public DbSet<AssignFaculty> AssignFaculties { get; set; }
        }




    }
