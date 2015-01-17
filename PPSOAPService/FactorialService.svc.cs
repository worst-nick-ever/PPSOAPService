using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PPSOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FactorialService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FactorialService.svc or FactorialService.svc.cs at the Solution Explorer and start debugging.
    public class FactorialService : IFactorialService
    {
        public CalculateFactorialResponse CalculateFactorial(uint number)
        {
            CalculateFactorialResponse response = new CalculateFactorialResponse();

            if (number <= 0)
            {
                response.Status = -1;
                response.Value = 0;
                response.Message = "Invalid input";

                return response;
            }

            for (uint i = 1; i <= number; i++)
            {
                response.Value *= i;
            }

            response.Status = 0;
            response.Message = "Success!";

            return response;
        }
    }
}
