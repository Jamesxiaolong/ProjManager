using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasks;

namespace CustomContol.Converter
{
    /// <summary>
    /// 常用转换器的静态引用
    /// 使用实例：Converter={x:Static local:XConverter.TrueToFalseConverter}
    /// </summary>
    public sealed class XConverter
    {
        public static ThicknessToDoubleConverter ThicknessToDoubleConverter
        {
            get { return Singleton<ThicknessToDoubleConverter>.GetInstance(); }
        }

        public static PercentToAngleConverter PercentToAngleConverter
        {
            get { return Singleton<PercentToAngleConverter>.GetInstance(); }
        }
    }
}
