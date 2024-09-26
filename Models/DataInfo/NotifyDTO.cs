namespace ESDManagerApi.Models.DataInfo
{
    public class NotifyDTO
    {
        public string Uuid { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

      
        /// <summary>
        /// 0 - chưa đọc , 1 - đã đọc
        /// </summary>
        
        public object Data { get; set; }
        public int State { get; set; }

        public int Status { get; set; }

        public DateTime TimeCreated { get; set; }
    }
}
