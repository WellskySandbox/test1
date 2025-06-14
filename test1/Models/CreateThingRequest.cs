﻿using System.ComponentModel.DataAnnotations;

namespace test1.Models
{
    /// <summary>
    /// Request for creating a thing.
    /// </summary>
    public class CreateThingRequest
    {
        /// <summary>
        /// The name of the thing
        /// </summary>
       [Required]
       public string Name { get; set; }
    }
}