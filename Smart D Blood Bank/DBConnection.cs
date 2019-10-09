using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_D_Blood_Bank
{
  
        public class DBconnection
        {
            public string connection;
            public bool status;
            
            public bool checkConn()
        {
            connection = @"Data Source=.\sqlexpress;Initial Catalog=Bank;Integrated Security=True;Pooling=False";
            status = true;
            return status;
        }
        }
    
}
