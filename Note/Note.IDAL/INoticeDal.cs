using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.IDAL
{
    public interface INoticeDal
    {
        /// <summary>
        /// Get Notice list
        /// </summary>
        /// <returns></returns>
        List<Notice> GetNoticeList();

        /// <summary>
        /// Get Notice
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        Notice GetNotice(int noticeNo);

        /// <summary>
        /// Post Notice
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        bool PostNotice(Notice notice);

        /// <summary>
        /// Update Notice
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        bool UpdateNotice(Notice notice);

        /// <summary>
        /// Delete Notice
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        bool DeleteNotice(int noticeNo);
    }
}
