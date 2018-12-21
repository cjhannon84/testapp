using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MobileApp.Core.Interfaces
{
    public interface IDbConnectionFactory
    {
        IDbConnection GetConnection(); 
    }
}
