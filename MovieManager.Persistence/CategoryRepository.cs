using MovieManager.Core.Contracts;
using MovieManager.Core.Entities;

namespace MovieManager.Persistence
{
	internal class CategoryRepository : ICategoryRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public CategoryRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public void AddRange(Category[] categ)
		{
			_dbContext.Categories.AddRange(categ);
		}
	}
}