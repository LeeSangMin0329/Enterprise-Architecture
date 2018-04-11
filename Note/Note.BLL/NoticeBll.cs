using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.BLL
{
    public class NoticeBll
    {
        private readonly INoticeDal _noticeDal;

        public NoticeBll(INoticeDal noticeDal)
        {
            _noticeDal = noticeDal;
        }

        /// <summary>
        /// Get Notice list
        /// </summary>
        /// <returns></returns>
        public List<Notice> GetNoticeList()
        {
            return _noticeDal.GetNoticeList();
        }

        /// <summary>
        /// Get Notice
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        public Notice GetNotice(int noticeNo)
        {
            if (noticeNo <= 0) throw new ArgumentException();

            return _noticeDal.GetNotice(noticeNo);
        }

        /// <summary>
        /// Post Notice
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public bool PostNotice(Notice notice)
        {
            if (notice == null) throw new ArgumentException();

            return _noticeDal.PostNotice(notice);
        }

        /// <summary>
        /// Update Notice
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public bool UpdateNotice(Notice notice)
        {
            if (notice == null) throw new ArgumentException();

            return _noticeDal.UpdateNotice(notice);
        }

        /// <summary>
        /// Delete Notice
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        public bool DeleteNotice(int noticeNo)
        {
            if (noticeNo <= 0) throw new ArgumentException();

            return _noticeDal.DeleteNotice(noticeNo);
        }
    }
}
