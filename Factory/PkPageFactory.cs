using System;
using PKBuild.Data;
using PKBuild.ViewModels;

namespace PKBuild.Factory;

public class PkPageFactory(Func<PkbPageNames, PkPageViewModel> factory)
{
    public PkPageViewModel GetPkPageViewModel(PkbPageNames pageNames) => factory.Invoke(pageNames);
}