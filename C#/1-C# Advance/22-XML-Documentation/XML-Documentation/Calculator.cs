using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Documentation
{
    /// <summary>
    /// این کلاس برای عملیات ریاضی استفاده میشود
    /// <list type="number" >
    /// <item>
    ///     <term>Add</term>
    ///     <description>با این متد میتوانید دو عدد را باهم جمع کنید.</description>
    /// </item>
    /// <item>
    ///     <term>Div</term>
    ///     <description>با این متد میتوانید دو عدد را باهم تقسیم کنید.</description>
    /// </item>
    /// <item></item>
    /// </list>
    /// </summary>
    /// <remarks>
        /// <para>
        ///     این یک کلاس برای عملیات های ساده ریاضی میباشد
        /// </para>
        /// <para>
        ///     این یک متن آزمایشی هست  
        /// </para>
    /// </remarks>
    /// 
    public class Calculator
    {
        /// <summary>
        /// جمع دو عدد
        /// </summary>
        /// <param name="x">پارامتر اول</param>
        /// <param name="y">پارامتر دوم</param>
        /// <returns>خروجی حاصل جمع دو عدد میباشد</returns>
        /// <example>
        /// <code>
        /// int result=Calculator.Add(1,2);
        /// Console.WriteLine(result);
        /// </code>
        /// </example>
        /// <exception cref="System.OverflowException"></exception>"
        /// <exception cref="System.NotImplementedException"></exception>"
        public static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// تقسیم دو عدد
        /// </summary>
        /// <param name="x">پارامتر اول</param>
        /// <param name="y">پارامتر دوم</param>
        /// <returns></returns>
        public static int Div(int x, int y)
        {
            return x / y;
        }
    }
}
