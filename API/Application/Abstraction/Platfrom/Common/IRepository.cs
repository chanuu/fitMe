﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Platfrom.Common
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitofWork UnitOfWork { get; }
    }
}
