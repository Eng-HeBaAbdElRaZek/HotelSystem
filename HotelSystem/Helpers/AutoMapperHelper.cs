using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace HotelSystem.Helpers
{
	public static class AutoMapperHelper
	{
		public static IMapper Mapper { get; set; }

		public static T Map<T>(this object source)
		{
			return Mapper.Map<T>(source);
		}

		public static IQueryable<T> Project<T>(this IQueryable<object> source)
		{
			return source.ProjectTo<T>(Mapper.ConfigurationProvider);
		}
	}
}
