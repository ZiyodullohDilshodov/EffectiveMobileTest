namespace EffectiveMobile.Service.Exceptions
{
    public  class EffectiveMobileException : Exception
    {
        public int StatusCode { get; set; }
        public EffectiveMobileException(int statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
