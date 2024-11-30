using System.ComponentModel.DataAnnotations;

namespace ShoppingBlazor.Models;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "نام کالا الزامی است")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "قیمت الزامی است")]
    [Range(0, int.MaxValue, ErrorMessage = "قیمت باید عددی مثبت باشد")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "موجودی الزامی است")]
    [Range(0, int.MaxValue, ErrorMessage = "موجودی باید عددی مثبت باشد")]
    public int Availability { get; set; }

    public string? SupplierName { get; set; }
    public string? SupplierEmail { get; set; }

    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public string? ImagePath { get; set; }
    public string? CatalogPath { get; set; }

    public List<string> Colors { get; set; } = new();
    public string? Description { get; set; }

    [Required(ErrorMessage = "دسته‌بندی الزامی است")]
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    [Required(ErrorMessage = "برند الزامی است")]
    public int BrandId { get; set; }
    public Brand? Brand { get; set; }
}