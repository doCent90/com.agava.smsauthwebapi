﻿namespace SmsAuthAPI.DTO
{
    /// <summary>
    ///     Client data storage.
    /// </summary>
    public class LoginData
    {
        public string phone { get; set; }
        public string otp_code { get; set; }
        public string device_id { get; set; }
    }
}
