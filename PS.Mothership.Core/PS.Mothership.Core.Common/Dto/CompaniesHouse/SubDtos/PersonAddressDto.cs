﻿using System.Collections.Generic;

namespace PS.Mothership.Core.Common.Dto.CompaniesHouse.SubDtos
{
    public class PersonAddressDto
    {
        public string CareOfName { get; set; }
        public string PoBox { get; set; }
        public IList<string> AddressLine { get; set; }
        public string PostTown { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
    }
}
