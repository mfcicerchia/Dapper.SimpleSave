﻿namespace PS.Mothership.Core.Common.Dto.CompaniesHouse.SubDtos
{
    public class OfficerSearchItemDto
    {
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string Dob { get; set; }
        public string Posttown { get; set; }
        public string Postcode { get; set; }
        public string CountryOfResidence { get; set; }
        public string PersonId { get; set; }
        public string SearchMatch { get; set; }
        public DuplicateOfficersDto DuplicateOfficers { get; set; }
    }
}
