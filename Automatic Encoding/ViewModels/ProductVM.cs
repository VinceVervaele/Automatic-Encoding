using System.ComponentModel.DataAnnotations;

namespace Automatic_Encoding.ViewModels
{
    public class ProductVM
    {
        public string? Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }    
    }
}
