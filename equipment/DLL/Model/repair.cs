using System;
namespace DLL.Model
{
    /// <summary>
    /// repair:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class repair
    {
        public repair()
        { }
        #region Model
        private int _id;
        private int _computerid;
        private string _defineid;
        private int _adminid;
        private string _adminname;
        private string _ftype;
        private string _result;
        private DateTime _addtime;
        /// <summary>
        /// 主键
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 报修机器，外键对应computer
        /// </summary>
        public int computerId
        {
            set { _computerid = value; }
            get { return _computerid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string defineId
        {
            set { _defineid = value; }
            get { return _defineid; }
        }
        /// <summary>
        /// 管理员id
        /// </summary>
        public int adminId
        {
            set { _adminid = value; }
            get { return _adminid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string adminname
        {
            set { _adminname = value; }
            get { return _adminname; }
        }
        /// <summary>
        /// 报修类型(硬件，软件，支持)
        /// </summary>
        public string ftype
        {
            set { _ftype = value; }
            get { return _ftype; }
        }
        /// <summary>
        /// 报修结果
        /// </summary>
        public string result
        {
            set { _result = value; }
            get { return _result; }
        }
        /// <summary>
        /// 报修时间
        /// </summary>
        public DateTime addTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        #endregion Model

    }
}

