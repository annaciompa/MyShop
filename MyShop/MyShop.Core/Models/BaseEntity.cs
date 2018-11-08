using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public abstract class BaseEntity
    {
       public string Id { get; set; }
       public DateTimeOffset CreaedAt { get; set; } // sometimes helpful to see when the class was created
        
        public BaseEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreaedAt = DateTime.Now;           //set to the time of object creation
        }
    }
}
