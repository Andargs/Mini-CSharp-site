using System;
using System.Collections.Generic;
using System.Linq;
using UiS.Dat240.Lab3.SharedKernel;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UiS.Dat240.Lab3.Core.Domain.Invoicing
{
    public class Address : BaseEntity // Legg inn som valueobject. Tror det var i startup 
    // ikke migrated
    {
        public Address(string building, int roomNumber, string notes){ //Hadde originalt customername og notes, tror egentlig ikke jeg skal trenge location eller orderinglinesdto dritten
            Building = building;
            RoomNumber = roomNumber;
            Notes = notes;
        }
        public string Building { get; set; }

        public int RoomNumber { get; set; }

        public string Notes {get; set;}
        

    }
}