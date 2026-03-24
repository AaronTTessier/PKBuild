using System;
using PKBuild.Data;
using PKBuild.Services;
using PKBuild.ViewModels;

namespace PKBuild.Factory;

public class DbFactory(Func<PkDatabaseService> dbFactory)
{
    public PkDatabaseService GetDbService(Action<PkDatabaseService>? afterCreation = null)
    {
        var databaseService = dbFactory();
        
        afterCreation?.Invoke(databaseService);

        return databaseService;
    }
}