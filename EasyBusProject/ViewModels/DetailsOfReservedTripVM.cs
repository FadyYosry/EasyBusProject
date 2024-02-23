﻿using System.ComponentModel.DataAnnotations;

namespace EasyBusProject.ViewModels
{
    public class DetailsOfReservedTripVM
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public int NumOfAvailSeats { get; set; }
        public string BusName { get; set; }
        public int Price { get; set; }
        public string StartFrom { get; set; }
        public string Destination { get; set; }

        //[Range(1,5,ErrorMessage = "Choose valid number")]
        public int NumOfSeatsOfUser { get; set; }
        public int TotalCapacity { get; set; }

    }
}