

using Exemple_Dependency_Injection.Domain;

namespace Exemple_Dependency_Injection.IRepo__Interfaces_;

public interface IRepoUsers
{
	public ICollection<UserEntity> GetUsers();
}
