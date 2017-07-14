using System;

namespace OfficeConvert
{
    [Serializable]
    public class ConvertException: Exception
    {
        public ConvertException(String message) : base(message)
        {
        }
    }
}
