using PKBuild.Data;

namespace PKBuild.ViewModels;

public partial class PokemonPageViewModel : PkPageViewModel
{
    public PokemonPageViewModel()
    {
        PkbPageNames = PkbPageNames.Pokemon;
    }
    public string BuildTest { get; set; } = "Pokemon";
}