using PKBuild.Data;

namespace PKBuild.ViewModels;

public partial class AnalysisPageViewModel : PkPageViewModel
{
    public AnalysisPageViewModel()
    {
        PkbPageNames = PkbPageNames.Analysis;
    }
    public string BuildTest { get; set; } = "Analysis";
}