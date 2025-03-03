using HotelSystem.Models.Enums;

namespace HotelSystem.ViewModels
{
	public class SuccessResponseViewModel<T> : ResponseViewModel<T>
	{
		public SuccessResponseViewModel(T? data, string message = "")
		{
			Data = data;
			Message = message;
			IsSuccess = true;
			ErrorCode = ErrorCode.None;
		}
	}
}
