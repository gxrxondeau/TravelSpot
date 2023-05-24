﻿namespace Api.Models.Entities
{
    public class Spot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SpotCategory? Category { get; set; }
        public SpotRating? Rating { get; set; }
        public List<SpotTag>? Tags { get; set; }
        public List<SpotPhoto>? Photos { get; set; }
        public List<SpotAddress>? Address { get; set; }

    }
}
