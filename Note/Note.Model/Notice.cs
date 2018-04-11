using System;
using System.ComponentModel.DataAnnotations;

namespace Note.Model
{
    /// <summary>
    /// Notice
    /// </summary>
    public class Notice
    {
        /// <summary>
        /// Notice number
        /// </summary>
        [Key]
        public int NoticeNo { get; set; }

        /// <summary>
        /// Notice title
        /// </summary>
        [Required]
        public string NoticeTitle { get; set; }

        /// <summary>
        /// Notice contents
        /// </summary>
        [Required]
        public string NoticeContents { get; set; }

        /// <summary>
        /// Notice Write date
        /// </summary>
        [Required]
        public DateTime NoticeWriteDate { get; set; }
    }
}
