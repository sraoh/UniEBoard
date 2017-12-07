﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMatrix.Data;

namespace Cognite.MembershipProvider
{
    internal class DatabaseConnectionInfo
    {
        private string _connectionStringName;
        private string _connectionString;

        private enum ConnectionType
        {
            ConnectionStringName = 0,
            ConnectionString = 1
        }

        public string ConnectionString
        {
            get { return _connectionString; }
            set
            {
                _connectionString = value;
                Type = ConnectionType.ConnectionString;
            }
        }

        public string ConnectionStringName
        {
            get { return _connectionStringName; }
            set
            {
                _connectionStringName = value;
                Type = ConnectionType.ConnectionStringName;
            }
        }

        public string ProviderName { get; set; }

        private ConnectionType Type { get; set; }

        public Database Connect()
        {
            switch (Type)
            {
                case ConnectionType.ConnectionString:
                    return Database.OpenConnectionString(ConnectionString, ProviderName);
                case ConnectionType.ConnectionStringName:
                    return Database.Open(ConnectionStringName);
                default:
                    return null;
            }
        }
    }
}
