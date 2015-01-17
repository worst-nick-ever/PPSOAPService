using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PPSOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFactorialService" in both code and config file together.
    [ServiceContract]
    public interface IFactorialService
    {
        [OperationContract]
        CalculateFactorialResponse CalculateFactorial(uint number);
    }

    [DataContract]
    public class CalculateFactorialResponse
    {
        private int status;
        private double factorial = 1;
        private string message;

        [DataMember]
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        [DataMember]
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        [DataMember]
        public double Value
        {
            get { return factorial; }
            set { factorial = value; }
        }
    }
}
