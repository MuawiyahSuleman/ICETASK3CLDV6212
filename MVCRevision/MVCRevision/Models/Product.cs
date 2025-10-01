using System.ComponentModel.DataAnnotations;

public class Product
{
    public int ProductId { get; set; }

    [Required, StringLength(100)]
    public string Name { get; set; }

    [Range(0.01, 100000)]
    public decimal Price { get; set; }
}
