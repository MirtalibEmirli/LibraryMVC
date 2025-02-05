using LibraryMVC.Domain.Entities;
using LibraryMVC.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.DataAcces.Abstracts;

public interface IUserDal : IEntityRepository<User>
{
}
//bhbbuk
