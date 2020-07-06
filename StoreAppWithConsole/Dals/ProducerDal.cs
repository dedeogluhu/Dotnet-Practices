using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAppWithConsole
{
    public static class ProducerDal
    {
        static List<Producer> producerList = new List<Producer>();

        public static void AddProducer(Producer producer)
        {
            producerList.Add(producer);
        }

        public static List<Producer> GetProducers()
        {
            return producerList;
        }
    }
}
