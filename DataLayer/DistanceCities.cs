using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class DistanceCities
    {

        public static IDictionary<(int, int), int> cities = new System.Collections.Generic.Dictionary<(int, int), int>()
        {
            {(44,6),652},
            {(44,17),1304},
            {(44,34),1103},
            {(44,35),1190},
            {(6,17),665},
            {(6,34),453},
            {(6,35),584},
            {(17,34),316},
            {(17,35),327},
            {(34,35),566}
        };

        public static IDictionary<int, string> CityNames = new Dictionary<int, string>()
        {
             {44, "Malatya"},
             {6, "Ankara"},
             {17, "Çanakkale"},
             {34, "İstanbul"},
             {35, "İzmir"}
        };

    }
}
