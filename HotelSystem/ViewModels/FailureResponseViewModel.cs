using HotelSystem.Models.Enums;

namespace HotelSystem.ViewModels
{
	public class FailureResponseViewModel<T> : ResponseViewModel<T>
	{
		public FailureResponseViewModel(ErrorCode errorCode, string message = "")
		{
			Data = default;
			Message = message;
			IsSuccess = false;
			ErrorCode = errorCode;
		}
	}
}
