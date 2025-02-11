﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartHealthcare.Dtos.DoctorsDto
{
    public class DoctorDto
    {
        public int DoctorId { get; set; }
        public string Name { get; set; } 
        public string? Info { get; set; }
        public string? ProfilePicture { get; set; }
        public string? AvailableTime { get; set; }
        public int? CenterId { get; set; }
        public int? DepartmentId { get; set; }
        public double? rating { get; set; }
    }
}
