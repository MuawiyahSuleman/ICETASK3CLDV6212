using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Order
{
    public int OrderId { get; set; }

    [Required]
    public int ProductId { get; set; }

    [Required]
    public int CustomerId { get; set; }

    [Required]
    public DateTime OrderDate { get; set; }

    [Range(1, 1000)]
    public int Quantity { get; set; }

    // Navigation Properties
    public Product Product { get; set; }
    public Customer Customer { get; set; }
}
