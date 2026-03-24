using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PKBuild.Data;
using PKBuild.Models;

namespace PKBuild.Services;

public class PkDatabaseService(PKBuildDbContext context) : IDisposable
{
    public void Dispose()
    {
        context.Dispose();
    }

    public void ApplyAllMigrations()
    {
        context.Database.MigrateAsync();
    }

    //TODO: Finish testing logic for logging in user
    //TODO: Implement password hashing to properly store into database
    public void UserRegister(UserPageModel user, string password)
    {
        //Password-to-hash conversion algorithm needed
        /*context.Users.Add(user);
        context.SaveChanges();*/
    }
    
    //TODO: Finish testing logic for retrieving teams for currently logged in user
    public List<TeamsPageModel> GetTeamsForUser(UserPageModel currentUser)
    { 
        var userTeams = context.Teams.Where(t => t.UserId == currentUser.UserId).ToList();

        return userTeams;
    }

    //TODO: Finish testing logic for retrieving Pokemon for currently logged in user
    public List<PokemonPageModel> GetPokemonForUser(UserPageModel currentUser)
    {
        var userPokemon = context.Pokemon.Where(p => p.UserId == currentUser.UserId).ToList();

        return userPokemon;
    }

    //TODO: Finish testing logic for adding Pokemon to the users selected team
    public void AddPokemonToTeam(string teamName, PokemonPageModel pokemon, UserPageModel currentUser)
    {
        var teamToAdd = context.Teams.FirstOrDefault(t => t.TeamName == teamName && t.UserId == currentUser.UserId)
            ?? throw new Exception($"Team {teamName} not found");
        teamToAdd.Pokemon.Add(pokemon);
        
        context.Teams.Update(teamToAdd);
        context.SaveChanges();
    }
    
    //TODO: Finish testing logic for creating a new team
    public void CreateTeam(UserPageModel currentUser, TeamsPageModel team)
    {
        currentUser.Teams.Add(team);
        context.SaveChanges();
    }
    
}