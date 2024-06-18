using Exemple_Dependency_Injection.Domain;
using Exemple_Dependency_Injection.IRepo__Interfaces_;

namespace Exemple_Dependency_Injection.Repo
{
	public class RepoUsers : IRepoUsers
	{
		List<UserEntity> _users;
        public RepoUsers()
        {
            _users = new List<UserEntity>
			{
				new UserEntity { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
				new UserEntity { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" },
				new UserEntity { Id = 3, Name = "Alice Johnson", Email = "alice.johnson@example.com" },
				new UserEntity { Id = 4, Name = "Robert Brown", Email = "robert.brown@example.com" },
				new UserEntity { Id = 5, Name = "Mary Davis", Email = "mary.davis@example.com" },
				new UserEntity { Id = 6, Name = "Michael Wilson", Email = "michael.wilson@example.com" },
				new UserEntity { Id = 7, Name = "Patricia Garcia", Email = "patricia.garcia@example.com" },
				new UserEntity { Id = 8, Name = "Linda Martinez", Email = "linda.martinez@example.com" },
				new UserEntity { Id = 9, Name = "William Anderson", Email = "william.anderson@example.com" },
				new UserEntity { Id = 10, Name = "Elizabeth Taylor", Email = "elizabeth.taylor@example.com" }
			};
		}
        public ICollection<UserEntity> GetUsers()
		{
			return _users;
		}
	}
}
