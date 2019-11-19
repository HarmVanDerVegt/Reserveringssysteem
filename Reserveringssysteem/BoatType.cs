﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reserveringssysteem
{
    public class BoatType
    {

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public bool HasCoxswain { get; set; }

        [Required]
        public Certificate Certificate { get; set; }

        public List<Match> Matches { get; set; }
        public List<Boat> Boats { get; set; }

        public BoatType(string name, int size, bool hasCoxswain)
        {
            Name = name;
            Size = size;
            HasCoxswain = hasCoxswain;
            Certificate = new Certificate($"Certificate {name}");
            Certificate.Type = this;

            using (var db = new ReserveringssysteemContext())
            {
                db.Certificates.Add(Certificate);
            }
        }

        private BoatType() { }
    }
}
