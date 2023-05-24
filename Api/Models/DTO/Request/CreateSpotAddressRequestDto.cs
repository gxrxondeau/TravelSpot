﻿using Api.Models.Entities;

namespace Api.Models.DTO.Request
{
    public class CreateSpotAddressRequestDto
    {
        public int SpotId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
