using MovieManager.Core.Entities;

namespace MovieManager.Core.Contracts
{
	public interface ICategoryRepository
	{
		void AddRange(Category[] categories);
	}
}
