﻿using CalcDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDB.Models
{
    class User : IEntity
    {
        #region IEntity
        public string[] Columns
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public long Id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string SerialData
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string TableName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        //public string TableName => "[dbo].[Operation]";
        //public string[] Colomns => new string[] { "Id", "Name", "OwnerId" };
    }
}
