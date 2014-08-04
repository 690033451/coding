using System;
namespace DLL.Model
{
    /// <summary>
    /// admin:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class admin
    {
        public admin()
        { }
        #region Model
        private int _id;
        private string _username;
        private string _tel;
        private string _userid;
        private string _password;
        /// <summary>
        /// 主键
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 登录名
        /// </summary>
        public string userId
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        #endregion Model

    }
}

