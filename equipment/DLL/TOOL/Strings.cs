//======================================================================
//
//        Copyright (C) 2010 
//        All rights reserved
//        CLR版本:            2.0.50727.3053
//        机器名称:            LG-PC
//        文件名:              ImagePro
//        当前系统时间:      2010-1-19 14:08:22
//        当前登录用户名:   Admin
//        用户:   李钢
//
//======================================================================
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
namespace DLL.TOOL
{
    /// <summary>
    /// 一些常用的字符串函数
    /// </summary>
    public static class Strings
    {
        static string sKey = "advance";
        #region ========加密========
        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Encrypt(string Text)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray;
            inputByteArray = Encoding.Default.GetBytes(Text);
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
        }

        #endregion

        #region ========解密========
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Decrypt(string Text)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            int len;
            len = Text.Length / 2;
            byte[] inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }

        #endregion

        /// <summary>
        /// 左截取
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string Left(string inputString, int len)
        {
            if (inputString.Length < len)
                return inputString;
            else
                return inputString.Substring(0, len);
        }
        /// <summary>
        /// 右截取
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string Right(string inputString, int len)
        {
            if (inputString.Length < len)
                return inputString;
            else
                return inputString.Substring(inputString.Length - len, len);
        }
        /// <summary>
        /// 截取指定长度字符串
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string CutTitle(string stringToSub, int length)
        {
            Regex regex = new Regex("[\u4e00-\u9fa5]+", RegexOptions.Compiled);
            char[] stringChar = stringToSub.ToCharArray();
            StringBuilder sb = new StringBuilder();
            int nLength = 0;
            bool isCut = false;
            for (int i = 0; i < stringChar.Length; i++)
            {
                if (regex.IsMatch((stringChar[i]).ToString()))
                {
                    sb.Append(stringChar[i]);
                    nLength += 2;
                }
                else
                {
                    sb.Append(stringChar[i]);
                    nLength = nLength + 1;
                }

                if (nLength > length)
                {
                    isCut = true;
                    break;
                }
            }
            if (isCut)
                return sb.ToString() + "...";
            else
                return sb.ToString();
        }

        /// <summary>
        /// 截取指定长度字符串(常用)
        /// </summary>
        /// <param name="stringToSub"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GetFirstString(string stringToSub, int length)
        {
            Regex regex = new Regex("[\u4e00-\u9fa5]+", RegexOptions.Compiled);
            char[] stringChar = stringToSub.ToCharArray();
            StringBuilder sb = new StringBuilder();
            int nLength = 0;
            bool isCut = false;
            for (int i = 0; i < stringChar.Length; i++)
            {
                if (regex.IsMatch((stringChar[i]).ToString()))
                {
                    sb.Append(stringChar[i]);
                    nLength += 2;
                }
                else
                {
                    sb.Append(stringChar[i]);
                    nLength = nLength + 1;
                }

                if (nLength > length)
                {
                    isCut = true;
                    break;
                }
            }
            if (isCut)
                return "<span title=\"" + stringToSub + "\">" + sb.ToString() + "...</span>";
            else
                return sb.ToString();
        }        
        /// <summary>  
        /// 重写截取字符串方法，这里的长度是字节数（汉字2个字节，外语字符1个字节）  
        /// </summary>  
        /// <param name="str"></param>  
        /// <param name="length">截取长度（这里的长度是字节数，汉字2个字节，外语字符1个字节）</param>  
        /// <returns></returns>  
        public static string GetFString(string str, int length)
        {
            int len = 0;
            char[] arr = str.ToCharArray();
            string strReturn = string.Empty;
            if (length > Length(str))
            {
                return str;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (Asc(arr[i].ToString()) == -1)
                    len += 2;
                else
                    len += 1;

                if (len > length)
                    break;

                strReturn += arr[i].ToString();
            }
            return strReturn + "...";
        }

        /// <summary>  
        /// 字符转ASCII码，如果未能转换为ASCII码返回-1  
        /// </summary>  
        /// <param name="character"></param>  
        /// <returns></returns>  
        public static int Asc(string character)
        {
            if (character.Length == 1)
            {
                //因为汉字和?都被转换为63，所以?进行提前处理  
                if (character == "?")
                    return 63;

                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                int intAsciiCode = (int)asciiEncoding.GetBytes(character)[0];

                //如果未能转换为ASCII码（暂且认为为汉字）  
                if (intAsciiCode == 63)
                    return -1;

                return (intAsciiCode);
            }
            else
            {
                throw new Exception("Character is not valid.");
            }
        }
        /// <summary>  
        /// 求字符串的实际长度（汉字2个字节，外语字符1个字节）  
        /// </summary>  
        /// <param name="str"></param>  
        /// <returns></returns>  
        public static int Length(string str)
        {
            int len = 0;
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                //汉字  
                if (Asc(arr[i].ToString()) == -1)
                    len += 2;
                else
                    len += 1;
            }

            return len;
        }
        /// <summary>
        /// 不区分大小写的替换
        /// </summary>
        /// <param name="original">原字符串</param>
        /// <param name="pattern">需替换字符</param>
        /// <param name="replacement">被替换内容</param>
        /// <returns></returns>
        public static string ReplaceEx(string original, string pattern, string replacement)
        {
            int count, position0, position1;
            count = position0 = position1 = 0;
            string upperString = original.ToUpper();
            string upperPattern = pattern.ToUpper();
            int inc = (original.Length / pattern.Length) * (replacement.Length - pattern.Length);
            char[] chars = new char[original.Length + Math.Max(0, inc)];
            while ((position1 = upperString.IndexOf(upperPattern, position0)) != -1)
            {
                for (int i = position0; i < position1; ++i) chars[count++] = original[i];
                for (int i = 0; i < replacement.Length; ++i) chars[count++] = replacement[i];
                position0 = position1 + pattern.Length;
            }
            if (position0 == 0) return original;
            for (int i = position0; i < original.Length; ++i) chars[count++] = original[i];
            return new string(chars, 0, count);
        }
        /// <summary>
        /// 替换html中的特殊字符
        /// </summary>
        /// <param name="theString">需要进行替换的文本。</param>
        /// <returns>替换完的文本。</returns>
        public static string HtmlEncode(string theString)
        {
            if (!String.IsNullOrEmpty(theString))
            {
                theString = theString.Replace(">", "&gt;");
                theString = theString.Replace("<", "&lt;");
                theString = theString.Replace("  ", " &nbsp;");
                theString = theString.Replace(" ", "&nbsp;");
                theString = theString.Replace("\"", "&quot;");
                theString = theString.Replace("'", "&#39;");
                theString = theString.Replace("\r\n", "<br /> ");
                theString = theString.Replace("\n", "<br /> ");
                return theString;
            }
            return theString;
        }

        /// <summary>
        /// 恢复html中的特殊字符
        /// </summary>
        /// <param name="theString">需要恢复的文本。</param>
        /// <returns>恢复好的文本。</returns>
        public static string HtmlDecode(string theString)
        {
            if (!String.IsNullOrEmpty(theString))
            {
                theString = theString.Replace("&gt;", ">");
                theString = theString.Replace("&lt;", "<");
                theString = theString.Replace("&nbsp;", " ");
                theString = theString.Replace(" &nbsp;", "  ");
                theString = theString.Replace("&quot;", "\"");
                theString = theString.Replace("&#39;", "'");
                theString = theString.Replace("<br /> ", "\n");
                return theString;
            }
            return theString;
        }
        /// <summary>
        /// 将html转成js代码,不完全和原始数据一致
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Html2Js(string source)
        {
            return String.Format("document.writeln(\"{0}\");",
                String.Join("\");\r\ndocument.writeln(\"", source.Replace("\\", "\\\\")
                                        .Replace("/", "\\/")
                                        .Replace("'", "\\'")
                                        .Replace("\"", "\\\"")
                                        .Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            ));
        }
        /// <summary>
        /// 将html转成可输出的js字符串,不完全和原始数据一致
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Html2JsStr(string source)
        {
            return String.Format("{0}",
                String.Join(" ", source.Replace("\\", "\\\\")
                                        .Replace("/", "\\/")
                                        .Replace("'", "\\'")
                                        .Replace("\"", "\\\"")
                                        .Replace("\t", "")
                                        .Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            ));
        }
        /// <summary>
        /// 过滤所有特殊特号
        /// </summary>
        /// <param name="theString"></param>
        /// <returns></returns>
        public static string FilterSymbol(string theString)
        {
            string[] aryReg = { "'", "\"", "\r", "\n", "<", ">", "%", "?", ",", ".", "=", "-", "_", ";", "|", "[", "]", "&", "/" };
            for (int i = 0; i < aryReg.Length; i++)
            {
                theString = theString.Replace(aryReg[i], string.Empty);
            }
            return theString;
        }
        /// <summary>
        /// 过滤一般特殊特号,如单引、双引和回车和分号等
        /// </summary>
        /// <param name="theString"></param>
        /// <returns></returns>
        public static string SafetyStr(string theString)
        {
            string[] aryReg = { "'", ";", "\"", "\r", "\n", "<", ">" };
            for (int i = 0; i < aryReg.Length; i++)
            {
                theString = theString.Replace(aryReg[i], string.Empty);
            }
            return theString;
        }
        /// <summary>
        /// 取星期
        /// </summary>
        /// <returns></returns>
        static public string DatetimeWeek()
        {
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday": return "星期一";
                case "Tuesday": return "星期二";
                case "Wednesday": return "星期三";
                case "Thursday": return "星期四";
                case "Friday": return "星期五";
                case "Saturday": return "星期六";
                case "Sunday": return "星期日";
            }
            return "";
        }
    }
}
