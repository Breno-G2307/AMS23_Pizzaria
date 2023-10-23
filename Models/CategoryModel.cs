using System;
public class CategoryModel
{
    public CategoryModel()
    {
        Id = Guid.NewGuid();
        Description = Description;
        IsActive = true;

    }
    public Guid Id {get; set;}
    public string Description {get; set;}
    public bool IsActive {get; set;}


    
}