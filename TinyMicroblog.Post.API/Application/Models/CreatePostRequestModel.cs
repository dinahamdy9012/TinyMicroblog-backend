﻿using System.ComponentModel.DataAnnotations;

namespace TinyMicroblog.Post.API.Application.Models
{
    public class CreatePostRequestModel
    {
        [Required, MaxLength(140)]
        public string PostText { get; set; } = null!;
        public string? ImageUrl { get; set; }

        [Required]
        public decimal Longitude { get; set; }

        [Required]
        public decimal Latitude { get; set; }
    }
}
