using LibraryMVC.DataAcces.Abstracts;
using LibraryMVC.Domain.Entities;
using LibraryMVC.Repository.Infrastructure.EntityFrameWorkAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.DataAcces.Concretes.EfEntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, LibraryDbContext>, ICourseDal
    {
    }
}
