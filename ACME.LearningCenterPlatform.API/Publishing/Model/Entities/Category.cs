using ACME.LearningCenterPlatform.API.Publishing.Model.Commands;

namespace ACME.LearningCenterPlatform.API.Publishing.Model.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } 
    
    public Category()
    {
        Name = string.Empty;
    }
    
    public Category(string name)
    {
        Name = name;
    }
    
    public Category(CreateCategoryCommand command)
    {
        Name = command.Name;
    }
}