using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormOrderData
{
    public class FormOrderSql:IFormOrderSql
    {
        private readonly ISqlDataAccess _db;

        public FormOrderSql(ISqlDataAccess db)
        {
            _db = db;
        }

    }
}
