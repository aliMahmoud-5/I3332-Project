namespace Store.Services.CouponAPI.Models.Dto
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSucces { get; set; } = false;
        public string Message { get; set; } = "";

    }
}
