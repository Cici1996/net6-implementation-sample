﻿namespace EventAgenda.Models.Models
{
    public class BaseResponseModel
    {
        public bool Succcess { get; set; }
        public dynamic Data { get; set; }
        public List<string> Errors { get; set; }
    }
}