using System;
namespace DLL.Model
{
    /// <summary>
    /// computer:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class computer
    {
        public computer()
        { }
        #region Model
        private int _id;
        private string _defineid;
        private string _type;
        private string _brand;
        private string _version;
        private string _mac;
        private string _nettype;
        private string _innerip;
        private string _outerip;
        private string _screeninfo;
        private string _printerinfo;
        private string _scannerinfo;
        private string _roomnum;
        private string _department;
        private string _username;
        private int? _addid;
        private DateTime? _addtime = DateTime.Now;
        private int _updateid;
        private DateTime? _updatetime = DateTime.Now;
        private string _description;
        private int _flag;
        private DateTime? _buytime;
        private DateTime? _givetime;
        /// <summary>
        /// 主键
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
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
        /// 机器类型（笔记本／台式机）
        /// </summary>
        public string type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 品牌
        /// </summary>
        public string brand
        {
            set { _brand = value; }
            get { return _brand; }
        }
        /// <summary>
        /// 型号
        /// </summary>
        public string version
        {
            set { _version = value; }
            get { return _version; }
        }
        /// <summary>
        /// mac地址
        /// </summary>
        public string mac
        {
            set { _mac = value; }
            get { return _mac; }
        }
        /// <summary>
        /// 网络类型(内/外网)
        /// </summary>
        public string nettype
        {
            set { _nettype = value; }
            get { return _nettype; }
        }
        /// <summary>
        /// 内网ＩＰ
        /// </summary>
        public string innerIP
        {
            set { _innerip = value; }
            get { return _innerip; }
        }
        /// <summary>
        /// 外网ＩＰ
        /// </summary>
        public string outerIP
        {
            set { _outerip = value; }
            get { return _outerip; }
        }
        /// <summary>
        /// 显示器信息
        /// </summary>
        public string screenInfo
        {
            set { _screeninfo = value; }
            get { return _screeninfo; }
        }
        /// <summary>
        /// 打印机信息
        /// </summary>
        public string printerInfo
        {
            set { _printerinfo = value; }
            get { return _printerinfo; }
        }
        /// <summary>
        /// 扫描仪信息
        /// </summary>
        public string scannerInfo
        {
            set { _scannerinfo = value; }
            get { return _scannerinfo; }
        }
        /// <summary>
        /// 房间号
        /// </summary>
        public string roomNum
        {
            set { _roomnum = value; }
            get { return _roomnum; }
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string department
        {
            set { _department = value; }
            get { return _department; }
        }
        /// <summary>
        /// 使用者姓名
        /// </summary>
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 添加者ｉｄ
        /// </summary>
        public int? addId
        {
            set { _addid = value; }
            get { return _addid; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? addtime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        /// <summary>
        /// 更新者ｉｄ
        /// </summary>
        public int updateId
        {
            set { _updateid = value; }
            get { return _updateid; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? updateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 机器描述
        /// </summary>
        public string description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int flag
        {
            set { _flag = value; }
            get { return _flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? buyTime
        {
            set { _buytime = value; }
            get { return _buytime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? giveTime
        {
            set { _givetime = value; }
            get { return _givetime; }
        }
        #endregion Model

    }
}

