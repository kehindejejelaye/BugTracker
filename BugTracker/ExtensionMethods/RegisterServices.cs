using BugTracker.Repositories;
using BugTracker.RepositoryInterfaces;

namespace BugTracker.ExtensionMethods;

public static class RegisterServices
{
    public static void RegisterRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ITicketHistoryRepository, TicketHistoryRepository>();
        services.AddScoped<ITicketRepository, TicketRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IRoleHasPermissionRepository, RoleHasPermissionRepository>();
        services.AddScoped<IProjectRepository, ProjectRepository>();
        services.AddScoped<IProjectHasUsersRepository, ProjectHasUsersRepository>();
        services.AddScoped<IPermissionRepository, PermissionRepository>();
        services.AddScoped<ICommentRepository, CommentRepository>();
    }
}
