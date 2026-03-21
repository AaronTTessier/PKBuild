using System;
using PKBuild.Data;
using PKBuild.ViewModels;

namespace PKBuild.Factory;

public class DbFactory(Func<PkbPageNames, PkPageViewModel> dbFactory)
{
    public PkPageViewModel GetPkPageViewModel(PkbPageNames pageNames) => dbFactory.Invoke(pageNames);
}