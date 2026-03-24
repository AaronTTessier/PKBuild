using System.Collections.Generic;

namespace PKBuild.Models;

public class ItemPageModel
{
    public int ItemId { get; init; }
    
    public string ItemName { get; init; }
    
    public string ItemType { get; init; }
    
    public string ItemFlavorText { get; init; }
    
    //One-to-many relationship with Pokemon table (Model)
    public ICollection<PokemonPageModel> Pokemon { get; } = new List<PokemonPageModel>();
}