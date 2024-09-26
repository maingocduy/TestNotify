﻿namespace ESDManagerApi.Utils
{
    public class TokenInfo
    {
        public string Token { get; set; }
        public string UserName { get; set; }
        public string AccountUuid { get; set; } = string.Empty;

        private DateTime ExpiredDate { get; set; }

        public bool IsExpired()
        {
            return ExpiredDate < DateTime.Now;
        }

        public void ResetExpired()
        {
            ExpiredDate = DateTime.Now.AddMonths(1);
        }
    }
}
