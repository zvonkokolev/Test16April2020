﻿using MovieManager.Core.Contracts;
using MovieManager.Core.Entities;
using System.Linq;

namespace MovieManager.Persistence
{
	public class MovieRepository : IMovieRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public MovieRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public void AddRange(Movie[] movies)
		{
			_dbContext.Movies.AddRange(movies);
		}

		public Movie GetMoviesByDuration() => _dbContext.Movies
																.OrderByDescending(d => d.Duration)
																.ThenBy(d => d.Title)
																.Select(d => d)
																.FirstOrDefault();
	}
}