using System;
namespace DLL.Model
{
    /// <summary>
    /// loginfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class loginfo
    {
        public loginfo()
        { }
        #region Model
        private int _id;
        private DateTime _addtime;
        private string _adminname;
        private string _action;
        private string _objectname;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime addTime
        {
            set { _addtime = value; }
            get { return _addtime; }
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
        /// 
        /// </summary>
        public string action
        {
            set { _action = value; }
            get { return _action; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string objectname
        {
            set { _objectname = value; }
            get { return _objectname; }
        }
        #endregion Model

    }
}

