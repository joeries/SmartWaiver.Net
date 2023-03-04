﻿using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class SignedWaiver
    {
        public SignedWaiver()
        {

        }

        public string Id { get; set; }
        public DateTime TS { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }

        public Waiver Waiver { get; set; }

    }
}
