using System.ComponentModel.DataAnnotations;

namespace demo_2.Models
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