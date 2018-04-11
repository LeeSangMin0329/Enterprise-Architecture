using Microsoft.Extensions.Configuration;
using Note.DAL.DataContext;
using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Note.DAL
{
    public class NoticeDal : INoticeDal
    {
        private readonly IConfiguration _configuration;

        public NoticeDal(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Get Notice list
        /// </summary>
        /// <returns></returns>
        public List<Notice> GetNoticeList()
        {
            using (var db = new NoteDbContext(_configuration))
            {
                return db.Notices
                    .OrderByDescending(n=>n.NoticeNo)
                    .ToList();
            }
        }
        
        /// <summary>
        /// Get Notice
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        public Notice GetNotice(int noticeNo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Post Notice
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public bool PostNotice(Notice notice)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update Notice
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public bool UpdateNotice(Notice notice)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete Notice
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        public bool DeleteNotice(int noticeNo)
        {
            throw new NotImplementedException();
        }
    }
}
