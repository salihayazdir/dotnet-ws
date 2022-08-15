using System;
namespace dotnet_ws
{
    public class AtmResponse
    {
        public class Results
        {
            public string? command { get; set; }
            public string? rowCount { get; set; }
            public string? oid { get; set; }
            public List<Atm>? rows { get; set; }
        }

        public bool success { get; set; }
        public Results? results { get; set; }

    }
}

