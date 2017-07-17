namespace Chap3Demo
{
    /// <summary>
    /// 员工类型
    /// </summary>
    public class SE
    {
        /// <summary>
        /// 员工工号
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 性别，true-男，false-女
        /// </summary>
        public bool Gender { get; set; }

        public string GenderText
        {
            get
            {
                return Gender ? "男" : "女";
            }
        }
    }
}
